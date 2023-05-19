namespace Projeto.Forms
{
    partial class Frm_Venda
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
            this.Txt_Codigo = new System.Windows.Forms.TextBox();
            this.Lbn_Codigo = new System.Windows.Forms.Label();
            this.Btn_Inserir = new System.Windows.Forms.Button();
            this.Btn_Pesquisar = new System.Windows.Forms.Button();
            this.Btn_Remover = new System.Windows.Forms.Button();
            this.Dgv_Venda = new System.Windows.Forms.DataGridView();
            this.CODIGO_PRODUTO = new System.Windows.Forms.DataGridViewLinkColumn();
            this.NOME_PRODUTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUANTIDADE_PRODUTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECO_PRODUTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL_PRODUTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lbn_Total = new System.Windows.Forms.Label();
            this.Lbn_Resultado = new System.Windows.Forms.Label();
            this.Lbn_Venda = new System.Windows.Forms.Label();
            this.Lbn_CodVenda = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Venda)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_Codigo
            // 
            this.Txt_Codigo.Location = new System.Drawing.Point(98, 96);
            this.Txt_Codigo.Name = "Txt_Codigo";
            this.Txt_Codigo.Size = new System.Drawing.Size(40, 20);
            this.Txt_Codigo.TabIndex = 0;
            this.Txt_Codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Codigo_KeyPress);
            // 
            // Lbn_Codigo
            // 
            this.Lbn_Codigo.AutoSize = true;
            this.Lbn_Codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbn_Codigo.Location = new System.Drawing.Point(12, 96);
            this.Lbn_Codigo.Name = "Lbn_Codigo";
            this.Lbn_Codigo.Size = new System.Drawing.Size(80, 16);
            this.Lbn_Codigo.TabIndex = 1;
            this.Lbn_Codigo.Text = "Cod. Prod.";
            // 
            // Btn_Inserir
            // 
            this.Btn_Inserir.Location = new System.Drawing.Point(165, 94);
            this.Btn_Inserir.Name = "Btn_Inserir";
            this.Btn_Inserir.Size = new System.Drawing.Size(75, 23);
            this.Btn_Inserir.TabIndex = 2;
            this.Btn_Inserir.Text = "Inserir";
            this.Btn_Inserir.UseVisualStyleBackColor = true;
            this.Btn_Inserir.Click += new System.EventHandler(this.Btn_Inserir_Click);
            // 
            // Btn_Pesquisar
            // 
            this.Btn_Pesquisar.Location = new System.Drawing.Point(246, 94);
            this.Btn_Pesquisar.Name = "Btn_Pesquisar";
            this.Btn_Pesquisar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Pesquisar.TabIndex = 3;
            this.Btn_Pesquisar.Text = "Pesquisar";
            this.Btn_Pesquisar.UseVisualStyleBackColor = true;
            // 
            // Btn_Remover
            // 
            this.Btn_Remover.Location = new System.Drawing.Point(577, 96);
            this.Btn_Remover.Name = "Btn_Remover";
            this.Btn_Remover.Size = new System.Drawing.Size(75, 23);
            this.Btn_Remover.TabIndex = 4;
            this.Btn_Remover.Text = "Remover";
            this.Btn_Remover.UseVisualStyleBackColor = true;
            this.Btn_Remover.Click += new System.EventHandler(this.Btn_Remover_Click);
            // 
            // Dgv_Venda
            // 
            this.Dgv_Venda.BackgroundColor = System.Drawing.Color.White;
            this.Dgv_Venda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Venda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGO_PRODUTO,
            this.NOME_PRODUTO,
            this.QUANTIDADE_PRODUTO,
            this.PRECO_PRODUTO,
            this.TOTAL_PRODUTO});
            this.Dgv_Venda.Location = new System.Drawing.Point(12, 123);
            this.Dgv_Venda.Name = "Dgv_Venda";
            this.Dgv_Venda.Size = new System.Drawing.Size(640, 282);
            this.Dgv_Venda.TabIndex = 5;
            this.Dgv_Venda.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Venda_CellValueChanged);
            // 
            // CODIGO_PRODUTO
            // 
            this.CODIGO_PRODUTO.HeaderText = "Código";
            this.CODIGO_PRODUTO.Name = "CODIGO_PRODUTO";
            this.CODIGO_PRODUTO.ReadOnly = true;
            this.CODIGO_PRODUTO.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CODIGO_PRODUTO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CODIGO_PRODUTO.Width = 50;
            // 
            // NOME_PRODUTO
            // 
            this.NOME_PRODUTO.HeaderText = "Nome";
            this.NOME_PRODUTO.Name = "NOME_PRODUTO";
            this.NOME_PRODUTO.ReadOnly = true;
            this.NOME_PRODUTO.Width = 375;
            // 
            // QUANTIDADE_PRODUTO
            // 
            this.QUANTIDADE_PRODUTO.HeaderText = "Quantidade";
            this.QUANTIDADE_PRODUTO.Name = "QUANTIDADE_PRODUTO";
            this.QUANTIDADE_PRODUTO.Width = 70;
            // 
            // PRECO_PRODUTO
            // 
            this.PRECO_PRODUTO.HeaderText = "Preço Unitário";
            this.PRECO_PRODUTO.Name = "PRECO_PRODUTO";
            this.PRECO_PRODUTO.ReadOnly = true;
            this.PRECO_PRODUTO.Width = 50;
            // 
            // TOTAL_PRODUTO
            // 
            this.TOTAL_PRODUTO.HeaderText = "Total";
            this.TOTAL_PRODUTO.Name = "TOTAL_PRODUTO";
            this.TOTAL_PRODUTO.ReadOnly = true;
            this.TOTAL_PRODUTO.Width = 50;
            // 
            // Lbn_Total
            // 
            this.Lbn_Total.AutoSize = true;
            this.Lbn_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbn_Total.Location = new System.Drawing.Point(722, 104);
            this.Lbn_Total.Name = "Lbn_Total";
            this.Lbn_Total.Size = new System.Drawing.Size(92, 25);
            this.Lbn_Total.TabIndex = 6;
            this.Lbn_Total.Text = "TOTAL:";
            // 
            // Lbn_Resultado
            // 
            this.Lbn_Resultado.AutoSize = true;
            this.Lbn_Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbn_Resultado.ForeColor = System.Drawing.Color.Red;
            this.Lbn_Resultado.Location = new System.Drawing.Point(696, 149);
            this.Lbn_Resultado.Name = "Lbn_Resultado";
            this.Lbn_Resultado.Size = new System.Drawing.Size(94, 25);
            this.Lbn_Resultado.TabIndex = 7;
            this.Lbn_Resultado.Text = "R$ 0,00";
            // 
            // Lbn_Venda
            // 
            this.Lbn_Venda.AutoSize = true;
            this.Lbn_Venda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbn_Venda.Location = new System.Drawing.Point(9, 37);
            this.Lbn_Venda.Name = "Lbn_Venda";
            this.Lbn_Venda.Size = new System.Drawing.Size(56, 16);
            this.Lbn_Venda.TabIndex = 8;
            this.Lbn_Venda.Text = "Venda:";
            // 
            // Lbn_CodVenda
            // 
            this.Lbn_CodVenda.AutoSize = true;
            this.Lbn_CodVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbn_CodVenda.Location = new System.Drawing.Point(71, 37);
            this.Lbn_CodVenda.Name = "Lbn_CodVenda";
            this.Lbn_CodVenda.Size = new System.Drawing.Size(102, 16);
            this.Lbn_CodVenda.TabIndex = 9;
            this.Lbn_CodVenda.Text = "CodigoVenda";
            // 
            // Frm_Venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 486);
            this.Controls.Add(this.Lbn_CodVenda);
            this.Controls.Add(this.Lbn_Venda);
            this.Controls.Add(this.Lbn_Resultado);
            this.Controls.Add(this.Lbn_Total);
            this.Controls.Add(this.Dgv_Venda);
            this.Controls.Add(this.Btn_Remover);
            this.Controls.Add(this.Btn_Pesquisar);
            this.Controls.Add(this.Btn_Inserir);
            this.Controls.Add(this.Lbn_Codigo);
            this.Controls.Add(this.Txt_Codigo);
            this.Name = "Frm_Venda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Venda";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Venda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Codigo;
        private System.Windows.Forms.Label Lbn_Codigo;
        private System.Windows.Forms.Button Btn_Inserir;
        private System.Windows.Forms.Button Btn_Pesquisar;
        private System.Windows.Forms.Button Btn_Remover;
        private System.Windows.Forms.DataGridView Dgv_Venda;
        private System.Windows.Forms.Label Lbn_Total;
        private System.Windows.Forms.Label Lbn_Resultado;
        private System.Windows.Forms.Label Lbn_Venda;
        private System.Windows.Forms.Label Lbn_CodVenda;
        private System.Windows.Forms.DataGridViewLinkColumn CODIGO_PRODUTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME_PRODUTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUANTIDADE_PRODUTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECO_PRODUTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL_PRODUTO;
    }
}