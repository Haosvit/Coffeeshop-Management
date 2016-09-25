using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CoffeeManagement.Utilities;

namespace CoffeeManagement.DTOs
{
    [Table("User")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public AppEnum.UserLevel Level { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; }
    }
}
