
using API_2.Models;
using API_2.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContatoController : ControllerBase
    {
        private readonly IContatosRepository repos;
        public ContatoController(IContatosRepository _repos)
        {
            repos = _repos;
        }
        
        [HttpGet("{Id}")]
        public IActionResult Get(int Id)
        {
            var contato_db = repos.Read(Id);
            return Ok(contato_db);
        }
        [HttpPost]
        public IActionResult Post(Contato contato)
        {
            if(repos.Create(contato))
                return Ok();

            return BadRequest();    
        }
        [HttpPut]
        public IActionResult Put(Contato contato)
        {
            if (repos.Update(contato))
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
