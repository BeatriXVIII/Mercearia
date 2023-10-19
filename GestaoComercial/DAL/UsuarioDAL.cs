
using Models;
using System.Data.SqlClient;

namespace DAL
{
    internal class UsuarioDAL
    {
        public void Inserir(UsuarioDAL usuario, object SqlConnecrion)
        {
            try
            {
                SqlConnection cn = new SqlConnection();
                SqlCommand cmd = cn.CreateCommand();
            }
            catch(Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar inserir o usuário no banco de dados");
            }
        }
        public void Alterar(UsuarioDAL usuario)
        {

        }
        public void Excluir(int id)
        {
            

        }
        public List<Usuario> BuscarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
