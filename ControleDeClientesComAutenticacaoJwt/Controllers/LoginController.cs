using ControleDeClientes.Models;
using ControleDeClientes.Repositories;
using ControleDeClientes.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ControleDeClientes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {

        private readonly UserRepository _userRepository;
        private readonly TokenService _tokenService;

        public LoginController(UserRepository userRepository, TokenService tokenService)
        {
            _userRepository = userRepository;
            _tokenService = tokenService;
        }

        [HttpPost]
        public async Task<dynamic> Authenticate([FromBody] User model)
        {
            var user = _userRepository.Get(model.Username, model.Password);
            if (user == null)
            {
                return NotFound(new { message = "Usuário ou senha inválidos" });
            }

            var token = _tokenService.GenerateToken(user);

            user.Password = "";
            return new
            {
                user = user,
                token = token
            };
        }
    }
}
