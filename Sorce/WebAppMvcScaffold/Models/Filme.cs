using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppMvcScaffold.Models
{
    public class Filme
    {
        [Key]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "O Título é obrigatório!")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "O Título deve ter entre 3 e 60 caracteres!")]
        [Display(Name = "Título")]
        public string Titulo { get; set; }
        
        [Required(ErrorMessage = "A Data é obrigatória!")]
        [DataType(DataType.DateTime, ErrorMessage = "Data em formato inválido!")]
        [Display(Name = "Data de Lançamento")]
        public DateTime DataLancamento { get; set; }

        [Required(ErrorMessage = "O Genero é obrigatório!")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00C0-\u00FF""'\w-]*$", ErrorMessage = "Gênero no formato invalido!")]
        [StringLength(30, ErrorMessage = "O Gênero só pode ter até 30 caracteres!")]
        [Display(Name = "Gênero")]
        public string Genero { get; set; }

        [Required(ErrorMessage = "O Valor é obrigatório!")]
        [Range(1, 1000, ErrorMessage = "O valor deve ser de 1 à 1000!")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "A Avaliação é obrigatória!")]
        [RegularExpression(@"^[0-5]*$", ErrorMessage = "Somente números de 0 à 5!")]
        [Display(Name = "Avaliação")]
        public int Avaliacao { get; set; }
    }
}
