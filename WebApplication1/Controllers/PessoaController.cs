using Microsoft.AspNetCore.Mvc;
using WebApplication1.Entities;
using WebApplication1.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        private readonly PessoaService pessoaService;

        public PessoaController(PessoaService pessoaService) 
        {
            this.pessoaService = pessoaService;
        }

        // GET: api/<PessoaController>
        [HttpGet]
        public ActionResult List()
        {
            try
            {
                List<Pessoa> list = pessoaService.Listar();
                return Ok(list);
            } catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /*
        // GET api/<PessoaController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PessoaController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PessoaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PessoaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        */
    }
}
