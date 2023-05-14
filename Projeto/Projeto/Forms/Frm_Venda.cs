using Projeto.Controller;
using Projeto.Entidades;
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
            int codSelecionado = int.Parse(Txt_Codigo.Text);
            Produto p1 = new Produto(codSelecionado, Dgv_Venda);
            AtualizarTotais();

            double total = 0;
            foreach(DataGridViewRow row in Dgv_Venda.Rows)
            {
                total += Convert.ToDouble(row.Cells[4].Value);
            }
            Lbn_Resultado.Text = "R$ "+total.ToString("N2");
            Txt_Codigo.Text = "";


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
            Produto produto = new Produto(Dgv_Venda);
            produto.ExibeProdutoVenda();
        }

        private void AtualizarTotais()
        {
            foreach (DataGridViewRow row in Dgv_Venda.Rows)
            {
                if (row.IsNewRow) continue;

                double quantidade = Convert.ToDouble(row.Cells[2].Value);
                double preco = Convert.ToDouble(row.Cells[3].Value);
                double total = quantidade * preco;

                row.Cells[4].Value = total;
            }
        }

        private void Dgv_Venda_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
            if (Dgv_Venda.Rows.Count > 1)
            {
                if (e.ColumnIndex == 2 || e.ColumnIndex == 3) // coluna "Quantidade" ou "Preço"
                {
                    double quantidade = Convert.ToDouble(Dgv_Venda.Rows[e.RowIndex].Cells[2].Value);
                    double preco = Convert.ToDouble(Dgv_Venda.Rows[e.RowIndex].Cells[3].Value);
                    double total = quantidade * preco;

                    Dgv_Venda.Rows[e.RowIndex].Cells[4].Value = total;
                    
                   double total2 = 0;
                    foreach (DataGridViewRow row in Dgv_Venda.Rows)
                    {
                        total2 += Convert.ToDouble(row.Cells[4].Value);
                    }
                    Lbn_Resultado.Text = "R$ " + total2.ToString("N2");
                }
            }
        }

        private void Dgv_Venda_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            Dgv_Venda.Columns[2].DefaultCellStyle.Format = "N2"; // Formatação da coluna "Quantidade"
            Dgv_Venda.Columns[2].ValueType = typeof(double); // Tipo de dados da coluna "Quantidade"
            Dgv_Venda.Columns[2].CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleRight; // Alinhamento à direita

            // Associar o método "Dgv_Venda_CellValueChanged" ao evento "CellValueChanged" da coluna "Quantidade"
            Dgv_Venda.Columns[2].DataGridView.CellValueChanged += Dgv_Venda_CellValueChanged;
        }

        private void Btn_Remover_Click(object sender, EventArgs e)
        {
            if (Dgv_Venda.SelectedRows.Count > 0)
            {
                int index = Dgv_Venda.SelectedRows[0].Index;
                Dgv_Venda.Rows.RemoveAt(index);

                double total2 = 0;
                foreach (DataGridViewRow row in Dgv_Venda.Rows)
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
    }
}
