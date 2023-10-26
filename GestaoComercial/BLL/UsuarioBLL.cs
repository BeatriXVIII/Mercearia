using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Models;

namespace BLL
{
    public class UsuarioBLL
    {
        public void Inserir(Usuario usuario)
        {
            if (string.IsNullOrEmpty(usuario.Nome))
                throw new Exception("Informe o nome do usuário.");
            new UsuarioDAL().Inserir(usuario);
                     
        }
       public void Alterar(Usuario usuario)
        {

        }
        public void Excluir(int id)
        {
            new UsuarioDAL().Excluir(id);
        }
        public List<Usuario> BuscarTodos()
        {
            return new UsuarioDAL().BuscarTodos();
        }
        public Usuario  BuscarPorId(int id)
        {
            return new UsuarioDAL().BuscarPorId(id);
        }

        public List<Usuario> BuscarPorNome(string _nome)
        {
            return new UsuarioDAL().BuscarPorNome(_nome);
        }

        public Usuario BuscarPorNomeUsuario(string _nomeUsuario)
        {
            return new UsuarioDAL().BuscarPorNomeUsuario(_nomeUsuario);
        }

        public void Alterar(UsuarioBLL usuario)
        {
            throw new NotImplementedException();
        }

        public void Inserir(UsuarioBLL usuario)
        {
            throw new NotImplementedException();
        }
    }
}
