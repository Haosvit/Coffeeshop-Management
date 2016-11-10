using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace CoffeeManagement.DTOs
{
	[DataContract]
	[Table("Table")]
	public class Table
	{
		[DataMember]
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
		[DataMember]
		public string Name { get; set; }
		public bool IsAvailable { get; set; }

		public virtual ICollection<Bill> Bills { get; set; }
	}
}
