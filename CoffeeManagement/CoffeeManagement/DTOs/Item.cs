using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoffeeManagement.DTOs
{
    [Table("Item")]
    public class Item
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Name { get; set; }
	    public int OriginalPrice { get; set; }
		public int SalingPrice { get; set; }
	    public bool IsDeleted { get; set; }
		public int UnitId { get; set; }
		[ForeignKey("UnitId")]
		public virtual Unit Unit { get; set; }
		public virtual ICollection<Bill> Bills { get; set; }
    }
}
