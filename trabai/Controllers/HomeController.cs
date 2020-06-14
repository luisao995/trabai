using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using trabai.Models;

namespace trabai.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(string nome, string usuário, string email, string senha, bool box)
        {
            if (box == false)
            {
                ViewData["Error"] = "Da para marcar o termo?";
            }

            else if (nome != null && usuário != null && email != null && senha != null)
            {
                Models.Usuario.ValorUsuario(nome, usuário, email, senha);

                ViewData["Sucess"] = "Agora já era, Cadastrado com sucesso";
            }

            else
            {
                ViewData["Error"] = "Preenche isso certo";

            }
            return View();

    }
    }
}
