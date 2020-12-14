using System.Collections.Generic;
using Atividade_3.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace Atividade_3.Controllers
{
    public class ConsultorioController : Controller
    {
        public IActionResult CadastroCliente()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CadastroCliente(Cliente c)
        {
            ClienteRepository clie = new  ClienteRepository();
            clie.Inserir(c);
            ViewBag.Mensagem = "Cliente REGISTRADO com sucesso";
            return View();
        }       
        public IActionResult ListaCliente()
        {
            ClienteRepository clie = new  ClienteRepository();            
            List<Cliente> listadecliente = clie.Lista();
            return View(listadecliente);
        }
        [HttpGet]
        public IActionResult ExcluirCliente(int idCliente)
        {
            var exccli = new ClienteRepository().Excluir(idCliente);
            ViewBag.Mensagem = "Cliente excluido";
            return RedirectToAction("ListaCliente");
        }
        public IActionResult EditarCliente(int idCliente)
        {
            ClienteRepository cliente = new ClienteRepository();
            List<Cliente> listadecliente = cliente.Lista();
            var result = listadecliente.Find(c=>c.idCliente == idCliente);
            return View(result);
        }
        [HttpPost]
        public IActionResult EditarCliente(Cliente c)
        {
            ClienteRepository cliente = new ClienteRepository();
            cliente.Alterar(c);

            return RedirectToAction("ListaCliente");
        }
        public IActionResult DetalhesCliente(int idCliente)
        {        
            ClienteRepository cliente = new ClienteRepository();
            List<Cliente> listadecliente = cliente.Lista();
            var result = listadecliente.Find(c=>c.idCliente == idCliente);   
            return View(result); 
        }
        ///////////////////////////////////////////////////////////////////////////////////////
        public IActionResult MarcarConsulta()
        {
            return View();
        }
        [HttpPost]
        public IActionResult MarcarConsulta(Consulta c)
        {
            ConsultaRepository consu = new  ConsultaRepository();
            consu.Inserir(c);
            ViewBag.Mensagem = "Consulta MARCADA com sucesso";
            return View();
        }       
        public IActionResult ConsultaMarcada()
        {
            ConsultaRepository consu = new  ConsultaRepository();            
            List<Consulta> listadeconsulta = consu.Lista();
            return View(listadeconsulta);
        }
        [HttpGet]
        public IActionResult ExcluirConsulta(int idConsulta)
        {
            var exc = new ConsultaRepository().Excluir(idConsulta);
            ViewBag.Mensagem = "Consulta DESMARCADA";
            return RedirectToAction("ConsultaMarcada");
        }
        public IActionResult EditarConsulta(int idConsulta)
        {
            ConsultaRepository consulta = new ConsultaRepository();
            List<Consulta> listadeconsulta = consulta.Lista();
            var result = listadeconsulta.Find(c=>c.idConsulta == idConsulta);
            return View(result);
        }
        [HttpPost]
        public IActionResult EditarConsulta(Consulta c)
        {
            ConsultaRepository consulta = new ConsultaRepository();
            consulta.Alterar(c);

            return RedirectToAction("ConsultaMarcada");
        }
        public IActionResult DetalhesConsulta(int idConsulta)
        {        
            ConsultaRepository consulta = new ConsultaRepository();
            List<Consulta> listadeconsulta = consulta.Lista();
            var result = listadeconsulta.Find(c=>c.idConsulta == idConsulta);   
            return View(result); 
        }
    }
}