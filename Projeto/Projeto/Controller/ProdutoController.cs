using Projeto.Forms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Projeto.Entidades;


namespace Projeto.Controller
{
    public class ProdutoController
    {
        private Conexao conexao;
        public ProdutoController()
        {
            this.conexao = new Conexao();
        }
        public void InserirProduto(int codProd, string nomeProd, double precoProd, double qtdProd, string situacaoProd)
        {
            try
            {
                this.conexao.AbrirConexao();

                string comando = $"INSERT INTO TABELA_PRODUTO " +
                    $"(CODIGO_PRODUTO, NOME_PRODUTO, PRECO_PRODUTO, QUANTIDADE_PRODUTO, SITUACAO_PRODUTO) VALUES " +
                    $"({codProd}, '{nomeProd}', {precoProd}, {qtdProd}, '{situacaoProd}')";

                this.conexao.ExecutarComando(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao inserir produto: " + ex.Message);
            }
            finally
            {
                this.conexao.FecharConexao();
            }
        }

        public void AtualizarProduto(int codProd, string nomeProd, double precoProd, double qtdProd, string situacaoProd)
        {
            try
            {
                this.conexao.AbrirConexao();

                string comando = $"UPDATE TABELA_PRODUTO SET NOME_PRODUTO = '{nomeProd}', " +
                    $" PRECO_PRODUTO = {precoProd}, QUANTIDADE_PRODUTO = {qtdProd}," +
                    $" SITUACAO_PRODUTO = '{situacaoProd}' WHERE CODIGO_PRODUTO = {codProd}";

                this.conexao.ExecutarComando(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao inserir produto: " + ex.Message);
            }
            finally
            {
                this.conexao.FecharConexao();
            }
        }

        public void ProdutoSelecionado(int CodSelecionado, int num, DataGridView Dgv_ExibeProduto)
        {
            int aux = CodSelecionado;
            try
            {
                conexao.AbrirConexao();


                string query = $"SELECT *FROM TABELA_PRODUTO WHERE CODIGO_PRODUTO = {aux}";
                conexao.ExecutarComando(query);
                using (SqlCommand sqlCommand = new SqlCommand(query, new SqlConnection(conexao.connectionString)))
                {
                    // MessageBox.Show("5");
                    sqlCommand.Connection.Open();

                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    if (reader.Read())
                    {
                        int codigoProduto = (int)reader["CODIGO_PRODUTO"];
                        string nomeProduto = (string)reader["NOME_PRODUTO"];
                        double precoProduto = (double)reader["PRECO_PRODUTO"];
                        double qtdProduto = (double)reader["QUANTIDADE_PRODUTO"];
                        string situacaoProd = (string)reader["SITUACAO_PRODUTO"];


                        //MessageBox.Show("1");
                        Produto produto = new Produto(codigoProduto, nomeProduto, precoProduto, qtdProduto, situacaoProd, Dgv_ExibeProduto, num);
                        

                    }
                    else
                    {
                        // MessageBox.Show("2");
                        throw new Exception("Produto não encontrado.");
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("3");
                MessageBox.Show("Erro ao pesquisar produto: " + ex.Message);
            }
            finally
            {
                //MessageBox.Show("4");
                this.conexao.FecharConexao();
            }
        }

        public DataTable ObterProdutos()
        {
            DataTable dataTable = new DataTable();
            try
            {
                conexao.AbrirConexao();
                string query = "SELECT CODIGO_PRODUTO, NOME_PRODUTO, PRECO_PRODUTO," +
                    "QUANTIDADE_PRODUTO, SITUACAO_PRODUTO FROM TABELA_PRODUTO";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conexao.connectionString);
                adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao obter produtos: " + ex.Message);
            }
            finally
            {
                conexao.FecharConexao();
            }
            return dataTable;
        }
    }
}
