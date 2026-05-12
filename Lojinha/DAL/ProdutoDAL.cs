using Lojinha.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lojinha.DAL
{
    public class ProdutoDAL
    {
            public void Inserir(ProdutoInformation produto)
            {
                //Conexão com o banco de dados
                SqlConnection cn = new SqlConnection(Dados.StringConexao);
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = cn;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "insere_produto";

                    //Parametros da Stored Procedure
                    SqlParameter pcodigo = new SqlParameter("@codigo", System.Data.SqlDbType.Int);
                    pcodigo.Direction = System.Data.ParameterDirection.Output;
                    cmd.Parameters.Add(pcodigo);

                    SqlParameter pnome = new SqlParameter("@nome", System.Data.SqlDbType.VarChar, 100);
                    pnome.Value = produto.Nome;
                    cmd.Parameters.Add(pnome);

                    SqlParameter ppreco = new SqlParameter("@preco", System.Data.SqlDbType.Decimal, 10);
                    ppreco.Value = produto.Preco;
                    cmd.Parameters.Add(ppreco);

                    SqlParameter pestoque = new SqlParameter("@estoque", System.Data.SqlDbType.Int);
                    pnome.Value = produto.Estoque;
                    cmd.Parameters.Add(pestoque);

                    cn.Open();
                    cmd.ExecuteNonQuery();

                    produto.Codigo = (Int32)cmd.Parameters["@codigo"].Value;


                }
                catch (SqlException ex)
                {
                    throw new Exception("Erro ao acessar o banco de dados." + ex.Message);
                }
                catch
                {
                    throw new Exception("Erro desconhecido ao acessar o banco de dados.");
                }
                finally
                {
                    cn.Close();
                }
            }
            public void Alterar(ProdutoInformation produto)
            {
                //Conexão com o banco de dados
                SqlConnection cn = new SqlConnection(Dados.StringConexao);
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = cn;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "altera_produto";

                    //Parametros da Stored Procedure
                    SqlParameter pcodigo = new SqlParameter("@codigo", System.Data.SqlDbType.Int);
                    pcodigo.Direction = System.Data.ParameterDirection.Output;
                    cmd.Parameters.Add(pcodigo);

                    SqlParameter pnome = new SqlParameter("@nome", System.Data.SqlDbType.VarChar, 100);
                    pnome.Value = produto.Nome;
                    cmd.Parameters.Add(produto);

                    SqlParameter ppreco = new SqlParameter("@preco", System.Data.SqlDbType.Decimal, 10);
                    ppreco.Value = produto.Preco;
                    cmd.Parameters.Add(ppreco);

                    SqlParameter pestoque = new SqlParameter("@estoque", System.Data.SqlDbType.Int);
                    pestoque.Value = produto.Estoque;
                    cmd.Parameters.Add(pestoque);

                    cn.Open();
                    cmd.ExecuteNonQuery();

                    produto.Codigo = (Int32)cmd.Parameters["@codigo"].Value;


                }
                catch (SqlException ex)
                {
                    throw new Exception("Erro ao acessar o banco de dados." + ex.Message);
                }
                catch
                {
                    throw new Exception("Erro desconhecido ao acessar o banco de dados.");
                }
                finally
                {
                    cn.Close();
                }
            }
            public void Excluir(ProdutoInformation produto)
            {
                //Conexão com o banco de dados
                SqlConnection cn = new SqlConnection(Dados.StringConexao);
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = cn;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "exclui_produto";

                    //Parametros da Stored Procedure
                    SqlParameter pcodigo = new SqlParameter("@codigo", System.Data.SqlDbType.Int);
                    pcodigo.Direction = System.Data.ParameterDirection.Output;
                    cmd.Parameters.Add(pcodigo);

                    cn.Open();
                    cmd.ExecuteNonQuery();

                    produto.Codigo = (Int32)cmd.Parameters["@codigo"].Value;

                }
                catch (SqlException ex)
                {
                    throw new Exception("Erro ao acessar o banco de dados." + ex.Message);
                }
                catch
                {
                    throw new Exception("Erro desconhecido ao acessar o banco de dados.");
                }
                finally
                {
                    cn.Close();
                }
            }
            public DataTable Seleciona(string filtro)
            {
                //Conexão com o banco de dados
                SqlConnection cn = new SqlConnection(Dados.StringConexao);
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = cn;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "seleciona_produto";

                    //Parametros da Stored Procedure
                    SqlParameter pfiltro = new SqlParameter("@filtro", System.Data.SqlDbType.VarChar, 100);
                    pfiltro.Value = filtro;
                    cmd.Parameters.Add(pfiltro);
                    DataTable tabela = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(tabela);
                    return tabela;

                }
                catch (SqlException ex)
                {
                    throw new Exception("Erro ao acessar o banco de dados." + ex.Message);
                }
                catch
                {
                    throw new Exception("Erro desconhecido ao acessar o banco de dados.");
                }
                finally
                {
                    cn.Close();
                }
            }
        
    }
}
