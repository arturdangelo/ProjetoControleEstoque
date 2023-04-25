namespace Projeto.Forms
{
    partial class Frm_Produto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Grp_Produto = new System.Windows.Forms.GroupBox();
            this.Lbn_Situcao = new System.Windows.Forms.Label();
            this.Cmb_Situacao = new System.Windows.Forms.ComboBox();
            this.Lbl_Quantidade = new System.Windows.Forms.Label();
            this.Lbl_Preco = new System.Windows.Forms.Label();
            this.Txt_Quantidade = new System.Windows.Forms.TextBox();
            this.Txt_Preco = new System.Windows.Forms.TextBox();
            this.Lbl_NomeProduto = new System.Windows.Forms.Label();
            this.Txt_NomeProduto = new System.Windows.Forms.TextBox();
            this.Txt_Codigo = new System.Windows.Forms.TextBox();
            this.Lbl_Código = new System.Windows.Forms.Label();
            this.Btn_Salvar = new System.Windows.Forms.Button();
            this.Btn_SalvarAlteracoes = new System.Windows.Forms.Button();
            this.Grp_Produto.SuspendLayout();
            this.SuspendLayout();
            // 
            // Grp_Produto
            // 
            this.Grp_Produto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Grp_Produto.Controls.Add(this.Lbn_Situcao);
            this.Grp_Produto.Controls.Add(this.Cmb_Situacao);
            this.Grp_Produto.Controls.Add(this.Lbl_Quantidade);
            this.Grp_Produto.Controls.Add(this.Lbl_Preco);
            this.Grp_Produto.Controls.Add(this.Txt_Quantidade);
            this.Grp_Produto.Controls.Add(this.Txt_Preco);
            this.Grp_Produto.Controls.Add(this.Lbl_NomeProduto);
            this.Grp_Produto.Controls.Add(this.Txt_NomeProduto);
            this.Grp_Produto.Controls.Add(this.Txt_Codigo);
            this.Grp_Produto.Controls.Add(this.Lbl_Código);
            this.Grp_Produto.Location = new System.Drawing.Point(53, 46);
            this.Grp_Produto.Name = "Grp_Produto";
            this.Grp_Produto.Size = new System.Drawing.Size(612, 251);
            this.Grp_Produto.TabIndex = 0;
            this.Grp_Produto.TabStop = false;
            this.Grp_Produto.Text = "Produto";
            // 
            // Lbn_Situcao
            // 
            this.Lbn_Situcao.AutoSize = true;
            this.Lbn_Situcao.Location = new System.Drawing.Point(211, 75);
            this.Lbn_Situcao.Name = "Lbn_Situcao";
            this.Lbn_Situcao.Size = new System.Drawing.Size(49, 13);
            this.Lbn_Situcao.TabIndex = 9;
            this.Lbn_Situcao.Text = "Situação";
            // 
            // Cmb_Situacao
            // 
            this.Cmb_Situacao.BackColor = System.Drawing.SystemColors.Window;
            this.Cmb_Situacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Situacao.FormattingEnabled = true;
            this.Cmb_Situacao.Location = new System.Drawing.Point(214, 94);
            this.Cmb_Situacao.Name = "Cmb_Situacao";
            this.Cmb_Situacao.Size = new System.Drawing.Size(93, 21);
            this.Cmb_Situacao.TabIndex = 8;
            // 
            // Lbl_Quantidade
            // 
            this.Lbl_Quantidade.AutoSize = true;
            this.Lbl_Quantidade.Location = new System.Drawing.Point(117, 75);
            this.Lbl_Quantidade.Name = "Lbl_Quantidade";
            this.Lbl_Quantidade.Size = new System.Drawing.Size(62, 13);
            this.Lbl_Quantidade.TabIndex = 7;
            this.Lbl_Quantidade.Text = "Quantidade";
            // 
            // Lbl_Preco
            // 
            this.Lbl_Preco.AutoSize = true;
            this.Lbl_Preco.Location = new System.Drawing.Point(3, 75);
            this.Lbl_Preco.Name = "Lbl_Preco";
            this.Lbl_Preco.Size = new System.Drawing.Size(52, 13);
            this.Lbl_Preco.TabIndex = 6;
            this.Lbl_Preco.Text = "Preço R$";
            // 
            // Txt_Quantidade
            // 
            this.Txt_Quantidade.Location = new System.Drawing.Point(120, 95);
            this.Txt_Quantidade.Name = "Txt_Quantidade";
            this.Txt_Quantidade.Size = new System.Drawing.Size(72, 20);
            this.Txt_Quantidade.TabIndex = 5;
            this.Txt_Quantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Quantidade_KeyPress);
            // 
            // Txt_Preco
            // 
            this.Txt_Preco.Location = new System.Drawing.Point(6, 94);
            this.Txt_Preco.Name = "Txt_Preco";
            this.Txt_Preco.Size = new System.Drawing.Size(91, 20);
            this.Txt_Preco.TabIndex = 4;
            this.Txt_Preco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Preco_KeyPress);
            // 
            // Lbl_NomeProduto
            // 
            this.Lbl_NomeProduto.AutoSize = true;
            this.Lbl_NomeProduto.Location = new System.Drawing.Point(66, 17);
            this.Lbl_NomeProduto.Name = "Lbl_NomeProduto";
            this.Lbl_NomeProduto.Size = new System.Drawing.Size(35, 13);
            this.Lbl_NomeProduto.TabIndex = 3;
            this.Lbl_NomeProduto.Text = "Nome";
            // 
            // Txt_NomeProduto
            // 
            this.Txt_NomeProduto.Location = new System.Drawing.Point(66, 36);
            this.Txt_NomeProduto.Name = "Txt_NomeProduto";
            this.Txt_NomeProduto.Size = new System.Drawing.Size(511, 20);
            this.Txt_NomeProduto.TabIndex = 2;
            // 
            // Txt_Codigo
            // 
            this.Txt_Codigo.Location = new System.Drawing.Point(10, 37);
            this.Txt_Codigo.Name = "Txt_Codigo";
            this.Txt_Codigo.Size = new System.Drawing.Size(37, 20);
            this.Txt_Codigo.TabIndex = 1;
            this.Txt_Codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Codigo_KeyPress);
            // 
            // Lbl_Código
            // 
            this.Lbl_Código.AutoSize = true;
            this.Lbl_Código.Location = new System.Drawing.Point(7, 20);
            this.Lbl_Código.Name = "Lbl_Código";
            this.Lbl_Código.Size = new System.Drawing.Size(40, 13);
            this.Lbl_Código.TabIndex = 0;
            this.Lbl_Código.Text = "Código";
            // 
            // Btn_Salvar
            // 
            this.Btn_Salvar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_Salvar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_Salvar.Location = new System.Drawing.Point(563, 417);
            this.Btn_Salvar.Name = "Btn_Salvar";
            this.Btn_Salvar.Size = new System.Drawing.Size(102, 56);
            this.Btn_Salvar.TabIndex = 1;
            this.Btn_Salvar.Text = "SALVAR";
            this.Btn_Salvar.UseVisualStyleBackColor = false;
            this.Btn_Salvar.Click += new System.EventHandler(this.Btn_Salvar_Click);
            // 
            // Btn_SalvarAlteracoes
            // 
            this.Btn_SalvarAlteracoes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_SalvarAlteracoes.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_SalvarAlteracoes.Location = new System.Drawing.Point(430, 417);
            this.Btn_SalvarAlteracoes.Name = "Btn_SalvarAlteracoes";
            this.Btn_SalvarAlteracoes.Size = new System.Drawing.Size(102, 56);
            this.Btn_SalvarAlteracoes.TabIndex = 3;
            this.Btn_SalvarAlteracoes.Text = "SALVAR ALTERAÇÕES";
            this.Btn_SalvarAlteracoes.UseVisualStyleBackColor = false;
            this.Btn_SalvarAlteracoes.Click += new System.EventHandler(this.Btn_SalvarAlteracoes_Click);
            // 
            // Frm_Produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(686, 485);
            this.Controls.Add(this.Btn_SalvarAlteracoes);
            this.Controls.Add(this.Btn_Salvar);
            this.Controls.Add(this.Grp_Produto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Frm_Produto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produto";
            this.Grp_Produto.ResumeLayout(false);
            this.Grp_Produto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Grp_Produto;
        private System.Windows.Forms.Label Lbl_NomeProduto;
        private System.Windows.Forms.TextBox Txt_NomeProduto;
        private System.Windows.Forms.TextBox Txt_Codigo;
        private System.Windows.Forms.Label Lbl_Código;
        private System.Windows.Forms.Button Btn_Salvar;
        private System.Windows.Forms.Button Btn_SalvarAlteracoes;
        private System.Windows.Forms.Label Lbl_Quantidade;
        private System.Windows.Forms.Label Lbl_Preco;
        private System.Windows.Forms.TextBox Txt_Quantidade;
        private System.Windows.Forms.TextBox Txt_Preco;
        private System.Windows.Forms.Label Lbn_Situcao;
        private System.Windows.Forms.ComboBox Cmb_Situacao;
    }
}