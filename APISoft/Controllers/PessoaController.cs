using APISoft.Models;
using APISoft.Repositorios.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace APISoft.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]

    public class PessoaController : ControllerBase
    {
        private readonly IPessoaRepositorio __pessoaRepositorio;
        public PessoaController(IPessoaRepositorio pessoaRepositorio)
        {
            __pessoaRepositorio = pessoaRepositorio;
        }
        [HttpGet]
        public async Task<ActionResult<List<PessoaModel>>> BuscarTodasPessoas()
        {
            List<PessoaModel> pessoas = await __pessoaRepositorio.BuscarTodasPessoas();
            return Ok(pessoas);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PessoaModel>> BuscarPorId(int id)
        {
            PessoaModel pessoa = await __pessoaRepositorio.BuscarPorId(id);
            return Ok(pessoa);
        }

        [HttpPost]
        public async Task<ActionResult<PessoaModel>> Cadastrar([FromBody] PessoaModel pessoaModel)
        {
            PessoaModel pessoa = await __pessoaRepositorio.Adicionar(pessoaModel);
            return Ok(pessoa);
        }
    }
}
