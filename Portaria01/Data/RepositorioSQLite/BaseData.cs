using System;
using System.Data.Common;
using System.Data.SQLite;
using System.IO;
using System.Reflection;
using System.Text;
using System.Linq;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Data.RepositorioSQLite {
	public class BaseData {
		private static SQLiteConnection sqliteConnection;

		private static List<string> ListaTabelas = new List<string>() {
			"Pessoa",
			"RegistroEntradaSaida"
		};

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
				if(!Directory.Exists(pathRoot)) {
					LogClass.LogMessage(@"BaseData 1 - Criando C:\Testes - Method: CriarBanco");
					Directory.CreateDirectory(pathRoot);
				}

				if(!File.Exists(pathDB)) {
					LogClass.LogMessage(@"BaseData 2  - Criando: \DBControl.sqlite - Method: CriarBanco");
					SQLiteConnection.CreateFile(pathDB);

					
					//string caminhoCompleto = Directory.GetCurrentDirectory();
					//
					//LogClass.LogMessage($@"BaseData 3 - Inicio criar tabelas: {caminhoCompleto}   - Method: CriarBanco");
					//
					//string teste02 = caminhoCompleto.Remove(caminhoCompleto.Length - 20, 20);
					//LogClass.LogMessage($@"BaseData 4 - Inicio criar tabelas: {teste02}   - Method: CriarBanco");
					//
					//string teste03 = teste02 + @"Data\Entidades";
					//LogClass.LogMessage($@"BaseData 5 - Inicio criar tabelas: {teste03}   - Method: CriarBanco");
					//
					//string[] files01 = Directory.GetFiles(teste03);
					LogClass.LogMessage($@"BaseData 2 - Inicio criar tabelas Arquivos obtidos: {ListaTabelas.Count}   - Method: CriarBanco");

					CriarTabelaSQlite(ListaTabelas.ToArray());
					LogClass.LogMessage($@"BaseData 3 - Tabelas criadas com sucesso: - Method: CriarBanco");
				}

				var teste = strConection;
			} catch(Exception ex) {

				LogClass.LogMessage($@"Erro : BaseData - Criação banco de dados - Tabelas : {ex.Message}   - Method: CriarBanco");

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

						EntityType = Type.GetType("Data.Entidades." + fileClass);
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
