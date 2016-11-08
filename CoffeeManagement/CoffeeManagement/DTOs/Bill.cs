using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoffeeManagement.DTOs
{
    [Table("Bill")]
    public class Bill
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public DateTime CreatedDateTime { get; set; }
        public User CurrentUser { get; set; }
	    public virtual ICollection<Item> Items { get; set; }

		public virtual ICollection<Table> Tables { get; set; }

        public int PreTotal { get; set; }
        public bool IsClosed { get; set; }
        public float DiscountRate { get; set; }
        public int Total { get; set; }

		public Bill()
		{
			Items = new List<Item>();
			Tables = new List<Table>();
		}
    }
}
