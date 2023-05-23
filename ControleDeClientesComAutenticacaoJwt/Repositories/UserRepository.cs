using ControleDeClientes.Models;

namespace ControleDeClientes.Repositories
{
    public class UserRepository
    {
        public User Get(string username, string password)
        {
            var users = new List<User>
            {
                new() { Id = 1, Username = "batman", Password = "123456", Role = "manager"},
                new() { Id = 2, Username = "robin", Password = "123456", Role = "employee"}
            };

            return users.FirstOrDefault(x => x.Username == username && x.Password == password);
        }
    }
}
