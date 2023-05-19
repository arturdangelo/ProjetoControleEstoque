using Projeto.Model;
using Projeto.Forms;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System;

namespace Projeto.Controller
{

    class ProdutoController
    {
        private DataTable dataTable;
        private DataGridView Dgv_Produto;
        public event Action<string> AtualizarLabelEvent;

        public int CodProd { get; private set; }
        public string NomeProd { get; private set; }
        public double PrecoProd { get; private set; }
        public double QtdProd { get; private set; }
        public string SituacaoProd { get; private set; }
        public Label Lbn_Resultado { get; private set; }
        public TextBox Txt_Codigo { get; private set; }

        public DataGridViewCellEventArgs E { get; private set; }

        public ProdutoController()
        {

        }

        public ProdutoController (DataGridView dgv_Produto, DataGridViewCellEventArgs e, Label lbn_Resultado)
        {
            Dgv_Produto = dgv_Produto;
            E = e;
            Lbn_Resultado = lbn_Resultado;
        }

        //receber datagridview "Frm_ExibeProduto" e "Frm_Venda" 
        public ProdutoController(DataGridView dgv_Produto)
        {
            Dgv_Produto = dgv_Produto;
        }

        //"Frm_ExibeProduto"
        public ProdutoController(int codProd, int num, DataGridView dgv_ExibeProduto)
        {
            CodProd = codProd;
            Dgv_Produto = dgv_ExibeProduto;
            ProdutoModel produtoModel = new ProdutoModel();
            produtoModel.ProdutoSelecionado(CodProd, num, Dgv_Produto, null, null);
        }
        public ProdutoController(int codProd, int num, DataGridView dgv_ExibeProduto, Label lbn_Resultado, TextBox txt_Codigo)
        {
            CodProd = codProd;
            Dgv_Produto = dgv_ExibeProduto;
            ProdutoModel produtoModel = new ProdutoModel();
            Lbn_Resultado = lbn_Resultado;
            Txt_Codigo = txt_Codigo;
            produtoModel.ProdutoSelecionado(CodProd, num, Dgv_Produto, Txt_Codigo, Lbn_Resultado);
        }
        public ProdutoController(int codProd, string nomeProd, double precoProd, double qtdProd, string situacaoProd)
        {
            CodProd = codProd;
            NomeProd = nomeProd;
            PrecoProd = precoProd;
            QtdProd = qtdProd;
            SituacaoProd = situacaoProd;


        }

        //receber valores de "ProdutoModel"
        public ProdutoController(int codProd, string nomeProd, double precoProd, double qtdProd, string situacaoProd, DataGridView dgv_ExibeProduto, int num, TextBox txt_Codigo, Label lbn_Resultado)
        {
            CodProd = codProd;
            NomeProd = nomeProd;
            PrecoProd = precoProd;
            QtdProd = qtdProd;
            SituacaoProd = situacaoProd;
            Dgv_Produto = dgv_ExibeProduto;
            Lbn_Resultado = lbn_Resultado;
            Txt_Codigo = txt_Codigo;

            if (num == 0)
            {
                Frm_Produto frm_Produto = new Frm_Produto(CodProd, NomeProd, PrecoProd, QtdProd, SituacaoProd);
                frm_Produto.Show();
            }
            else if (num == 1)
            {
                if (situacaoProd == "Desativado")
                {
                    MessageBox.Show("O produto selecionado está desativado!");
                }

                else if (QtdProd == 0)
                {
                    MessageBox.Show("Produto com estoque zerado!");
                }
                else
                {
                    ProdutoSelecionadoVenda();
                    AtualizaTotais();
                    AtualizaResultado();
                }
            }
        }
        public void AtualizarResultadoAltQtd()
        {
            if (Dgv_Produto.Rows.Count > 1)
            {
                if (E.ColumnIndex == 2 || E.ColumnIndex == 3) // coluna "Quantidade" ou "Preço"
                {
                    double quantidade = Convert.ToDouble(Dgv_Produto.Rows[E.RowIndex].Cells[2].Value);
                    double preco = Convert.ToDouble(Dgv_Produto.Rows[E.RowIndex].Cells[3].Value);
                    double total = quantidade * preco;

                    Dgv_Produto.Rows[E.RowIndex].Cells[4].Value = total;

                    double total2 = 0;
                    foreach (DataGridViewRow row in Dgv_Produto.Rows)
                    {
                        total2 += Convert.ToDouble(row.Cells[4].Value);
                    }
                    Lbn_Resultado.Text = "R$ " + total2.ToString("N2");
                }
            }
        }
        public void RemoverLinha()
        {
            if (Dgv_Produto.SelectedRows.Count > 0)
            {
                int index = Dgv_Produto.SelectedRows[0].Index;
                Dgv_Produto.Rows.RemoveAt(index);

                double total2 = 0;
                foreach (DataGridViewRow row in Dgv_Produto.Rows)
                {
                    total2 += Convert.ToDouble(row.Cells[4].Value);
                }
                Lbn_Resultado.Text = "R$ " + total2.ToString("N2");
            }
            else
            {
                MessageBox.Show("Por favor selecione uma linha");
            }
        }

        public void InserirProduto()
        {
            ProdutoModel produtoController = new ProdutoModel();
            produtoController.InserirProduto(CodProd, NomeProd, PrecoProd, QtdProd, SituacaoProd);
        }
        public void ProdutoSelecionadoVenda()
        {
            DataGridViewRow novaLinha = new DataGridViewRow();
            novaLinha.Cells.Add(new DataGridViewTextBoxCell { Value = CodProd });
            novaLinha.Cells.Add(new DataGridViewTextBoxCell { Value = NomeProd });
            novaLinha.Cells.Add(new DataGridViewTextBoxCell { Value = 1 });
            novaLinha.Cells.Add(new DataGridViewTextBoxCell { Value = PrecoProd });
            Dgv_Produto.Rows.Add(novaLinha);
        }

        public void AtualizarProduto()
        {
            ProdutoModel produtoModel = new ProdutoModel();
            produtoModel.AtualizarProduto(CodProd, NomeProd, PrecoProd, QtdProd, SituacaoProd);
        }

        //Atualizar total de cada produto
        public void AtualizaTotais()
        {
            foreach (DataGridViewRow row in Dgv_Produto.Rows)
            {
                if (row.IsNewRow) continue;

                double quantidade = Convert.ToDouble(row.Cells[2].Value);
                double preco = Convert.ToDouble(row.Cells[3].Value);
                double total = quantidade * preco;
                row.Cells[4].Value = total;
            }
        }

        public void AtualizaResultado()
        {
            double totalResultado = 0;
            foreach (DataGridViewRow row in Dgv_Produto.Rows)
            {
                totalResultado += Convert.ToDouble(row.Cells[4].Value);

            }
            Lbn_Resultado.Text = totalResultado.ToString();
            Lbn_Resultado.Text = "R$ " + totalResultado.ToString("N2");
            Txt_Codigo.Text = "";
        }
        public void ExibeProdutoVenda()
        {
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
            columnHeaderStyle.BackColor = Color.LightBlue;
            Dgv_Produto.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
            Dgv_Produto.Columns["CODIGO_PRODUTO"].Width = 50;
            Dgv_Produto.Columns["NOME_PRODUTO"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Dgv_Produto.Columns["PRECO_PRODUTO"].Width = 50;
            Dgv_Produto.Columns["QUANTIDADE_PRODUTO"].Width = 70;

        }
        public void ExibeProduto()
        {
            ProdutoModel pesquisaProdutoController = new ProdutoModel();
            dataTable = pesquisaProdutoController.ObterProdutos();
            Dgv_Produto.DataSource = dataTable;

            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
            columnHeaderStyle.BackColor = Color.LightBlue;
            Dgv_Produto.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
            Dgv_Produto.Columns["CODIGO_PRODUTO"].Width = 50;
            Dgv_Produto.Columns["NOME_PRODUTO"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Dgv_Produto.Columns["PRECO_PRODUTO"].Width = 50;
            Dgv_Produto.Columns["QUANTIDADE_PRODUTO"].Width = 70;
            Dgv_Produto.Columns["SITUACAO_PRODUTO"].Width = 60;
            Dgv_Produto.Columns["CODIGO_PRODUTO"].HeaderText = "Código";
            Dgv_Produto.Columns["NOME_PRODUTO"].HeaderText = "Nome";
            Dgv_Produto.Columns["PRECO_PRODUTO"].HeaderText = "Preço";
            Dgv_Produto.Columns["QUANTIDADE_PRODUTO"].HeaderText = "Quantidade";
            Dgv_Produto.Columns["SITUACAO_PRODUTO"].HeaderText = "Situação";
            Dgv_Produto.Columns["CODIGO_PRODUTO"].Resizable = DataGridViewTriState.False;

            Dgv_Produto.AllowUserToResizeRows = false;
        }
    }
}
