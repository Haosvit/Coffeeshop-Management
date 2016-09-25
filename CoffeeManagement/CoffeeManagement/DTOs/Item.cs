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
        public Unit Unit { get; set; }
	    public int OriginalPrice { get; set; }
		public int SalingPrice { get; set; }
	    public bool IsDeleted { get; set; }
    }
}
