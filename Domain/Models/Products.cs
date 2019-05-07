using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public partial class Products
    {
        public int Id { get; set; }

        [Required]
        [StringLength(40, MinimumLength = 3)]
        public string Name { get; set; }

        [Required]
        [Range(0, 200)]
        public int Quantity { get; set; }

        [Required]
        public int CategoryId { get; set; }

        public virtual Categories Category { get; set; }
    }
}