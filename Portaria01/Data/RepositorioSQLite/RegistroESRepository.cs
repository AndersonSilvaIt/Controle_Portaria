using Data.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Data.RepositorioSQLite {
	public class RegistroESRepository : BaseRepository<RegistroEntradaSaida> {

		//public static IList<RegistroEntradaSaida> SearchUser(string nome, string veiculo, DateTime dtSaidaDe, DateTime dtSaidaAte, DateTime dtRetornoDe, DateTime dtRetornoAte) {
		//
		//	//List<FilterData> listFilterData = new List<FilterData>();
		//	//if(!string.IsNullOrWhiteSpace(login))
		//	//	listFilterData.Add(FilterData.Like("Login", login, LikeOperator.Both));
		//	//
		//	//if(!string.IsNullOrWhiteSpace(name))
		//	//	listFilterData.Add(FilterData.Like("FullName", name, LikeOperator.Both));
		//	//
		//	//if(active > 0)
		//	//	listFilterData.Add(FilterData.Eq("Active", (active == 1 ? 1 : 0)));
		//	//
		//	//if(listFilterData.Any()) {
		//	//	FilterCriteria fc = FilterCriteria.And(listFilterData.ToArray());
		//	//	return GetAll(fc, orderBy: "FullName");
		//	//} else
		//	//	return GetAll(orderBy: "FullName");
		//}
		//
	}
}
