using ControleDeClientes.Models;
using ControleDeClientes.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ControleDeClientes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly ClienteService clienteService;

        public ClienteController(ClienteService clienteService)
        {
            this.clienteService = clienteService;
        }

        [HttpGet]
        [Authorize(Roles = "manager,employee")]
        public ActionResult List()
        {
            try
            {
                var list = clienteService.List();
                return Ok(list);
            } catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Authorize(Roles = "manager")]
        public ActionResult Cadastrar([FromBody] Cliente obj)
        {
            try
            {
                var cliente = clienteService.cadastrar(obj);
                return Ok(cliente);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
