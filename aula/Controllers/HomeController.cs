using Servico.Cadastros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aula.Controllers
{
    public class HomeController : Controller
    {
        private ProdutoServico produtoServico = new ProdutoServico();
        // GET: Home
        public ActionResult Index()
        {
            return View(produtoServico.ObterProdutosClassificadosPorNome());
        }
    }
}