using System;
using System.Linq;

namespace Data.RepositorioSQLite {
	public class FilterCriteria {
		private FilterCriteria() { }

		bool _isFilterData = false;
		private FilterData[] _listFilterData;
		private FilterCriteria[] _listFilterCriteria;
		private OperationType _operationType;

		public void Add(FilterData filterData) {
			if(filterData == null)
				return;

			if(!_isFilterData)
				throw new Exception("Only Filter Criteria can be added.");

			if(_listFilterData == null)
				_listFilterData = new FilterData[] { filterData };
			else
				_listFilterData = _listFilterData.Concat(new FilterData[] { filterData }).ToArray();
		}

		public void Add(FilterCriteria filterCriteria) {
			if(filterCriteria == null)
				return;

			if(_isFilterData)
				throw new Exception("Only Filter Data can be added.");

			if(_listFilterCriteria == null)
				_listFilterCriteria = new FilterCriteria[] { filterCriteria };
			else
				_listFilterCriteria = _listFilterCriteria.Concat(new FilterCriteria[] { filterCriteria }).ToArray();
		}

		private string GetOperationType() {
			switch(this._operationType) {
			case OperationType.And:
				return " AND ";
			case OperationType.Or:
				return " OR ";
			case OperationType.Not:
				return " NOT ";
			default:
				return string.Empty;
			}
		}

		public string ToString(object obj) {
			if(_isFilterData) {
				if(_listFilterData != null && _listFilterData.Length > 0) {
					string sqlInternal = " (";
					for(int pos = 0; pos < _listFilterData.Length; pos++) {
						sqlInternal += _listFilterData[pos].ToString(obj);

						if(pos != _listFilterData.Length - 1)
							sqlInternal += this.GetOperationType();
					}
					sqlInternal += ") ";

					return sqlInternal;
				}
			} else {
				if(_listFilterCriteria != null && _listFilterCriteria.Length > 0) {
					string sqlInternal = " (";
					for(int pos = 0; pos < _listFilterCriteria.Length; pos++) {
						sqlInternal += _listFilterCriteria[pos].ToString(obj);

						if(pos != _listFilterCriteria.Length - 1)
							sqlInternal += this.GetOperationType();
					}
					sqlInternal += ") ";

					return sqlInternal;
				}
			}

			return string.Empty;
		}

		private static FilterCriteria DefaultSet(OperationType operationType, params FilterData[] filterData) {
			if(filterData == null || filterData.Length == 0)
				throw new Exception("Filter Data can't be null.");

			FilterCriteria fc = new FilterCriteria();
			fc._isFilterData = true;
			fc._listFilterData = filterData;
			fc._operationType = operationType;

			return fc;
		}

		private static FilterCriteria DefaultSet(OperationType operationType, params FilterCriteria[] filterCriteria) {
			if(filterCriteria == null || filterCriteria.Length == 0)
				throw new Exception("Filter Criteria can't be null.");

			FilterCriteria fc = new FilterCriteria();
			fc._isFilterData = false;
			fc._listFilterCriteria = filterCriteria;
			fc._operationType = operationType;

			return fc;
		}

		#region FilterData

		public static FilterCriteria And(params FilterData[] filterData) {
			return DefaultSet(OperationType.And, filterData);
		}

		public static FilterCriteria Or(params FilterData[] filterData) {
			return DefaultSet(OperationType.Or, filterData);
		}

		public static FilterCriteria Not(params FilterData[] filterData) {
			return DefaultSet(OperationType.Not, filterData);
		}

		#endregion

		#region FilterCriteria

		public static FilterCriteria And(params FilterCriteria[] filterCriteria) {
			return DefaultSet(OperationType.And, filterCriteria);
		}

		public static FilterCriteria Or(params FilterCriteria[] filterCriteria) {
			return DefaultSet(OperationType.Or, filterCriteria);
		}

		public static FilterCriteria Not(params FilterCriteria[] filterCriteria) {
			return DefaultSet(OperationType.Not, filterCriteria);
		}

		#endregion
	}
}
