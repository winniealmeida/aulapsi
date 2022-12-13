using Persistencia.Contexts;
using System.Data.Entity;
using Modelo.Cadastros;
using System.Linq;
using System;

namespace Persistencia.DAL.Cadastros
{
    public class ProdutoDAL
    {
        private EFContext context = new EFContext();
        public IQueryable<Produto> ObterProdutosClassificadosPorNome()
        {
            return context.Produtos.Include(c => c.Categoria).Include(f => f.Fabricante).
            OrderBy(n => n.Nome);
        }
        public IQueryable<Produto> ObterProdutosMarcadosComoDestaque()
        {
            return context.Produtos.Include(c => c.Categoria).Include(f => f.Fabricante).
            Where(x => x.Destaque == true).
            OrderBy(n => n.Nome);
        }
        public IQueryable<Produto> ObterProdutosDosUltimosTrintaDias()
        {
            DateTime filtro = DateTime.Now.AddDays(-30);
            return context.Produtos.Include(c => c.Categoria).Include(f => f.Fabricante).
            Where(x => x.DataCadastro > filtro).
            OrderBy(n => n.Nome);
        }
        public Produto ObterProdutoPorId(long id)
        {
            return context.Produtos.Where(p => p.ProdutoId == id).Include(c => c.Categoria).Include(f => f.Fabricante).First();
        }
        public void GravarProduto(Produto produto)
        {
            if (produto.ProdutoId == null)
            {
                context.Produtos.Add(produto);
            }
            else
            {
                context.Entry(produto).State = EntityState.Modified;
            }
            context.SaveChanges();
        }
        public Produto EliminarProdutoPorId(long id)
        {
            Produto produto = ObterProdutoPorId(id);
            context.Produtos.Remove(produto);
            context.SaveChanges();
            return produto;
        }
    }
}