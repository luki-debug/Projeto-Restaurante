using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HelloWord.Models;

namespace HelloWord.Controllers
{
    public class HomeeController : Controller
    {
        // GET: Homee
        public ActionResult Index()
        {
            var pessoa = new Pessoa
            {
                PessoaId=1,
                Nome="Lucas Gomes dos Santos",
                Instagran="@lucas.amo"
            };
            //ViewData["PessoaId"] = pessoa.PessoaId;
            //ViewData["Nome"] = pessoa.Nome;
            //ViewData["instagran"] = pessoa.Instagran;
            //Usando ViewTipada abaixo
            return View(pessoa);
        }
        [HttpPost]
        public ActionResult Lista(FormCollection form)
        {
            ViewData["PessoaId"] =form ["PessoaId"];
            ViewData["Nome"] = form["Nome"];
            ViewData["Instagran"] = form["Instagran"];

            return View();
        }
        public ActionResult Sobre()
        {
            return View();
        }
    
    }
}