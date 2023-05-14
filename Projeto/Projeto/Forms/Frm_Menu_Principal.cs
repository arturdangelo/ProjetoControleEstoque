using Projeto.Forms;
using System;
using System.Windows.Forms;

namespace Projeto
{
    public partial class Frm_Menu_Principal : Form
    {
        public Frm_Menu_Principal()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void produtoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_ExibeProduto F_ExibeProd = new Frm_ExibeProduto();
            F_ExibeProd.MdiParent = this;
            F_ExibeProd.Show();
        }

        private void novaVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Venda F_Venda = new Frm_Venda();
            F_Venda.MdiParent = this;
            F_Venda.Show();
        }
    }
}
