using Projeto.Controller;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace Projeto.Entidades
{
    
    class Produto
    {
        private DataTable dataTable;
        private DataGridView Dgv_ExibeProduto;

        public int CodProd { get; private set; }
        public string NomeProd { get; private set; }
        public double PrecoProd { get; private set; }
        public double QtdProd { get; private set; }
        public string SituacaoProd { get; private set; }

        public Produto()
        {

        }

        public Produto(DataGridView dgv_ExibeProduto) 
        {
            Dgv_ExibeProduto = dgv_ExibeProduto;
        }

        public Produto (int codProd, string nomeProd, double precoProd, double qtdProd, string situacaoProd)
        {
            CodProd = codProd;
            NomeProd = nomeProd;
            PrecoProd = precoProd;
            QtdProd = qtdProd;
            SituacaoProd = situacaoProd;
        }
        public void InserirProduto() 
        {
            ProdutoController produtoController = new ProdutoController();
            produtoController.InserirProduto(CodProd, NomeProd, PrecoProd, QtdProd, SituacaoProd);
        }

        public void AtualizarProduto()
        {
            ProdutoController produtoController = new ProdutoController();
            produtoController.AtualizarProduto(CodProd, NomeProd, PrecoProd, QtdProd, SituacaoProd);
        }

        public void ExibeProduto() 
        {
            ProdutoController pesquisaProdutoController = new ProdutoController();
            dataTable = pesquisaProdutoController.ObterProdutos();
            Dgv_ExibeProduto.DataSource = dataTable;

            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
            columnHeaderStyle.BackColor = Color.LightBlue;
            Dgv_ExibeProduto.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
            Dgv_ExibeProduto.Columns["CODIGO_PRODUTO"].Width = 50;
            Dgv_ExibeProduto.Columns["NOME_PRODUTO"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Dgv_ExibeProduto.Columns["PRECO_PRODUTO"].Width = 50;
            Dgv_ExibeProduto.Columns["QUANTIDADE_PRODUTO"].Width = 70;
            Dgv_ExibeProduto.Columns["SITUACAO_PRODUTO"].Width = 60;
            Dgv_ExibeProduto.Columns["CODIGO_PRODUTO"].HeaderText = "Código";
            Dgv_ExibeProduto.Columns["NOME_PRODUTO"].HeaderText = "Nome";
            Dgv_ExibeProduto.Columns["PRECO_PRODUTO"].HeaderText = "Preço";
            Dgv_ExibeProduto.Columns["QUANTIDADE_PRODUTO"].HeaderText = "Quantidade";
            Dgv_ExibeProduto.Columns["SITUACAO_PRODUTO"].HeaderText = "Situação";
            Dgv_ExibeProduto.Columns["CODIGO_PRODUTO"].Resizable = DataGridViewTriState.False;

            Dgv_ExibeProduto.AllowUserToResizeRows = false;
        }
    }
}
