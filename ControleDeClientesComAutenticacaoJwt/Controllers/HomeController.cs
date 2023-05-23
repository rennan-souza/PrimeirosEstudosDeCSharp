using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ControleDeClientes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        [Route("anonymous")]
        [AllowAnonymous]
        public dynamic Anonnymous()
        {
            return Ok(new { message = "Rota livre para acessar sem autenticação" });
        }

        [HttpGet]
        [Route("authenticated")]
        [Authorize]
        public dynamic Authenticated()
        {
            return Ok(new { message = "Usuário autenticado: " + User.Identity.Name });
        }

        [HttpGet]
        [Route("employee")]
        [Authorize(Roles = "employee, manager")]
        public dynamic Employee()
        {
            return Ok(new { message = "Usuário que possuí o perfil employee"});
        }

        [HttpGet]
        [Route("manager")]
        [Authorize(Roles = "manager")]
        public dynamic Manager()
        {
            return Ok(new { message = "Usuário que possuí o perfil manager" });
        }
    }
}
