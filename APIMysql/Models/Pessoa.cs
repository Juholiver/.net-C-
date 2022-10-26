using System.ComponentModel.DataAnnotations;

namespace APIMysql.Models
{
    public class Pessoa
    {
        [Key]

        public int Id { get; set; }
        [StringLength(9, MinimumLength = 9, ErrorMessage = "O campo CPF tem que ter 9 caracteres")]
        public string CPF { get; set; }
        
        [StringLength(200, MinimumLength = 3, ErrorMessage = "O campo Nome deve ter entre 3 a 200 caracteres")]
        public string Nome { get; set; }
        [StringLength(150, MinimumLength = 3, ErrorMessage = "O campo Email nao pode ser vazio")]
        public string Email { get; set; }   
    }
}
