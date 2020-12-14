using System;

namespace Atividade_3.Models
{
    public class Consulta
    {
        public int idConsulta {get; set;}
        public string clienteConsulta {get; set;}
        public string detalhesConsulta {get; set;}
        public string medicoConsulta {get; set;}
        public int precoConsulta {get; set;}
        public DateTime dtConsulta {get; set;}
    }
}