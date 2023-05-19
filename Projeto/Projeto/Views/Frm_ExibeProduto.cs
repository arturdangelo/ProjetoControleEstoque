using Projeto.Controller;
using System.Windows.Forms;

namespace Projeto.Forms
{
    public partial class Frm_ExibeProduto : Form
    {
       // private Conexao conexao;
        

        public Frm_ExibeProduto()
        {
            InitializeComponent();
           // conexao = new Conexao();
            Frm_ExibeProdutos_Load();
            Dgv_ExibeProduto.CellFormatting += Dgv_ExibeProduto_CellFormatting;
        }

        //Trocando ponto por vírgula em PRECO_PRODUTO E QUANTIDADE_PRODUTO
        private void Dgv_ExibeProduto_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == Dgv_ExibeProduto.Columns["PRECO_PRODUTO"].Index || e.ColumnIndex == Dgv_ExibeProduto.Columns["QUANTIDADE_PRODUTO"].Index)
            {
                if (e.Value != null)
                {
                    decimal value;
                    if (decimal.TryParse(e.Value.ToString(), out value))
                    {
                        e.Value = value.ToString("N2").Replace(".", ",");
                        e.FormattingApplied = true;
                    }
                }
            }
        }
        private void Frm_ExibeProdutos_Load()
        {
            
            ProdutoController produto = new ProdutoController(Dgv_ExibeProduto);
            produto.ExibeProduto();
            //conexao.FecharConexao();
        }

        private void Btn_NovoProduto_Click(object sender, System.EventArgs e)
        {
            Frm_Produto frmProd = new Frm_Produto();
            frmProd.Show(this);
        }

        private void Btn_Atualizar_Click(object sender, System.EventArgs e)
        {
            ProdutoController produto = new ProdutoController(Dgv_ExibeProduto);
            produto.ExibeProduto();
            //conexao.FecharConexao();
        }

        private void Btn_Alterar_Click(object sender, System.EventArgs e)
        {

            
            if (Dgv_ExibeProduto.SelectedRows.Count > 0)
            {
                DataGridViewCell cell = Dgv_ExibeProduto.SelectedRows[0].Cells[0];
                string aux = cell.Value.ToString();
                int codSelecionado = int.Parse(cell.Value.ToString());
                ProdutoController produtoController = new ProdutoController();
                ProdutoController p1 = new ProdutoController(codSelecionado, 0, null);
            }
        }
    }
}
