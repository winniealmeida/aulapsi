using Modelo.Cadastros;
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
            IEnumerable<Produto> destaques = produtoServico.ObterProdutosMarcadosComoDestaque();
            IEnumerable<Produto> trintaDias = produtoServico.ObterProdutosDosUltimosTrintaDias();

            List<IEnumerable<Produto>> listas = new List<IEnumerable<Produto>>();
            listas.Add(destaques);
            listas.Add(trintaDias);
            return View(listas);
            return View(produtoServico.ObterProdutosClassificadosPorNome());
        }
    }
}