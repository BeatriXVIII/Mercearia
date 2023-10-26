using Models;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace DAL
{
    public class UsuarioDAL
    {
        public void Inserir(Usuario _usuario)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

            try
            {
                SqlCommand cmd = cn.CreateCommand();


                cmd.CommandText = "INSERT INTO Usuario(Nome, NomeUsuario, Senha, Ativo) VALUES(@Nome, @NomeUsuario, @Senha, @Ativo)";

                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Nome", _usuario.Nome);
                cmd.Parameters.AddWithValue("@NomeUsuario", _usuario.NomeUsuario);
                cmd.Parameters.AddWithValue("@Senha", _usuario.Senha);
                cmd.Parameters.AddWithValue("@Ativo", _usuario.Ativo);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar inserir o usuário no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public void Alterar(Usuario _usuario)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();

                cmd.CommandText = "UPDATE Usuario SET(Nome = @Nome, @NomeUsuario = NomeUsuario, @Senha = Senha, @Ativo = Ativo) WHERE Id = @Id";

                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _usuario.Id);
                cmd.Parameters.AddWithValue("@Nome", _usuario.Nome);
                cmd.Parameters.AddWithValue("@NomeUsuario", _usuario.NomeUsuario);
                cmd.Parameters.AddWithValue("@Senha", _usuario.Senha);
                cmd.Parameters.AddWithValue("@Ativo", _usuario.Ativo);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar atualizar o usuário no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }

        }
        public void Excluir(int _id)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

            try
            {
                SqlCommand cmd = cn.CreateCommand();

                cmd.CommandText = "DELETE FROM Usuario WHERE Id = @Id";

                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _id);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar deletar o usuario no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Usuario> BuscarTodos()
        {
            List<Usuario> usuarioList = new List<Usuario>();
            Usuario usuario;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

            try
            {
                SqlCommand cmd = cn.CreateCommand();


                cmd.CommandText = @"SELECT Id, Nome, NomeUsuario, Senha, Ativo FROM Usuario";

                

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        usuario = new Usuario();
                        usuario.Id = (int)rd["Id"];
                        usuario.Nome = rd["Nome"].ToString();
                        usuario.NomeUsuario = rd["NomeUsuario"].ToString();
                        usuario.Senha = rd["Senha"].ToString();
                        usuario.Ativo = Convert.ToBoolean(rd["Ativo"]);
                        usuarioList.Add(usuario);
                    }
                }
                return usuarioList;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar o usuario por nome no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public Usuario BuscarPorId(int _id)
        {
            Usuario usuario;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

            try
            {
                SqlCommand cmd = cn.CreateCommand();


                cmd.CommandText = " SELECT Id, Nome, NomeUsuario, Senha, Ativo FROM Usuario WHERE Id  = @Id";

                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _id);

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    usuario = new Usuario();
                    if (rd.Read())
                    {
                        usuario.Id = (int)rd["Id"];
                        usuario.Nome = rd["Nome"].ToString();
                        usuario.NomeUsuario = rd["NomeUsuario"].ToString();
                        usuario.Senha = rd["Senha"].ToString();
                        usuario.Ativo = Convert.ToBoolean(rd["Ativo"]);
                    }
                }
                return usuario;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar o usuario no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public List<Usuario> BuscarPorNome(string _nome)
        {
            List<Usuario> usuarioList = new List<Usuario>();
            Usuario usuario;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

            try
            {
                SqlCommand cmd = cn.CreateCommand();


                cmd.CommandText = @"SELECT Id, Nome, NomeUsuario, Senha, Ativo FROM Usuario WHERE Nome LIKE @Nome";

                cmd.Parameters.AddWithValue("@Nome", "%" + _nome + "%");

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        usuario = new Usuario();
                        usuario.Id = (int)rd["Id"];
                        usuario.Nome = rd["Nome"].ToString();
                        usuario.NomeUsuario = rd["NomeUsuario"].ToString();
                        usuario.Senha = rd["Senha"].ToString();
                        usuario.Ativo = Convert.ToBoolean(rd["Ativo"]);
                        usuarioList.Add(usuario);
                    }
                }
                return usuarioList;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar o usuario por nome no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public Usuario BuscarPorNomeUsuario(string _nomeUsuario)
        {
            Usuario usuario;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

            try
            {
                SqlCommand cmd = cn.CreateCommand();


                cmd.CommandText = " SELECT Id, Nome, NomeUsuario, Senha, Ativo FROM Usuario WHERE NomeUsuario  = @NomeUsuario";

                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@NomeUsuario", _nomeUsuario);

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    usuario = new Usuario();
                    if (rd.Read())
                    {
                        usuario = PreencherObjeto(rd);
                    }
                }
                return usuario;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar o usuario no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        private Usuario PreencherObjeto(SqlDataReader rd)
        {
            throw new NotImplementedException();
        }

        private static void NewMethod(Usuario usuario, SqlDataReader rd)
        {
            usuario.Id = (int)rd["Id"];
            usuario.Nome = rd["Nome"].ToString();
            usuario.NomeUsuario = rd["NomeUsuario"].ToString();
            usuario.Senha = rd["Senha"].ToString();
            usuario.Ativo = Convert.ToBoolean(rd["Ativo"]);
        }
    }
}
