namespace APISoft.Models
{
    public class PessoaModel
    {
        public int Id { get; set; }
        public int CPF { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public int CEP { get; set; }
    }
}
