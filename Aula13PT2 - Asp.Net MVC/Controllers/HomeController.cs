using Aula13PT2___Asp.Models;
using Aula13PT2___Asp.Net_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Aula13PT2___Asp.Net_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
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
        public IActionResult Calcula()
        {
            ViewBag.Nome = "Jorge";
            ViewBag.Idade = 35;
            ViewBag.Cpf = "0322123235";

            //Pessoa.Nome = "Felipe";
            //Pessoa.Idade = 26;
            //Pessoa.Cpf = "0323124456";       
            //return View();
            Pessoa pes = new Pessoa
            {
                Nome = "Felipe",
                Idade = 25,
                Cpf = "Felipe"
            };
            return View(pes);

        }
    }
}
