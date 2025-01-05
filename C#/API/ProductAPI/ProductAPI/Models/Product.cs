using System.ComponentModel.DataAnnotations;

namespace ProductAPI.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = " O campo {0} é obrigatório")]        
        public string? Name { get; set; }
        [Required(ErrorMessage = " O campo {0} é obrigatório")]
        [Range(1, int.MaxValue, ErrorMessage = "O preço precisa ter o valor maior que 0")]
        public decimal Price { get; set; }
        [Required(ErrorMessage = " O campo {0} é obrigatório")]
        public int QuantityStock { get; set; }
        [Required(ErrorMessage = " O campo {0} é obrigatório")]
        public string? Description { get; set; }
    }
}
