using System;
using System.Collections.Generic;
using System.IO;
using MySqlConnector;

namespace Atividade_3.Models
{
    public class ConsultaRepository : Repository
    {
        public void Inserir(Consulta c)
        {
            
            conexao.Open();
            string sql = "insert into consulta(clienteConsulta, detalhesConsulta, medicoConsulta, precoConsulta, dtConsulta) values(@clienteConsulta, @detalhesConsulta, @medicoConsulta, @precoConsulta, @dtConsulta);";
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@clienteConsulta", c.clienteConsulta);
            comando.Parameters.AddWithValue("@detalhesConsulta", c.detalhesConsulta);
            comando.Parameters.AddWithValue("@medicoConsulta", c.medicoConsulta);
            comando.Parameters.AddWithValue("@precoConsulta", c.precoConsulta);
            comando.Parameters.AddWithValue("@dtConsulta", c.dtConsulta);
            comando.ExecuteNonQuery();
            conexao.Close();
        }
        public void Alterar(Consulta c)
        {
            conexao.Open();
            string sql = "update consulta set clienteConsulta=@clienteConsulta, detalhesConsulta=@detalhesConsulta, medicoConsulta=@medicoConsulta, precoConsulta=@precoConsulta, dtConsulta=@dtConsulta where idConsulta=@idConsulta;";
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@idConsulta", c.idConsulta);
            comando.Parameters.AddWithValue("@clienteConsulta", c.clienteConsulta);
            comando.Parameters.AddWithValue("@detalhesConsulta", c.detalhesConsulta);
            comando.Parameters.AddWithValue("@medicoConsulta", c.medicoConsulta);
            comando.Parameters.AddWithValue("@precoConsulta", c.precoConsulta);
            comando.Parameters.AddWithValue("@dtConsulta", c.dtConsulta);
            comando.ExecuteNonQuery();
            conexao.Close();
        }
        public int Excluir(int idConsulta)
        {
            conexao.Open();
            string sql = "delete from consulta where idConsulta=@idConsulta;";
            MySqlCommand comando = new MySqlCommand (sql, conexao);
            comando.Parameters.AddWithValue("@idConsulta", idConsulta);
            int val = comando.ExecuteNonQuery();
            conexao.Close();
            return val;
        }
        public List<Consulta> Lista()
        {
            conexao.Open();
            string sql = "select * from consulta;";
            MySqlCommand comando = new MySqlCommand (sql, conexao);
            MySqlDataReader reader = comando.ExecuteReader();
            List<Consulta> listadeconsulta = new List<Consulta>();

            while(reader.Read())
            {
                Consulta cons = new Consulta();
                cons.idConsulta = reader.GetInt32("idConsulta");
                if(!reader.IsDBNull(reader.GetOrdinal("clienteConsulta")))
                    cons.clienteConsulta=reader.GetString("clienteConsulta");             
                                
                if(!reader.IsDBNull(reader.GetOrdinal("detalhesConsulta")))
                    cons.detalhesConsulta=reader.GetString("detalhesConsulta");
                
                if(!reader.IsDBNull(reader.GetOrdinal("medicoConsulta")))
                   cons.medicoConsulta=reader.GetString("medicoConsulta");

                if(!reader.IsDBNull(reader.GetOrdinal("precoConsulta")))
                    cons.precoConsulta=reader.GetInt32("precoConsulta");
                
                if(!reader.IsDBNull(reader.GetOrdinal("dtConsulta")))
                    cons.dtConsulta=reader.GetDateTime("dtConsulta");

                listadeconsulta.Add(cons);
            }
            conexao.Close();
            return listadeconsulta;
        }       
    
    }
}