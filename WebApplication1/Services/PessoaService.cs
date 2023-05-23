using WebApplication1.Entities;

namespace WebApplication1.Services
{
    public class PessoaService
    {
        public List<Pessoa> Listar()
        {

            List<Pessoa> pessoas = new List<Pessoa>();

            Pessoa p1 = new Pessoa();
            p1.Nome = "João";
            p1.Idade = 29;
            pessoas.Add(p1);

            Pessoa p2 = new Pessoa();
            p2.Nome = "Maria";
            p2.Idade = 31;
            pessoas.Add(p2);

            return pessoas;
        }
    }
}
