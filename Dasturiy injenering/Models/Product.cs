using System.ComponentModel.DataAnnotations;

namespace Dasturiy_injenering.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [StringLength(100, MinimumLength = 3)]
        public string Name { get; set; }
        public decimal Price { get; set; }
        [StringLength(255)]
        public string Image { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}