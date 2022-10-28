using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_2.Models
{
    public class Pessoa
    {
        [Key]
        public int Id { get; set; }
        public string? Nome { get; set; }
        public int CPF { get; set; }
        public string? Email { get; set; }
        
    }
}
