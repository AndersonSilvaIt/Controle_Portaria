using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entidades {

	[NotMapped]
	public abstract class BaseEntity {
		public long Id { get; set; }
		public DateTime CadasterDate { get; set; } = DateTime.Now;
	}
}
