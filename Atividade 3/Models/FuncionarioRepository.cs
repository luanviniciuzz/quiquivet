using System;
using System.Collections.Generic;
using System.IO;
using MySqlConnector;

namespace Atividade_3.Models
{
    public class FuncionarioRepository : Repository    {
        
        public void Inserir(Funcionario f)
        {
            
            conexao.Open();
            string sql = "insert into funcionario(nomeFuncionario, rgFuncionario, cpfFuncionario, login, senha) values(@nomeFuncionario, @rgFuncionario, @cpfFuncionario, @login, @senha);";
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@nomeFuncionario", f.nomeFuncionario);
            comando.Parameters.AddWithValue("@rgFuncionario", f.rgFuncionario);
            comando.Parameters.AddWithValue("@cpfFuncionario", f.cpfFuncionario);
            comando.Parameters.AddWithValue("@login", f.login);
            comando.Parameters.AddWithValue("@senha", f.senha);
            comando.ExecuteNonQuery();
            conexao.Close();
        }
        public void Alterar(Funcionario f)
        {
            conexao.Open();
            string sql = "update funcionario set nomeFuncionario=@nomeFuncionario, rgFuncionario=@rgFuncionario, cpfFuncionario=@cpfFuncionario, login=@login, senha=@senha where idFuncionario=@idFuncionario;";
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@nomeFuncionario", f.nomeFuncionario);
            comando.Parameters.AddWithValue("@rgFuncionario", f.rgFuncionario);
            comando.Parameters.AddWithValue("@cpfFuncionario", f.cpfFuncionario);
            comando.Parameters.AddWithValue("@login", f.login);
            comando.Parameters.AddWithValue("@senha", f.senha);
            comando.ExecuteNonQuery();
            conexao.Close();
        }
        public void Excluir(Funcionario f)
        {
            conexao.Open();
            string sql = "delete from funcionario where idFuncionario=@idFuncionario;";
            MySqlCommand comando = new MySqlCommand (sql, conexao);
            comando.Parameters.AddWithValue("@idFuncionario", f.idFuncionario);
            comando.ExecuteNonQuery();
            conexao.Close();
        }
        public List<Funcionario> Lista()
        {
            conexao.Open();
            string sql = "select * from funcionario;";
            MySqlCommand comando = new MySqlCommand (sql, conexao);
            MySqlDataReader reader = comando.ExecuteReader();
            List<Funcionario> lista = new List<Funcionario>();

            while(reader.Read())
            {
                Funcionario func = new Funcionario();
                func.idFuncionario = reader.GetInt32("idFuncionario");
                if(!reader.IsDBNull(reader.GetOrdinal("nomeFuncionario")))
                    func.nomeFuncionario=reader.GetString("nomeFuncionario");
                
                if(!reader.IsDBNull(reader.GetOrdinal("rgFuncionario")))
                    func.nomeFuncionario=reader.GetString("rgFuncionario");
                
                if(!reader.IsDBNull(reader.GetOrdinal("cpfFuncionario")))
                    func.nomeFuncionario=reader.GetString("cpfFuncionario");
                
                if(!reader.IsDBNull(reader.GetOrdinal("login")))
                    func.nomeFuncionario=reader.GetString("login");

                if(!reader.IsDBNull(reader.GetOrdinal("senha")))
                    func.nomeFuncionario=reader.GetString("senha");

                lista.Add(func);
            }
            conexao.Close();
            return lista;
        }
        public Funcionario Autentica(Funcionario f)
        {
            MySqlConnection conexao = new MySqlConnection(_strConexao);
            conexao.Open();
            string sql = "select * from funcionario where login=@login and senha=@senha;";
            MySqlCommand comandoAutentica = new MySqlCommand(sql, conexao);
            comandoAutentica.Parameters.AddWithValue("@login", f.login);
            comandoAutentica.Parameters.AddWithValue("@senha", f.senha);
            MySqlDataReader reader = comandoAutentica.ExecuteReader();
            Funcionario fun = null;
            if(reader.Read())
            {
                fun = new Funcionario();
                fun.idFuncionario = reader.GetInt32("idFuncionario");
                if(!reader.IsDBNull(reader.GetOrdinal("nomeFuncionario")))
                    fun.nomeFuncionario = reader.GetString("nomeFuncionario");
                
                if(!reader.IsDBNull(reader.GetOrdinal("login")))
                    fun.login = reader.GetString("login");
                if(!reader.IsDBNull(reader.GetOrdinal("senha")))
                    fun.senha = reader.GetString("senha");
            }
            conexao.Close();
            return fun;
        
        }
    }
}
