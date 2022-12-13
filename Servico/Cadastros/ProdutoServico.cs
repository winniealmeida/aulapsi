using Modelo.Cadastros;
using Persistencia.DAL.Cadastros;
using System.Linq;

namespace Servico.Cadastros
{
    public class ProdutoServico
    {
        private ProdutoDAL produtoDAL = new ProdutoDAL();
        public IQueryable<Produto> ObterProdutosClassificadosPorNome()
        {
            return produtoDAL.ObterProdutosClassificadosPorNome();
        }
        public IQueryable<Produto> ObterProdutosMarcadosComoDestaque()
        {
            return produtoDAL.ObterProdutosMarcadosComoDestaque();
        }
        public IQueryable<Produto> ObterProdutosDosUltimosTrintaDias()
        {
            return produtoDAL.ObterProdutosDosUltimosTrintaDias();
        }
        public Produto ObterProdutoPorId(long id)
        {
            return produtoDAL.ObterProdutoPorId(id);
        }
        public void GravarProduto(Produto produto)
        {
            produtoDAL.GravarProduto(produto);
        }
        public Produto EliminarProdutoPorId(long id)
        {
            return produtoDAL.EliminarProdutoPorId(id);
        }
    }
}