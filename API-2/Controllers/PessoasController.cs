
using API_2.Models;
using API_2.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoasController : ControllerBase
    {
        private readonly IPessoasRepository repos;
        

        public PessoasController(IPessoasRepository  _repos)
        {
            repos = _repos;
        }



        [HttpGet("{Id}")]
        public IActionResult Get(int Id)
        {
            var pessoa_db = repos.Read(Id);
            return Ok(pessoa_db);
        }
       
        [HttpPost]
        public IActionResult Post(Pessoa pessoa)
        {
            if(repos.Create(pessoa))
                return Ok();
            
            return BadRequest();
        }
        [HttpPut]
        public IActionResult Put(Pessoa pessoa)
        {
            if (repos.Create(pessoa))
                return Ok();
            return BadRequest();
        }
       
        [HttpDelete("{Id}")]
        public IActionResult Delete(int Id)
        {
            if (repos.Delete(Id))
                return Ok();

            return BadRequest();
        }
    }
}
