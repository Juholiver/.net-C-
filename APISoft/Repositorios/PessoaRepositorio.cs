using APISoft.Data;
using APISoft.Models;
using APISoft.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace APISoft.Repositorios
{
    public class PessoaRepositorio : IPessoaRepositorio
    {
        private readonly ContatoDBContext _dbContext;
        public PessoaRepositorio(ContatoDBContext contatoDBContext)
        {
            _dbContext = contatoDBContext;
        }
        
        public async Task<PessoaModel> BuscarPorId(int id)
        {
            return await _dbContext.Pessoas.FirstOrDefaultAsync(x => x.Id == id);

        }

        public async Task<List<PessoaModel>> BuscarTodasPessoas()
        {
            return await _dbContext.Pessoas.ToListAsync();
        }
        public async Task<PessoaModel> Adicionar(PessoaModel pessoa)
        {
            await _dbContext.Pessoas.AddAsync(pessoa);
            _dbContext.SaveChanges();

            return pessoa;

        }

        public async Task<PessoaModel> Atualizar(PessoaModel pessoa, int id)
        {
            PessoaModel pessoaPorId = await BuscarPorId(id);
            if (pessoaPorId == null)
            {
                throw new Exception($"Pessoa para o ID: {id} não foi encontrado no banco de dados.");
            }
            pessoaPorId.CPF = pessoa.CPF;
            pessoaPorId.Nome = pessoa.Nome;
            pessoaPorId.Email = pessoa.Email;
            pessoaPorId.CEP = pessoa.CEP;

            _dbContext.Pessoas.Update(pessoaPorId);
            await _dbContext.SaveChangesAsync();

            return pessoaPorId;


        }

        public async Task<bool> Apagar(int id)
        {
            PessoaModel pessoaPorId = await BuscarPorId(id);
            if (pessoaPorId == null)
            {
                throw new Exception($"Pessoa para o ID: {id} não foi encontrado no banco de dados.");
            }

            _dbContext.Pessoas.Remove(pessoaPorId);
            await _dbContext.SaveChangesAsync();
            return true;

        }

        

        
    }

}
