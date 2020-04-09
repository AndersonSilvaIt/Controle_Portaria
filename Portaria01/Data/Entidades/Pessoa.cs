
namespace Data.Entidades {

	public class Pessoa : BaseEntity {

		public byte[] Imagem { get; set; }
		public string Nome { get; set; }
		public string CPF { get; set; }
		public string FoneComercial { get; set; }
		public string FoneCelular { get; set; }
		public string Email { get; set; }

		public string Rua { get; set; }
		public string Numero { get; set; }
		public string Bairro { get; set; }
		public string Cidade { get; set; }
		public string CEP { get; set; }
		public string UF { get; set; }
		public string Tipo { get; set; }

	}
}
