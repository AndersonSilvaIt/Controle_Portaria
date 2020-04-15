using System;
using System.IO;

namespace Data {
	public static class LogClass {

		public static void LogMessage(string message) {

			string CaminhoNome = "log-controles-ti.txt";

			String path = "C:\\LogsPortaria\\";

			if(!Directory.Exists(path))
				Directory.CreateDirectory(path);

			string arquivoLog = path + CaminhoNome;

			if(!File.Exists(arquivoLog))
				File.Create(arquivoLog).Close();

			File.AppendAllText(arquivoLog, $"Log:  {DateTime.Now}  -  { message } \n");
		}
	}
}
