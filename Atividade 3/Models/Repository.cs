using MySqlConnector;

namespace Atividade_3.Models
{
    public class Repository
    {
        protected const string _strConexao = "Database=quiquivet; Data Source = localhost; User id=root;";

        public MySqlConnection conexao = new MySqlConnection(_strConexao);
    }
}