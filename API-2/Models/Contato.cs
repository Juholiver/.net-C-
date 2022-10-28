using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_2.Models
{
    public class Contato
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(120)]
        public string? Nome { get; set; }
        [Required]
        public int Telefone { get; set; }
        //[ForeignKey("Pessoa")]
        //[Column("Pessoa")]
        public int? PessoaId { get; set; }

    }
}
