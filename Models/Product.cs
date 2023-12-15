using System.ComponentModel.DataAnnotations;

namespace BlazorShop.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        
        [MinLength(3, ErrorMessage = "O título deve ter mais de 3 letras")]
        [MaxLength(120, ErrorMessage = "O título deve ter no máximo 120 letras")]
        public string Title { get; set; } = string.Empty;

        public string? Description { get; set; } = string.Empty;

        [Required(ErrorMessage = "O preço do produto deve ser informado!")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;
    }
}
