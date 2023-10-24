using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ClienteBLL
    {
        public void Inserir(Cliente cliente)
        {
            if (string.IsNullOrEmpty(cliente.Nome))
                throw new Exception("Informe o nome do cliente.");
            new ClienteDAL().Inserir(cliente);

        }
        public void Alterar(Cliente cliente)
        {
            new ClienteDAL().Alterar(cliente);
        }
        public void Excluir(int id)
        {
            new ClienteDAL().Excluir(id);
        }
        public List<Cliente> BuscarTodos()
        {
            return new ClienteDAL().BuscarTodos();
        }
        public Cliente BuscarPorId(int id)
        {
            return new ClienteDAL().BuscarPorId(id);
        }
    }
}
