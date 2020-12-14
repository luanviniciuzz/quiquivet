using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Atividade_3.Models;
using Microsoft.AspNetCore.Http;

namespace Atividade_3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
         public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(Funcionario f)
        {
            FuncionarioRepository func = new FuncionarioRepository();
            Funcionario Funcionario = func.Autentica(f);
            if(Funcionario != null)
            {
                ViewBag.Mensagem = "Você está logado";
                HttpContext.Session.SetInt32("idFuncionario", Funcionario.idFuncionario);
                HttpContext.Session.SetString("nomeFuncioanario", Funcionario.nomeFuncionario);                
                return Redirect("Index");
            }
            else
            {
                ViewBag.Mensagem = "Falha no Login";
                return View();
            }
        }
        public IActionResult CadastroFuncionario()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CadastroFuncionario(Funcionario f)
        {
            FuncionarioRepository func = new FuncionarioRepository();
            func.Inserir(f);
            ViewBag.Mensagem = "Funcionário Cadastrado com Sucesso";
            return View();
        }      
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ConsultaClinica()
        {
            return View();
        }
        public IActionResult Internamento()
        {
            return View();
        }
        public IActionResult TPrecos()
        {
            return View();
        }
        public IActionResult CEstoque()
        {
            return View();
        }
        public IActionResult Vendas()
        {
            return View();
        }
        public IActionResult BancoImagens()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
