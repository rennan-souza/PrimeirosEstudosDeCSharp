using ControleDeClientes.Models;
using ControleDeClientes.Repositories;

namespace ControleDeClientes.Services
{
    public class ClienteService
    {
        private readonly ClienteRepository clienteRepository;

        public ClienteService(ClienteRepository clienteRepository)
        {
            this.clienteRepository = clienteRepository;
        }

        public dynamic cadastrar(Cliente obj)
        {
            return clienteRepository.cadastrar(obj);
        }

        public List<Cliente> List()
        {
            return clienteRepository.List();
        }
    }
}
