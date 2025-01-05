using System.ComponentModel.DataAnnotations;

namespace ProductAPI.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = " O campo {0} � obrigat�rio")]        
        public string? Name { get; set; }
        [Required(ErrorMessage = " O campo {0} � obrigat�rio")]
        [Range(1, int.MaxValue, ErrorMessage = "O pre�o precisa ter o valor maior que 0")]
        public decimal Price { get; set; }
        [Required(ErrorMessage = " O campo {0} � obrigat�rio")]
        public int QuantityStock { get; set; }
        [Required(ErrorMessage = " O campo {0} � obrigat�rio")]
        public string? Description { get; set; }
    }
}
