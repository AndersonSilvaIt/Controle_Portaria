using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entidades {

	public class RegistroEntradaSaida : BaseEntity {

		public int IdPessoa { get; set; }
		public int Tipo { get; set; } // 0 - Funcionario  |  1 - Visitante
		public DateTime DataSaida { get; set; }
		public DateTime DataEntrada { get; set; } = DateTime.MinValue;
		public string Veiculo { get; set; }

		public string PessoaNome { get; set; }
		public string PesoaCPF { get; set; }
	}
}
