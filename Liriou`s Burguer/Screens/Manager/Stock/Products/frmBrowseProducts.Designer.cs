namespace Liriou_s_Burguer.Screens.Manager.Stock.Products
{
    partial class frmBrowseProducts
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
            this.lblConsultarProduto = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.dgvConsultarProduto = new System.Windows.Forms.DataGridView();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Coluna1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblConsultarProduto
            // 
            this.lblConsultarProduto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblConsultarProduto.AutoSize = true;
            this.lblConsultarProduto.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultarProduto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblConsultarProduto.Location = new System.Drawing.Point(237, 9);
            this.lblConsultarProduto.Name = "lblConsultarProduto";
            this.lblConsultarProduto.Size = new System.Drawing.Size(236, 28);
            this.lblConsultarProduto.TabIndex = 566;
            this.lblConsultarProduto.Text = "Consultar Produto";
            this.lblConsultarProduto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.Controls.Add(this.dgvConsultarProduto);
            this.panel.Controls.Add(this.cboTipo);
            this.panel.Controls.Add(this.btnConsultar);
            this.panel.Controls.Add(this.lblTipo);
            this.panel.Controls.Add(this.txtNome);
            this.panel.Controls.Add(this.lblNome);
            this.panel.Controls.Add(this.dataGridView3);
            this.panel.Controls.Add(this.dataGridView1);
            this.panel.Controls.Add(this.dataGridView2);
            this.panel.Location = new System.Drawing.Point(1, 40);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(709, 418);
            this.panel.TabIndex = 567;
            // 
            // dgvConsultarProduto
            // 
            this.dgvConsultarProduto.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(86)))), ((int)(((byte)(112)))));
            this.dgvConsultarProduto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvConsultarProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultarProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Coluna1,
            this.Coluna2,
            this.Coluna3,
            this.Coluna4,
            this.Coluna5,
            this.Coluna6});
            this.dgvConsultarProduto.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgvConsultarProduto.Location = new System.Drawing.Point(11, 77);
            this.dgvConsultarProduto.Name = "dgvConsultarProduto";
            this.dgvConsultarProduto.Size = new System.Drawing.Size(686, 330);
            this.dgvConsultarProduto.TabIndex = 651;
            // 
            // cboTipo
            // 
            this.cboTipo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboTipo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboTipo.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(410, 6);
            this.cboTipo.MaxLength = 32;
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(295, 23);
            this.cboTipo.TabIndex = 650;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(590, 41);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(107, 30);
            this.btnConsultar.TabIndex = 644;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            // 
            // lblTipo
            // 
            this.lblTipo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTipo.Location = new System.Drawing.Point(361, 8);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(43, 19);
            this.lblTipo.TabIndex = 649;
            this.lblTipo.Text = "Tipo:";
            // 
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNome.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(63, 6);
            this.txtNome.MaxLength = 32;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(284, 23);
            this.txtNome.TabIndex = 648;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNome.Location = new System.Drawing.Point(3, 8);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(54, 19);
            this.lblNome.TabIndex = 647;
            this.lblNome.Text = "Nome:";
            // 
            // dataGridView3
            // 
            this.dataGridView3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView3.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(0, 33);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(709, 2);
            this.dataGridView3.TabIndex = 625;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(709, 2);
            this.dataGridView1.TabIndex = 598;
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(353, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(2, 30);
            this.dataGridView2.TabIndex = 597;
            // 
            // Coluna1
            // 
            this.Coluna1.HeaderText = "Nome";
            this.Coluna1.Name = "Coluna1";
            this.Coluna1.ReadOnly = true;
            this.Coluna1.Width = 120;
            // 
            // Coluna2
            // 
            this.Coluna2.HeaderText = "Estoque";
            this.Coluna2.Name = "Coluna2";
            this.Coluna2.ReadOnly = true;
            this.Coluna2.Width = 120;
            // 
            // Coluna3
            // 
            this.Coluna3.HeaderText = "Tipo";
            this.Coluna3.Name = "Coluna3";
            this.Coluna3.ReadOnly = true;
            this.Coluna3.Width = 120;
            // 
            // Coluna4
            // 
            this.Coluna4.HeaderText = "Quantidade";
            this.Coluna4.Name = "Coluna4";
            this.Coluna4.ReadOnly = true;
            this.Coluna4.Width = 80;
            // 
            // Coluna5
            // 
            this.Coluna5.HeaderText = "Valor";
            this.Coluna5.Name = "Coluna5";
            this.Coluna5.ReadOnly = true;
            this.Coluna5.Width = 80;
            // 
            // Coluna6
            // 
            this.Coluna6.HeaderText = "Descrição";
            this.Coluna6.Name = "Coluna6";
            this.Coluna6.ReadOnly = true;
            this.Coluna6.Width = 160;
            // 
            // frmBrowseProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(710, 459);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.lblConsultarProduto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBrowseProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBrowseProducts";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConsultarProduto;
        private System.Windows.Forms.Panel panel;
        public System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Label lblTipo;
        protected System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dgvConsultarProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna6;
    }
}