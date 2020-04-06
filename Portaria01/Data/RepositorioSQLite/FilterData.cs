using System;
using System.Linq;
using System.Reflection;

namespace Data.RepositorioSQLite {
	public class FilterData {
		private FilterData() {
			_filterType = FilterType.Unspecified;
			_likeOperator = LikeOperator.None;
		}

		private FilterType _filterType;
		private string _propertyName;
		private object _obj1;
		private object _obj2;
		private LikeOperator _likeOperator;

		private static FilterData DefaultSet(string propertyName, object value, FilterType filterType) {
			if(value == null)
				throw new Exception("Value can't be null.");

			FilterData fd = new FilterData();
			fd._propertyName = propertyName;
			fd._filterType = filterType;
			fd._obj1 = value;

			return fd;
		}

		public static FilterData Eq(string propertyName, object value) {
			return DefaultSet(propertyName, value, FilterType.Eq);
		}

		public static FilterData Ge(string propertyName, object value) {
			return DefaultSet(propertyName, value, FilterType.Ge);
		}

		public static FilterData Gt(string propertyName, object value) {
			return DefaultSet(propertyName, value, FilterType.Gt);
		}

		public static FilterData Le(string propertyName, object value) {
			return DefaultSet(propertyName, value, FilterType.Le);
		}

		public static FilterData Lt(string propertyName, object value) {
			return DefaultSet(propertyName, value, FilterType.Lt);
		}

		public static FilterData Like(string propertyName, object value, LikeOperator likeOperator = LikeOperator.None) {
			FilterData fd = DefaultSet(propertyName, value, FilterType.Like);
			fd._likeOperator = likeOperator;
			return fd;
		}

		public static FilterData In(string propertyName, object[] value) {
			return DefaultSet(propertyName, value, FilterType.In);
		}

		public static FilterData Between(string propertyName, object value1, object value2) {
			if(value1 == null || value2 == null)
				throw new Exception("Value can't be null.");

			FilterData fd = new FilterData();
			fd._filterType = FilterType.Between;
			fd._obj1 = value1;
			fd._obj2 = value2;

			return fd;
		}

		public static FilterData IsNull(string propertyName) {
			FilterData fd = new FilterData();
			fd._propertyName = propertyName;
			fd._filterType = FilterType.IsNull;

			return fd;
		}

		public static FilterData IsNotNull(string propertyName) {
			FilterData fd = new FilterData();
			fd._propertyName = propertyName;
			fd._filterType = FilterType.IsNotNull;

			return fd;
		}

		public string ToString(object obj) {
			var properties = obj.GetType().GetProperties();

			PropertyInfo pi = properties.FirstOrDefault(p => p.Name.Equals(_propertyName));

			if(pi != null) {
				string resultSql = this.GetFormattedSql(pi);
				return resultSql; //Result
			} else
				return (" (1 = 1) ");
		}

		private string GetFormattedSql(PropertyInfo pi) {
			switch(this._filterType) {
			case FilterType.Unspecified:
				return " (1 = 1) ";
			//[Property] [Operator] [Object Value]
			case FilterType.Eq:
			case FilterType.Ge:
			case FilterType.Gt:
			case FilterType.Le:
			case FilterType.Lt:
				return String.Format(" ( {0} {1} {2} ) ", pi.Name, this.GetOperator(), this.GetValue(this._obj1));
			//[Property] [Operator] [Object Value]
			case FilterType.Like:
				return String.Format(" ( {0} {1} {2} ) ", pi.Name, this.GetOperator(), this.GetValue(this._obj1));
			//[Property] [IS / IS NOT] [NULL]
			case FilterType.IsNull:
			case FilterType.IsNotNull:
				return String.Format(" ( {0} {1} ) ", pi.Name, this.GetOperator());
			//[Property] [IN] [List(Object Value)]
			case FilterType.In:
				string valueIn = string.Empty;
				if(this._obj1 != null) {
					foreach(var item in ((object[])this._obj1)) {
						valueIn = String.Concat(valueIn, this.GetValue(item), ",");
					}

					if(!string.IsNullOrWhiteSpace(valueIn))
						valueIn = valueIn.Remove(valueIn.Length - 1);
					else
						valueIn = "NULL";
				} else
					valueIn = "NULL";
				return String.Format(" ( {0} {1} ( {2} ) ) ", pi.Name, this.GetOperator(), valueIn);
			//[Property] [BETWEEN] [Object1 Value] [AND] [Object2 Value]
			case FilterType.Between:
				return String.Format(" ( {0} {1} {2} AND {3} ) ", pi.Name, this.GetOperator(),
									 this.GetValue(this._obj1), this.GetValue(this._obj2));
			default:
				return " (1 = 1) ";
			}
		}

		public string GetValue(object obj) {
			if(obj == null)
				return "NULL";

			switch(obj.GetType().Name) {
			case "String":
				if(this._filterType == FilterType.Like && this._likeOperator != LikeOperator.None)
					return String.Concat("'", ((this._likeOperator == LikeOperator.Prefix ||
												this._likeOperator == LikeOperator.Both) ? "%" : ""),
											  ((string)obj).Replace("'", "''"),
											  ((this._likeOperator == LikeOperator.Suffix ||
												this._likeOperator == LikeOperator.Both) ? "%" : ""),
											  "'");
				else
					return String.Concat("'", ((string)obj).Replace("'", "''"), "'");
			case "Decimal":
				return ((decimal)obj).ToString("0.00");
			case "Int32":
				return ((int)obj).ToString();
			case "DateTime":
				return String.Concat("'", ((DateTime)obj).ToString("yyyy-MM-dd HH:mm:ss"), "'");
			case "Boolean":
				return (((bool)obj) ? "1" : "0");
			default:
				return "NULL";
			}
		}

		public string GetOperator() {
			switch(this._filterType) {
			case FilterType.Unspecified:
				return string.Empty;
			case FilterType.Eq:
				return "=";
			case FilterType.Ge:
				return ">=";
			case FilterType.Gt:
				return ">";
			case FilterType.Le:
				return "<=";
			case FilterType.Lt:
				return "<";
			case FilterType.Like:
				return "LIKE";
			case FilterType.In:
				return "IN";
			case FilterType.Between:
				return "BETWEEN";
			case FilterType.IsNull:
				return "IS NULL";
			case FilterType.IsNotNull:
				return "IS NOT NULL";
			default:
				return string.Empty;
			}
		}
	}
}
