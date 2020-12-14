using System;
using System.Collections.Generic;
using System.IO;
using MySqlConnector;

namespace Atividade_3.Models
{
    public class ClienteRepository : Repository
    {
        public void Inserir(Cliente c)
        {
            
            conexao.Open();
            string sql = "insert into cliente(nomeCliente, dtNascimentoCliente, cpfCliente, rgCliente, telefoneCliente, emailCliente) values(@nomeCliente, @dtNascimentoCliente, @cpfCliente, @rgCliente, @telefoneCliente, @emailCliente);";
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@nomeCliente", c.nomeCliente);
            comando.Parameters.AddWithValue("@dtNascimentoCliente", c.dtNascimentoCliente);
            comando.Parameters.AddWithValue("@cpfCliente", c.cpfCliente);
            comando.Parameters.AddWithValue("@rgCliente", c.rgCliente);
            comando.Parameters.AddWithValue("@telefoneCliente", c.telefoneCliente);
            comando.Parameters.AddWithValue("@emailCliente", c.emailCliente);
            comando.ExecuteNonQuery();
            conexao.Close();
        }
        public void Alterar(Cliente c)
        {
            conexao.Open();
            string sql = "update cliente set nomeCliente=@nomeCliente, dtNascimentoCliente=@dtNascimentoCliente, cpfCliente=@cpfCliente, rgCliente=@rgCliente, telefoneCliente=@telefoneCliente, emailCliente=@emailCliente where idCliente=@idCliente;";
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@idCliente", c.idCliente);
            comando.Parameters.AddWithValue("@nomeCliente", c.nomeCliente);
            comando.Parameters.AddWithValue("@dtNascimentoCliente", c.dtNascimentoCliente);
            comando.Parameters.AddWithValue("@cpfCliente", c.cpfCliente);
            comando.Parameters.AddWithValue("@rgCliente", c.rgCliente);
            comando.Parameters.AddWithValue("@telefoneCliente", c.telefoneCliente);
            comando.Parameters.AddWithValue("@emailCliente", c.emailCliente);
            comando.ExecuteNonQuery();
            conexao.Close();
        }
        public int Excluir(int idCliente)
        {
            conexao.Open();
            string sql = "delete from cliente where idCliente=@idCliente;";
            MySqlCommand comando = new MySqlCommand (sql, conexao);
            comando.Parameters.AddWithValue("@idCliente", idCliente);
            int val = comando.ExecuteNonQuery();
            conexao.Close();
            return val;
        }
        public List<Cliente> Lista()
        {
            conexao.Open();
            string sql = "select * from cliente;";
            MySqlCommand comando = new MySqlCommand (sql, conexao);
            MySqlDataReader reader = comando.ExecuteReader();
            List<Cliente> lista = new List<Cliente>();

            while(reader.Read())
            {
                Cliente cli = new Cliente();
                cli.idCliente = reader.GetInt32("idCliente");
                if(!reader.IsDBNull(reader.GetOrdinal("nomeCliente")))
                    cli.nomeCliente=reader.GetString("nomeCliente");
                
                if(!reader.IsDBNull(reader.GetOrdinal("dtNascimentoCliente")))
                    cli.dtNascimentoCliente=reader.GetDateTime("dtNascimentoCliente");
                
                if(!reader.IsDBNull(reader.GetOrdinal("cpfCliente")))
                    cli.cpfCliente=reader.GetString("cpfCliente");
                
                if(!reader.IsDBNull(reader.GetOrdinal("rgCliente")))
                    cli.rgCliente=reader.GetString("rgCliente");

                if(!reader.IsDBNull(reader.GetOrdinal("telefoneCliente")))
                    cli.telefoneCliente=reader.GetString("telefoneCliente");
                
                if(!reader.IsDBNull(reader.GetOrdinal("emailCliente")))
                    cli.emailCliente=reader.GetString("emailCliente");

                lista.Add(cli);
            }
            conexao.Close();
            return lista;
        }       
    
    }
}