using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ProdutoBLL
    {
        public void Inserir(Produto produto)
        {
            if (string.IsNullOrEmpty(produto.Nome))
                throw new Exception("Informe o nome do produto.");
            new ProdutoDAL().Inserir(produto);

        }
        public void Alterar(Produto produto)
        {
            new ProdutoDAL().Alterar(produto);
        }
        public void Excluir(int id)
        {
            new ProdutoDAL().Excluir(id);
        }
        public List<Produto> BuscarTodos()
        {
            return new ProdutoDAL().BuscarTodos();
        }
        public Produto BuscarPorId(int id)
        {
            return new ProdutoDAL().BuscarPorId(id);
        }
    }
}
