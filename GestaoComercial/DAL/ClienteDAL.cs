using Models;
using System.Data.SqlClient;

namespace DAL
{
    public class ClienteDAL
    {
        public void Inserir(Cliente _cliente)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

            try
            {
                SqlCommand cmd = cn.CreateCommand();


                cmd.CommandText = "INSERT INTO Cliente(Nome, Fone) VALUES(@Nome, @Fone)";

                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Nome", _cliente.Nome);
                cmd.Parameters.AddWithValue("@Telefone", _cliente.Telefone);


                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar inserir o cliente no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public void Alterar(Cliente _cliente)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

            try
            {
                SqlCommand cmd = cn.CreateCommand();


                cmd.CommandText = "UPDATE Cliente SET(Nome = @Nome, Fone = @Fone) WHERE Id = @Id";

                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _cliente.Id);
                cmd.Parameters.AddWithValue("@Nome", _cliente.Nome);
                cmd.Parameters.AddWithValue("@Telefone", _cliente.Telefone);


                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar atualizar o cliente no banco de dados.", ex);
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

                cmd.CommandText = "DELETE FROM Cliente WHERE Id = @Id";

                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _id);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar deletar o cliente no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Cliente> BuscarTodos()
        {
            List<Cliente> clienteList = new List<Cliente>();
            Cliente cliente;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

            try
            {
                SqlCommand cmd = cn.CreateCommand();


                cmd.CommandText = " SELECT Id, Nome, Fone FROM Cliente";

                cmd.CommandType = System.Data.CommandType.Text;

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        cliente = new Cliente();
                        cliente.Id = (int)rd["Id"];
                        cliente.Nome = rd["Nome"].ToString();
                        cliente.Telefone = rd["Telefone"].ToString();
                        clienteList.Add(cliente);
                    }
                }
                return clienteList;

            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar o cliente no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public Cliente BuscarPorId(int _id)
        {
            Cliente cliente;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

            try
            {
                SqlCommand cmd = cn.CreateCommand();


                cmd.CommandText = " SELECT Id, Nome, Fone FROM Cliente WHERE Id  = @Id";

                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _id);

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    cliente = new Cliente();
                    if (rd.Read())
                    {
                        cliente.Id = (int)rd["Id"];
                        cliente.Nome = rd["Nome"].ToString();
                        cliente.Telefone = rd["Fone"].ToString();

                    }
                }
                return cliente;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar o cliente no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public Cliente BuscarPorNome(string nomeCliente)
        {
            Cliente cliente;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

            try
            {
                SqlCommand cmd = cn.CreateCommand();


                cmd.CommandText = " SELECT Id, Nome, NomeUsuario, Senha, Ativo FROM Usuario WHERE NomeUsuario  = @NomeUsuario";

                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@NomeCliente", nomeCliente);

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    cliente = new Cliente();
                    if (rd.Read())
                    {
                        cliente = PreencherObjeto(rd);
                    }
                }
                return cliente;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar o cliente pelo nome no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        private Cliente PreencherObjeto(SqlDataReader rd)
        {
            throw new NotImplementedException();
        }

        private static void NewMethod(Cliente cliente, SqlDataReader rd)
        {
            cliente.Id = (int)rd["Id"];
            cliente.Nome = rd["Nome"].ToString();
            cliente.Telefone = rd["Telefone"].ToString();
        }
    }
}