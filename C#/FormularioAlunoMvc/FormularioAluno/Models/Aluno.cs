using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FormularioAluno.Models
{
    public class Aluno
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(30, MinimumLength = (2), ErrorMessage = "O Campo {0} precisa ter entre {1} e {2} caracteres")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [DataType(DataType.Date, ErrorMessage = "O campo {0} está em formato incorreto")]
        [Display(Name = "Data de nascimento")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(60, ErrorMessage = "O campo {0} precisa ter no máximo {1} caracteres")]
        [RegularExpression(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$", ErrorMessage = " O campo {0} está em formato inválido")]
        [Display(Name = "E-mail")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Display(Name = "Confirme o e-mail")]
        [Compare("Email", ErrorMessage = "Os e-mails informados não são identicos")]
        [NotMapped]
        public string? EmailConfirmacao { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Range(1,5, ErrorMessage = "O campo {0} deve estar entre {1} e {2}")]
        [Display(Name = "Avaliação")]
        public int Avaliacao {  get; set; }

        public bool Ativo {  get; set; }
    }
}
