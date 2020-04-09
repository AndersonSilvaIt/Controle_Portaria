using Data.Entidades;
using System.Collections.Generic;
using System.Linq;

namespace Data.RepositorioSQLite {
	public class PessoaRepository : BaseRepository<Pessoa> {

		public static IList<Pessoa> SearchPessoa(string nome, string cpf, string cidade, string cep, string tipo, string uf) {
			List<FilterData> listFilterData = new List<FilterData>();

			if(!string.IsNullOrWhiteSpace(nome))
				listFilterData.Add(FilterData.Like("Nome", nome, LikeOperator.Both));

			if(!string.IsNullOrWhiteSpace(cpf))
				listFilterData.Add(FilterData.Like("CPF", cpf, LikeOperator.Both));

			if(!string.IsNullOrWhiteSpace(tipo))
				listFilterData.Add(FilterData.Eq("Tipo", tipo));

			if(!string.IsNullOrWhiteSpace(uf))
				listFilterData.Add(FilterData.Eq("UF", uf));

			if(listFilterData.Any()) {
				FilterCriteria fc = FilterCriteria.And(listFilterData.ToArray());
				return GetAll(fc, orderBy: "Nome ");
			} else
				return GetAll(orderBy: "Nome ");
		}

	}
}
