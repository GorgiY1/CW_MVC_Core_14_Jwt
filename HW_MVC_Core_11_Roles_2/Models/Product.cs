using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Shop_app.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(ErrorMessage = "Id is required")]
        public Guid Id { get; set; } = Guid.NewGuid(); // Задаем `Guid` для `Id`

        [Required(ErrorMessage = "Name is required")]
        [StringLength(100, MinimumLength = 2 , ErrorMessage = "min: 2 max: 100")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Price is required")]
        [Column(TypeName = "decimal(18,2)")]
        [Range(0.01,1000000.00, ErrorMessage = "min: 0.01 max: 1000000.00")]
        public decimal Price { get; set; } = decimal.Zero;

        [Required(ErrorMessage = "Description is required")]
        [StringLength(1024, MinimumLength = 2, ErrorMessage = "min: 2 max: 1024")]
        public string Description { get; set; } = string.Empty;
    }
}
