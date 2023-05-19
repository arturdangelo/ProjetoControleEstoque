namespace Projeto.Forms
{
    partial class Frm_ExibeProduto
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
            this.Dgv_ExibeProduto = new System.Windows.Forms.DataGridView();
            this.Btn_NovoProduto = new System.Windows.Forms.Button();
            this.Btn_Alterar = new System.Windows.Forms.Button();
            this.Btn_Atualizar = new System.Windows.Forms.Button();
            this.Btn_Selecionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_ExibeProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_ExibeProduto
            // 
            this.Dgv_ExibeProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv_ExibeProduto.BackgroundColor = System.Drawing.Color.White;
            this.Dgv_ExibeProduto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Dgv_ExibeProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_ExibeProduto.EnableHeadersVisualStyles = false;
            this.Dgv_ExibeProduto.Location = new System.Drawing.Point(44, 111);
            this.Dgv_ExibeProduto.Name = "Dgv_ExibeProduto";
            this.Dgv_ExibeProduto.Size = new System.Drawing.Size(741, 363);
            this.Dgv_ExibeProduto.TabIndex = 0;
            // 
            // Btn_NovoProduto
            // 
            this.Btn_NovoProduto.Location = new System.Drawing.Point(44, 82);
            this.Btn_NovoProduto.Name = "Btn_NovoProduto";
            this.Btn_NovoProduto.Size = new System.Drawing.Size(75, 23);
            this.Btn_NovoProduto.TabIndex = 1;
            this.Btn_NovoProduto.Text = "Novo";
            this.Btn_NovoProduto.UseVisualStyleBackColor = true;
            this.Btn_NovoProduto.Click += new System.EventHandler(this.Btn_NovoProduto_Click);
            // 
            // Btn_Alterar
            // 
            this.Btn_Alterar.Location = new System.Drawing.Point(146, 82);
            this.Btn_Alterar.Name = "Btn_Alterar";
            this.Btn_Alterar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Alterar.TabIndex = 3;
            this.Btn_Alterar.Text = "Alterar";
            this.Btn_Alterar.UseVisualStyleBackColor = true;
            this.Btn_Alterar.Click += new System.EventHandler(this.Btn_Alterar_Click);
            // 
            // Btn_Atualizar
            // 
            this.Btn_Atualizar.Location = new System.Drawing.Point(248, 82);
            this.Btn_Atualizar.Name = "Btn_Atualizar";
            this.Btn_Atualizar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Atualizar.TabIndex = 4;
            this.Btn_Atualizar.Text = "Atualizar";
            this.Btn_Atualizar.UseVisualStyleBackColor = true;
            this.Btn_Atualizar.Click += new System.EventHandler(this.Btn_Atualizar_Click);
            // 
            // Btn_Selecionar
            // 
            this.Btn_Selecionar.Location = new System.Drawing.Point(710, 82);
            this.Btn_Selecionar.Name = "Btn_Selecionar";
            this.Btn_Selecionar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Selecionar.TabIndex = 5;
            this.Btn_Selecionar.Text = "Selecionar";
            this.Btn_Selecionar.UseVisualStyleBackColor = true;
            // 
            // Frm_ExibeProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 486);
            this.Controls.Add(this.Btn_Selecionar);
            this.Controls.Add(this.Btn_Atualizar);
            this.Controls.Add(this.Btn_Alterar);
            this.Controls.Add(this.Btn_NovoProduto);
            this.Controls.Add(this.Dgv_ExibeProduto);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Frm_ExibeProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_ExibeProduto";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_ExibeProduto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_ExibeProduto;
        private System.Windows.Forms.Button Btn_NovoProduto;
        private System.Windows.Forms.Button Btn_Alterar;
        private System.Windows.Forms.Button Btn_Atualizar;
        private System.Windows.Forms.Button Btn_Selecionar;
    }
}