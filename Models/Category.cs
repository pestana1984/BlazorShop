using System.ComponentModel.DataAnnotations;

namespace BlazorShop.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o título da categoria!")]
        [MinLength(3, ErrorMessage = "O título deve ter mais de 3 letras")]
        [MaxLength(60, ErrorMessage = "O título deve ter no máximo 60 letras")]
        public string Title { get; set; } = string.Empty;
    }
}
