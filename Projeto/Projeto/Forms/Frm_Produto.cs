using System;
using System.Windows.Forms;
using Projeto.Controller;
using System.Globalization;
using System.Data;
using Projeto.Entidades;

namespace Projeto.Forms
{
    public partial class Frm_Produto : Form
    {

        private int codigoProduto;
        private string nomeProduto;
        private double precoProduto;
        private double qtdProduto;
        private string situacaoProd;
        
        public Frm_Produto()
        {
            InitializeComponent();
            Cmb_Situacao.Items.Clear();
            Cmb_Situacao.Items.Add("Ativado");
            Cmb_Situacao.Items.Add("Desativado");
            Cmb_Situacao.SelectedIndex = 0;
            Btn_SalvarAlteracoes.Enabled = false;
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
            CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("en-US");  
        }

        public Frm_Produto(int CodigoProduto, string NomeProduto, double PrecoProduto, double QtdProduto, string SituacaoProd)
        {

            InitializeComponent();

            Txt_Codigo.Enabled = false;

            Cmb_Situacao.Items.Add("Ativado");
            Cmb_Situacao.Items.Add("Desativado");

            codigoProduto = CodigoProduto;
            nomeProduto = NomeProduto;
            precoProduto = PrecoProduto;
            qtdProduto = QtdProduto;
            situacaoProd = SituacaoProd;

            Txt_Codigo.Text = codigoProduto.ToString();
            Txt_NomeProduto.Text = nomeProduto.ToString();
            Txt_Preco.Text = precoProduto.ToString();
            Txt_Quantidade.Text = qtdProduto.ToString();
            Cmb_Situacao.Text = situacaoProd.ToString();

            Btn_Salvar.Enabled = false;

            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
            CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("en-US");
        }

        private void Btn_Salvar_Click(object sender, EventArgs e)
        {
            
           try
            {    
                int codProd = int.Parse(Txt_Codigo.Text);
                string nomeProd = Txt_NomeProduto.Text;
                double precoProd = double.Parse(Txt_Preco.Text.Replace(",","."));
                double qtdProd = float.Parse(Txt_Quantidade.Text.Replace(",","."));
                string situacaoProd = Cmb_Situacao.Text;
                Produto produto = new Produto(codProd, nomeProd, precoProd, qtdProd, situacaoProd);
                produto.InserirProduto();
                MessageBox.Show("Produto cadastrado com sucesso!");   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Txt_Codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Txt_Preco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void Txt_Quantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void Btn_SalvarAlteracoes_Click(object sender, EventArgs e)
        {
            try
            {
                int codProd = int.Parse(Txt_Codigo.Text);
                string nomeProd = Txt_NomeProduto.Text;
                double precoProd = double.Parse(Txt_Preco.Text.Replace(",", "."));
                double qtdProd = float.Parse(Txt_Quantidade.Text.Replace(",", "."));
                string situacaoProd = Cmb_Situacao.Text;
                Produto produto = new Produto(codProd, nomeProd, precoProd, qtdProd, situacaoProd);
                produto.AtualizarProduto();
                MessageBox.Show("Produto atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}

