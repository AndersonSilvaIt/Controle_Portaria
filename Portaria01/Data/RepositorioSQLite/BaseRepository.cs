using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using Data.Entidades;

namespace Data.RepositorioSQLite {

	public class BaseRepository<T> where T : BaseEntity {

		const string COLLATE_NOCASE_VALUE = " COLLATE NOCASE ";

		public static void Save(T Entity) {
			object[] attributesObject;

			using(var conection = BaseData.DbConnection()) {
				StringBuilder sb = new StringBuilder();
				sb.Append($"insert into { Entity.GetType().Name } ( ");
				var properties = Entity.GetType().GetProperties();

				object instanceEntity = Activator.CreateInstance(Entity.GetType());

				foreach(var item in properties) {

					attributesObject = item.GetCustomAttributes(false);
					if(attributesObject != null && attributesObject.Length > 0 && attributesObject.Any(x => x is NotMappedAttribute)) {
						continue;
					}

					if(item.Name.ToUpper() != "ID")
						sb.Append($"{item.Name},");
				}

				sb.Remove(sb.Length - 1, 1);
				sb.Append(" ) values ( ");

				foreach(var item in properties) {
					attributesObject = item.GetCustomAttributes(false);
					if(attributesObject != null && attributesObject.Length > 0 && attributesObject.Any(x => x is NotMappedAttribute)) {
						continue;
					}
					if(item.Name.ToUpper() != "ID")
						sb.Append($"@{item.Name},");
				}

				sb.Remove(sb.Length - 1, 1);
				sb.Append(" )");

				using(var command = conection.CreateCommand()) {
					command.CommandText = sb.ToString();

					foreach(var item in properties) {

						attributesObject = item.GetCustomAttributes(false);
						if(attributesObject != null && attributesObject.Length > 0 && attributesObject.Any(x => x is NotMappedAttribute)) {
							continue;
						}

						if(item.PropertyType.Name == "DateTime")
							command.Parameters.AddWithValue("@" + item.Name, ((DateTime)item.GetValue(Entity, null)).ToString("yyyy-MM-dd HH:mm:ss"));
						else
							command.Parameters.AddWithValue("@" + item.Name, item.GetValue(Entity, null));

						switch(item.PropertyType.Name) {
						case "DateTime":
							command.Parameters.AddWithValue("@" + item.Name, ((DateTime)item.GetValue(Entity, null)).ToString("yyyy-MM-dd HH:mm:ss"));
							break;

						case "String":
							command.Parameters.AddWithValue("@" + item.Name, item.GetValue(Entity, null));
							break;

						case "Decimal":
						case "Double":
							command.Parameters.AddWithValue("@" + item.Name, item.GetValue(Entity, null));
							break;

						case "Int32":
						case "Int64":
							if(item.Name.ToUpper() != "ID") {
								command.Parameters.AddWithValue("@" + item.Name, item.GetValue(Entity, null));
							}
							break;

						case "Boolean":
							bool valueBool = (bool)item.GetValue(Entity, null);
							int intBoolValue = valueBool == true ? 1 : 0;

							command.Parameters.AddWithValue("@" + item.Name, intBoolValue);
							break;

						case "Byte[]":
						case "byte[]":
							byte[] byteValue = (byte[])item.GetValue(Entity, null);
							command.Parameters.AddWithValue("@" + item.Name, byteValue);
							break;
						}
					}

					command.ExecuteNonQuery();
				}
			}
		}

		public static void Delete(T Entity) {

			using(var conection = BaseData.DbConnection()) {
				object instanceEntity = Activator.CreateInstance(Entity.GetType());

				var properties = Entity.GetType().GetProperty("Id");

				string sql = $" delete from {Entity.GetType().Name} where Id = { Entity.Id}";

				using(var command = conection.CreateCommand()) {
					command.CommandText = sql;
					command.ExecuteNonQuery();
				}
			}
		}

		public static IList<T> GetAll() {
			return GetAll("Id");
		}

		public static IList<T> GetAll(string orderBy) {
			var instanceEntity = Activator.CreateInstance<T>();
			var properties = instanceEntity.GetType().GetProperties();
			IList<T> listObject = new List<T>();

			using(var conection = BaseData.DbConnection()) {
				string orderByCommand = string.Empty;
				if(!string.IsNullOrWhiteSpace(orderBy))
					orderByCommand = " ORDER BY " + orderBy;

				SQLiteCommand sQLiteCommand = new SQLiteCommand($"SELECT * FROM {instanceEntity.GetType().Name} {orderByCommand} {COLLATE_NOCASE_VALUE} ", conection);
				decimal decimalValue = 0;
				//double doubleValue = 0;
				int intValue = 0;
				DateTime dateValue = DateTime.MinValue;
				object[] attributesObject;

				using(var read = sQLiteCommand.ExecuteReader()) {
					while(read.Read()) {
						instanceEntity = Activator.CreateInstance<T>();

						foreach(var item in properties) {
							attributesObject = item.GetCustomAttributes(false);
							if(attributesObject != null && attributesObject.Length > 0 && attributesObject.Any(x => x is NotMappedAttribute)) {
								continue;
							}
							switch(item.PropertyType.Name) {
							case "String":
								instanceEntity.GetType().GetProperty(item.Name).SetValue(instanceEntity, Convert.ToString(read[item.Name]));
								break;

							case "Char":
								int defaultCharValue = 255; //Space
								int.TryParse(Convert.ToString(read[item.Name]), out defaultCharValue);
								instanceEntity.GetType().GetProperty(item.Name).SetValue(instanceEntity, Convert.ToChar(defaultCharValue));
								break;

							case "Decimal":
								if(read[item.Name] != null && decimal.TryParse(Convert.ToString(read[item.Name]), out decimalValue))
									instanceEntity.GetType().GetProperty(item.Name).SetValue(instanceEntity, decimalValue);
								break;

							case "Int32":
							case "Int64":
								if(read[item.Name] != null && int.TryParse(Convert.ToString(read[item.Name]), out intValue))
									instanceEntity.GetType().GetProperty(item.Name).SetValue(instanceEntity, intValue);
								break;

							case "DateTime":
								if(read[item.Name] != null && DateTime.TryParse(Convert.ToString(read[item.Name]), out dateValue))
									instanceEntity.GetType().GetProperty(item.Name).SetValue(instanceEntity, dateValue);
								break;

							case "Boolean":
								if(read[item.Name] != null && int.TryParse(Convert.ToString(read[item.Name]), out intValue)) {
									bool boolValue = intValue == 1;
									instanceEntity.GetType().GetProperty(item.Name).SetValue(instanceEntity, boolValue);
								}
								break;

							case "byte[]":
							case "Byte[]":
								byte[] valorByte;

								if(read[item.Name] != null && ((read[item.Name] as byte[]) != null)) {
									valorByte = (byte[])read[item.Name];
									instanceEntity.GetType().GetProperty(item.Name).SetValue(instanceEntity, valorByte);
								}
									
								break;
							}
						}

						listObject.Add(instanceEntity);
					}
					return listObject;
				}
			}
			//return null;
		}

		public static IList<T> GetAll(FilterCriteria filterCriteria) {
			return GetAll(filterCriteria, "Id");
		}

		public static IList<T> GetAll(FilterCriteria filterCriteria, string orderBy) {
			var instanceEntity = Activator.CreateInstance<T>();
			var properties = instanceEntity.GetType().GetProperties();
			IList<T> listObject = new List<T>();

			using(var conection = BaseData.DbConnection()) {
				string sqlWhere = string.Empty;
				if(filterCriteria != null)
					sqlWhere = " WHERE " + filterCriteria.ToString(instanceEntity);

				string orderByCommand = string.Empty;
				if(!string.IsNullOrWhiteSpace(orderBy))
					orderByCommand = " ORDER BY " + orderBy;

				SQLiteCommand sQLiteCommand = new SQLiteCommand($"SELECT * FROM {instanceEntity.GetType().Name} {sqlWhere} {orderByCommand} {COLLATE_NOCASE_VALUE} ", conection);
				decimal decimalValue = 0;
				//double doubleValue = 0;
				int intValue = 0;
				DateTime dateValue = DateTime.MinValue;
				object[] attributesObject;

				using(var read = sQLiteCommand.ExecuteReader()) {
					while(read.Read()) {
						instanceEntity = Activator.CreateInstance<T>();

						foreach(var item in properties) {
							attributesObject = item.GetCustomAttributes(false);
							if(attributesObject != null && attributesObject.Length > 0 && attributesObject.Any(x => x is NotMappedAttribute)) {
								continue;
							}
							switch(item.PropertyType.Name) {
							case "String":
								instanceEntity.GetType().GetProperty(item.Name).SetValue(instanceEntity, Convert.ToString(read[item.Name]));
								break;

							case "Char":
								instanceEntity.GetType().GetProperty(item.Name).SetValue(instanceEntity, Convert.ToChar(read[item.Name]));
								break;

							case "Decimal":
								if(read[item.Name] != null && decimal.TryParse(Convert.ToString(read[item.Name]), out decimalValue))
									instanceEntity.GetType().GetProperty(item.Name).SetValue(instanceEntity, decimalValue);
								break;

							case "Int32":
							case "Int64":
								if(read[item.Name] != null && int.TryParse(Convert.ToString(read[item.Name]), out intValue))
									instanceEntity.GetType().GetProperty(item.Name).SetValue(instanceEntity, intValue);
								break;

							case "DateTime":
								if(read[item.Name] != null && DateTime.TryParse(Convert.ToString(read[item.Name]), out dateValue))
									instanceEntity.GetType().GetProperty(item.Name).SetValue(instanceEntity, dateValue);
								break;

							case "Boolean":
								if(read[item.Name] != null && int.TryParse(Convert.ToString(read[item.Name]), out intValue)) {
									bool boolValue = intValue == 1;
									instanceEntity.GetType().GetProperty(item.Name).SetValue(instanceEntity, boolValue);
								}
								break;
							}
						}

						listObject.Add(instanceEntity);
					}
					return listObject;
				}
			}
			//return null;
		}

		public static void Update(T Entity) {

			long idEntity = 0;

			using(var conection = BaseData.DbConnection()) {
				object instanceEntity = Activator.CreateInstance(Entity.GetType());
				StringBuilder sb = new StringBuilder();
				sb.Append($"UPDATE { Entity.GetType().Name } SET  ");
				var properties = Entity.GetType().GetProperties();
				object[] attributesObject;

				foreach(var item in properties) {
					attributesObject = item.GetCustomAttributes(false);
					if(attributesObject != null && attributesObject.Length > 0 && attributesObject.Any(x => x is NotMappedAttribute)) {
						continue;
					}

					switch(item.PropertyType.Name) {
					case "String":
						sb.Append($"{item.Name} = '{item.GetValue(Entity, null)?.ToString()?.Replace("'", "''")}',");
						break;

					case "Decimal":
						sb.Append($" {item.Name} = {item.GetValue(Entity, null)},");
						break;

					case "Int32":
					case "Int64":
						if(item.Name.ToUpper() != "ID")
							sb.Append($" {item.Name} = {item.GetValue(Entity, null)},");
						else {
							string value = item.GetValue(Entity, null).ToString();
							long.TryParse(value, out idEntity);
						}
						break;

					case "DateTime":
						if(!item.Name.Equals("CadasterDate"))
							sb.Append($" {item.Name} = '{((DateTime)item.GetValue(Entity, null)).ToString("yyyy-MM-dd HH:mm:ss")}',");
						break;

					case "Boolean":
						bool valueBool = (bool)item.GetValue(Entity, null);
						int intBoolValue = valueBool == true ? 1 : 0;

						sb.Append($" {item.Name} = {intBoolValue},");
						break;
					}
				}

				sb.Remove(sb.Length - 1, 1);

				using(var command = conection.CreateCommand()) {

					if(idEntity > 0) {
						sb.Append($" where id =  {idEntity}");

						command.CommandText = sb.ToString();
						command.ExecuteNonQuery();
					}
				}
			}
		}

		public static T GetEntity(int id) {
			var instanceEntity = Activator.CreateInstance<T>();
			var properties = instanceEntity.GetType().GetProperties();
			object[] attributesObject;

			using(var conection = BaseData.DbConnection()) {
				SQLiteCommand sQLiteCommand = new SQLiteCommand($"SELECT * FROM {instanceEntity.GetType().Name} ", conection);
				decimal decimalValue = 0;
				double doubleValue = 0;
				int intValue = 0;
				DateTime dateValue = DateTime.MinValue;
				using(var read = sQLiteCommand.ExecuteReader()) {
					while(read.Read()) {
						instanceEntity = Activator.CreateInstance<T>();

						foreach(var item in properties) {

							attributesObject = item.GetCustomAttributes(false);
							if(attributesObject != null && attributesObject.Length > 0 && attributesObject.Any(x => x is NotMappedAttribute)) {
								continue;
							}

							switch(item.PropertyType.Name) {
							case "String":
								instanceEntity.GetType().GetProperty(item.Name).SetValue(instanceEntity, Convert.ToString(read[item.Name]));
								break;

							case "Decimal":
								if(read[item.Name] != null && decimal.TryParse(Convert.ToString(read[item.Name]), out decimalValue))
									instanceEntity.GetType().GetProperty(item.Name).SetValue(instanceEntity, decimalValue);
								break;

							case "Double":
								if(read[item.Name] != null && double.TryParse(Convert.ToString(read[item.Name]), out doubleValue))
									instanceEntity.GetType().GetProperty(item.Name).SetValue(instanceEntity, doubleValue);
								break;

							case "Int32":
							case "Int64":
								if(read[item.Name] != null && int.TryParse(Convert.ToString(read[item.Name]), out intValue))
									instanceEntity.GetType().GetProperty(item.Name).SetValue(instanceEntity, intValue);
								break;

							case "DateTime":
								if(read[item.Name] != null && DateTime.TryParse(Convert.ToString(read[item.Name]), out dateValue))
									instanceEntity.GetType().GetProperty(item.Name).SetValue(instanceEntity, dateValue);
								break;
							}
						}
					}
					return instanceEntity;
				}
			}
			return null;
		}
	}
}
