using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GerarContaBancariaController : ControllerBase
    {
        [HttpGet]
        public ActionResult GerarContaBancaria()
        {
            List<dynamic> list = new List<dynamic>();

            for (int i = 0; i< 2; i++)
            {
                List<dynamic> listaContaBancaria = new List<dynamic>
                {
                    new
                    {
                        ContaCorrente = "44361-6",
                        Agencia = "5940",
                        Banco = "Itaú",
                        Cidade = "Assis",
                        Estado= "SP"
                    },
                    new
                    {
                        ContaCorrente = "235874-3",
                        Agencia = "5945",
                        Banco = "Banco do Brasil",
                        Cidade = "Sao Vicente",
                        Estado = "SP"
                    },
                    new
                    {
                        ContaCorrente = "6454768135-0",
                        Agencia = "0083",
                        Banco = "Citibank",
                        Cidade = "Jundiai",
                        Estado = "SP"
                    },
                };

                Random random = new Random();
                int index = random.Next(listaContaBancaria.Count);
                dynamic contaBancaria = listaContaBancaria[index];
                list.Add(contaBancaria);
            }

            return Ok(list);
        }

    }
}