using ControleDeClientes.Connection;
using ControleDeClientes.Models;
using Dapper;

namespace ControleDeClientes.Repositories
{
    public class ClienteRepository : MySqlDbConnection
    {
        public List<Cliente> List()
        {
            string sql = "SELECT * FROM CLIENTES";
            return Connection.Query<Cliente>(sql).ToList();
        }

        public dynamic cadastrar(Cliente obj)
        {
            string sqlInsert = $"INSERT INTO CLIENTES " +
                $"(NOME, EMAIL, CPF, NASCIMENTO) " +
                $"VALUES ('{obj.Nome}', '{obj.Email}', '{obj.Cpf}', '{obj.Nascimento}') ";

            string sqlSelect = "SELECT LAST_INSERT_ID();";
            Connection.Execute(sqlInsert);
            return Connection.Query<dynamic>(sqlSelect).First();

        }
    }
}
