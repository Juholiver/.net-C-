using APISoft.Models;

namespace APISoft.Repositorios.Interfaces
{
    public interface IPessoaRepositorio
    {
        Task<List<PessoaModel>> BuscarTodasPessoas();
        Task<PessoaModel> BuscarPorId(int id);
        Task<PessoaModel> Adicionar(PessoaModel pessoa);
        Task<PessoaModel> Atualizar(PessoaModel pessoa, int id);
        Task<bool> Apagar(int id);
    }
}
