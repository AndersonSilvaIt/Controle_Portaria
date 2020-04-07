using System;
using System.Data.Common;
using System.Data.SQLite;
using System.IO;
using System.Reflection;
using System.Text;
using System.Linq;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.RepositorioSQLite {
	public class BaseData {
		private static SQLiteConnection sqliteConnection;

		private static string strConection = System.Configuration.ConfigurationManager.
					ConnectionStrings["DBConnect"].ConnectionString;

		public BaseData() {
			CriarBanco();
		}

		DbProviderFactory provider = DbProviderFactories.GetFactory("System.Data.SQLite");

		private static void CriarBanco() {
			try {

				string pathRoot = @"C:\Testes";
				string pathDB = pathRoot + @"\DBControl.sqlite";
				if(!Directory.Exists(pathRoot))
					Directory.CreateDirectory(pathRoot);

				if(!File.Exists(pathDB)) {
					SQLiteConnection.CreateFile(pathDB);

					string caminhoCompleto = Directory.GetCurrentDirectory();
					string teste02 = caminhoCompleto.Remove(caminhoCompleto.Length - 20, 20);
					string teste03 = teste02 + @"Data\Entidades";
					string[] files01 = Directory.GetFiles(teste03);
					CriarTabelaSQlite(files01);
				}

				var teste = strConection;
			} catch(Exception ex) {

			}
		}

		public static SQLiteConnection DbConnection() {
			sqliteConnection = new SQLiteConnection(strConection);
			string pathRoot = @"C:\Testes";
			string pathDB = pathRoot + @"\DBControl.sqlite";
			if(!File.Exists(pathDB)) {
				CriarBanco();
			}
			if(sqliteConnection.State == System.Data.ConnectionState.Open)
				sqliteConnection.Close();

			sqliteConnection.Open();
			return sqliteConnection;
		}

		public static void CriarTabelaSQlite(string[] files) {
			try {
				Type EntityType = null;
				using(var cmd = DbConnection().CreateCommand()) {
					StringBuilder sb;
					foreach(var fileClass in files) {
						var index = fileClass.LastIndexOf("\\");
						var result = fileClass.Remove(0, index + 1);
						var rresult02 = result.Replace(".cs", "");

						EntityType = Type.GetType("Data.Entidades." + rresult02);
						object[] attributesObject = EntityType.GetCustomAttributes(false);
						if(attributesObject != null && attributesObject.Length > 0 && attributesObject.Any(x => x is NotMappedAttribute)) {
							continue;
						}

						sb = new StringBuilder();
						sb.Append($"CREATE TABLE IF NOT EXISTS { EntityType.Name } ( ");
						PropertyInfo[] propertyInfos = EntityType.GetProperties();

						foreach(var item in propertyInfos) {

							attributesObject = item.GetCustomAttributes(false);
							if(attributesObject != null && attributesObject.Length > 0 && attributesObject.Any(x => x is NotMappedAttribute)) {
								continue;
							}

							//Considering Nullable/Generics
							string propertyTypeName = item.PropertyType.Name;
							if(item.PropertyType.IsGenericType &&
								item.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>)) {
								propertyTypeName = item.PropertyType.GetGenericArguments()[0].Name;
							}

							switch(propertyTypeName) //item.PropertyType.Name
							{
							case "String":
								//TODO: Think how to get the string length dynamically
								//      Maybe DataAnnotations.StringLength
								//      And consider a default value = 50 (if there is no StringLength Data Annotations)
								sb.Append($"{item.Name} varchar(50),");
								break;

							case "Char":
								sb.Append($"{item.Name} char(1),");
								break;

							case "Decimal":
							case "Double":
								sb.Append($"{item.Name} numeric ,");
								break;

							case "Int32":
							case "Int64":
								if(item.Name.ToUpper() == "ID")
									sb.Append($"{item.Name} INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT ,");
								else
									sb.Append($"{item.Name} INTEGER ,");
								break;

							case "DateTime":
								sb.Append($"{item.Name} DateTime ,");
								break;

							//SQLite não suporta valor booleano
							case "Bool":
							case "Boolean":
								sb.Append($"{item.Name} INTEGER ,");
								break;

							case "Byte[]":
							case "byte[]":
								sb.Append($"{item.Name} BLOB ,"); //BLOB
								break;
							}

							
						}
						sb.Remove(sb.Length - 1, 1);
						sb.Append(" )");

						cmd.CommandText = sb.ToString();
						cmd.ExecuteNonQuery();
					}
				}
			} catch(Exception ex) {
				throw ex;
			}

		}

	}
}
