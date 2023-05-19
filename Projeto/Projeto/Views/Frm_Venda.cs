using Projeto.Controller;
using System;
using System.Windows.Forms;


namespace Projeto.Forms
{
    public partial class Frm_Venda : Form
    {
    
        public Frm_Venda()
        {
            InitializeComponent();
            Frm_Venda_Load();
        }

        private void Btn_Inserir_Click(object sender, EventArgs e)
        {

            if (Txt_Codigo.Text != "")
            {
                int codSelecionado = int.Parse(Txt_Codigo.Text);
                ProdutoController p1 = new ProdutoController(codSelecionado, 1, Dgv_Venda, Lbn_Resultado, Txt_Codigo);

            }
            else
            {
                MessageBox.Show("Por favor informe o código do Produto");
            }
        }

        private void Txt_Codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Frm_Venda_Load()
        {
            ProdutoController produto = new ProdutoController(Dgv_Venda);
            produto.ExibeProdutoVenda();
        }

        private void Dgv_Venda_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            ProdutoController produtoController = new ProdutoController(Dgv_Venda, e, Lbn_Resultado);
            produtoController.AtualizarResultadoAltQtd();
        }

        private void Btn_Remover_Click(object sender, EventArgs e)
        {
            ProdutoController produtoController = new ProdutoController(Dgv_Venda, null, Lbn_Resultado);
            produtoController.RemoverLinha();
           
        }
    }
}
