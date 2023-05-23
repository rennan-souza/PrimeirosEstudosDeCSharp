using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ControleDeClientes.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public DateTime Nascimento { get; set; }
    }
}
