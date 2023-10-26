using Models;
using System.Data.SqlClient;

namespace DAL
{
    public class ProdutoDAL
    {
        public void Inserir(Produto _produto)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

            try
            {
                SqlCommand cmd = cn.CreateCommand();


                cmd.CommandText = "INSERT INTO Produto(Nome,Preco,Estoque) VALUES(@Nome, @Preco, @Estoque)";

                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Nome", _produto.Nome);
                cmd.Parameters.AddWithValue("@Preco", _produto.Preco);
                cmd.Parameters.AddWithValue("@Estoque", _produto.Estoque);


                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar inserir o produto no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }

        }
        public void Alterar(Produto _produto)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

            try
            {
                SqlCommand cmd = cn.CreateCommand();


                cmd.CommandText = "UPDATE Produto SET(Nome = @Nome, Preco = @Preco, Estoque = @Estoque) WHERE Id = @Id";

                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _produto.Id);
                cmd.Parameters.AddWithValue("@Nome", _produto.Nome);
                cmd.Parameters.AddWithValue("@Preco", _produto.Preco);
                cmd.Parameters.AddWithValue("@Estoque", _produto.Estoque);


                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar atualizar o produto no banco de dados.", ex);
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

                cmd.CommandText = "DELETE FROM Produto WHERE Id = @Id";

                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _id);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar deletar o produto no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }

        }
        public List<Produto> BuscarTodos()
        {
            List<Produto> produtoList = new List<Produto>();
            Produto produto;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

            try
            {
                SqlCommand cmd = cn.CreateCommand();


                cmd.CommandText = " SELECT Id, Nome, Preco, Estoque, CodigoBarra FROM Produto ";

                cmd.CommandType = System.Data.CommandType.Text;

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        produto = PreencherObjeto(rd);
                        produtoList.Add(produto);
                    }
                }
                return produtoList;

            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar o produto no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public Produto BuscarPorId(int _id)
        {
            Produto produto;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

            try
            {
                SqlCommand cmd = cn.CreateCommand();


                cmd.CommandText = " SELECT Id, Nome, Preco, Estoque, CodigoBarra FROM Produto  WHERE Id  = @Id";

                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _id);

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    produto = new Produto();
                    if (rd.Read())
                    {
                        produto = PreencherObjeto(rd);
                    }
                }
                return produto;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar o produto no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public Produto BuscarPorNome(string nomeProduto)
        {
            Produto produto;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

            try
            {
                SqlCommand cmd = cn.CreateCommand();


                cmd.CommandText = " SELECT Id, Nome, Preco, Estoque, CodigoBarra FROM Produto WHERE NomeUsuario  = @NomeUsuario";

                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@NomeCliente", nomeProduto);

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    produto = new Produto();
                    if (rd.Read())
                    {
                        produto = PreencherObjeto(rd);
                    }
                }
                return produto;
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
        public Produto BuscarPorCodigoBarra(string codigoBarra)
        {
            Produto produto;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

            try
            {
                SqlCommand cmd = cn.CreateCommand();


                cmd.CommandText = " SELECT Id, Nome, Preco, Estoque, CodigoBarra FROM Produto WHERE NomeUsuario  = @NomeUsuario";

                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@CodigoBarra", codigoBarra);

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    produto = new Produto();
                    if (rd.Read())
                    {
                        produto = PreencherObjeto(rd);
                    }
                }
                return produto;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar o cliente pelo Código de Barra no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        private Produto PreencherObjeto(SqlDataReader rd)
        {
            Produto produto = new Produto();
            produto.Id = (int)rd["Id"];
            produto.Nome = rd["Nome"].ToString();
            produto.Preco = Convert.ToDouble(rd["Preco"]);
            produto.Estoque = Convert.ToDouble(rd["Estoque"]);
            produto.CodigoBarra = rd["CodigoBarra"].ToString();
            return produto;
        }
    }
}