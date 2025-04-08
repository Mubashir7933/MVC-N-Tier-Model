using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyWebApp.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        
        [Required]
        [DisplayName("Category Name")]
        [MaxLength(20)]
        public string Name { get; set; } = string.Empty;
        
        [DisplayName("Category Order")]
        [Range(1,20)]
        public int DisplayOrder { get; set; }
    }
}