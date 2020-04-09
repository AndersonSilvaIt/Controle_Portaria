using Data.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Data.RepositorioSQLite {
	public class RegistroESRepository : BaseRepository<RegistroEntradaSaida> {

		public static IList<RegistroEntradaSaida> SearchRegistro(string nome, string veiculo, DateTime dtSaidaDe, DateTime dtSaidaAte, DateTime dtRetornoDe, DateTime dtRetornoAte, int tipo, string cpf) {
		
			List<FilterData> listFilterData = new List<FilterData>();

			if(!string.IsNullOrWhiteSpace(nome))
				listFilterData.Add(FilterData.Like("PessoaNome", nome, LikeOperator.Both));
			
			if(!string.IsNullOrWhiteSpace(veiculo))
				listFilterData.Add(FilterData.Like("Veiculo", veiculo, LikeOperator.Both));
			
			if(dtSaidaDe > DateTime.MinValue) 
				listFilterData.Add(FilterData.Ge("DataSaida", dtSaidaDe));
			
			if(dtSaidaAte > DateTime.MinValue)
				listFilterData.Add(FilterData.Lt("DataSaida", dtSaidaAte));

			//Filtro data Retorno
			if(dtRetornoDe > DateTime.MinValue)
				listFilterData.Add(FilterData.Ge("DataEntrada", dtRetornoDe));

			if(dtRetornoAte > DateTime.MinValue)
				listFilterData.Add(FilterData.Lt("DataEntrada", dtRetornoAte));

			if(!string.IsNullOrWhiteSpace(cpf))
				listFilterData.Add(FilterData.Like("PesoaCPF", cpf, LikeOperator.Both));

			listFilterData.Add(FilterData.Eq("Tipo", tipo));

			if(listFilterData.Any()) {
				FilterCriteria fc = FilterCriteria.And(listFilterData.ToArray());
				return GetAll(fc, orderBy: "DataSaida");
			} else
				return GetAll(orderBy: "DataSaida");
		}
		
	}
}
