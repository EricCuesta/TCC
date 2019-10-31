namespace Liriou_s_Burguer.Screens.Manager.Stock
{
    partial class frmConsultStock
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
            this.panel = new System.Windows.Forms.Panel();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblCadastrarEstoque = new System.Windows.Forms.Label();
            this.dataGridView11 = new System.Windows.Forms.DataGridView();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.dgvConsultarEstoque = new System.Windows.Forms.DataGridView();
            this.Coluna1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarEstoque)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(62)))));
            this.panel.Controls.Add(this.dgvConsultarEstoque);
            this.panel.Controls.Add(this.dataGridView11);
            this.panel.Controls.Add(this.cboTipo);
            this.panel.Controls.Add(this.lblTipo);
            this.panel.Controls.Add(this.btnConsultar);
            this.panel.Controls.Add(this.dataGridView6);
            this.panel.Controls.Add(this.dataGridView1);
            this.panel.Location = new System.Drawing.Point(0, 41);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(710, 418);
            this.panel.TabIndex = 568;
            // 
            // cboTipo
            // 
            this.cboTipo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboTipo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboTipo.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Items.AddRange(new object[] {
            "Suprimento",
            "Produto"});
            this.cboTipo.Location = new System.Drawing.Point(52, 7);
            this.cboTipo.MaxLength = 32;
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(295, 23);
            this.cboTipo.TabIndex = 650;
            // 
            // lblTipo
            // 
            this.lblTipo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTipo.Location = new System.Drawing.Point(3, 8);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(43, 19);
            this.lblTipo.TabIndex = 649;
            this.lblTipo.Text = "Tipo:";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.Color.Black;
            this.btnConsultar.Location = new System.Drawing.Point(486, 6);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(107, 30);
            this.btnConsultar.TabIndex = 644;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(709, 2);
            this.dataGridView1.TabIndex = 598;
            // 
            // lblCadastrarEstoque
            // 
            this.lblCadastrarEstoque.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCadastrarEstoque.AutoSize = true;
            this.lblCadastrarEstoque.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastrarEstoque.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCadastrarEstoque.Location = new System.Drawing.Point(237, 7);
            this.lblCadastrarEstoque.Name = "lblCadastrarEstoque";
            this.lblCadastrarEstoque.Size = new System.Drawing.Size(237, 28);
            this.lblCadastrarEstoque.TabIndex = 567;
            this.lblCadastrarEstoque.Text = "Cadastrar Estoque";
            this.lblCadastrarEstoque.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView11
            // 
            this.dataGridView11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView11.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView11.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView11.Location = new System.Drawing.Point(1, 33);
            this.dataGridView11.Name = "dataGridView11";
            this.dataGridView11.Size = new System.Drawing.Size(355, 2);
            this.dataGridView11.TabIndex = 665;
            // 
            // dataGridView6
            // 
            this.dataGridView6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView6.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Location = new System.Drawing.Point(354, 3);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.Size = new System.Drawing.Size(2, 30);
            this.dataGridView6.TabIndex = 599;
            // 
            // dgvConsultarEstoque
            // 
            this.dgvConsultarEstoque.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(86)))), ((int)(((byte)(112)))));
            this.dgvConsultarEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultarEstoque.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Coluna1,
            this.Coluna2,
            this.Coluna3,
            this.Coluna4});
            this.dgvConsultarEstoque.Location = new System.Drawing.Point(3, 42);
            this.dgvConsultarEstoque.Name = "dgvConsultarEstoque";
            this.dgvConsultarEstoque.Size = new System.Drawing.Size(704, 373);
            this.dgvConsultarEstoque.TabIndex = 666;
            // 
            // Coluna1
            // 
            this.Coluna1.DataPropertyName = "id_stock";
            this.Coluna1.HeaderText = "ID";
            this.Coluna1.Name = "Coluna1";
            this.Coluna1.ReadOnly = true;
            // 
            // Coluna2
            // 
            this.Coluna2.DataPropertyName = "ds_place";
            this.Coluna2.HeaderText = "Local";
            this.Coluna2.Name = "Coluna2";
            this.Coluna2.ReadOnly = true;
            this.Coluna2.Width = 260;
            // 
            // Coluna3
            // 
            this.Coluna3.DataPropertyName = "ds_typeStock";
            this.Coluna3.HeaderText = "Tipo";
            this.Coluna3.Name = "Coluna3";
            this.Coluna3.ReadOnly = true;
            this.Coluna3.Width = 150;
            // 
            // Coluna4
            // 
            this.Coluna4.DataPropertyName = "nr_maxAmount";
            this.Coluna4.HeaderText = "Quantidade Máxima";
            this.Coluna4.Name = "Coluna4";
            this.Coluna4.ReadOnly = true;
            this.Coluna4.Width = 150;
            // 
            // frmConsultStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(710, 459);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.lblCadastrarEstoque);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConsultStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consult Stock";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarEstoque)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        public System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblCadastrarEstoque;
        private System.Windows.Forms.DataGridView dataGridView11;
        private System.Windows.Forms.DataGridView dataGridView6;
        private System.Windows.Forms.DataGridView dgvConsultarEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna4;
    }
}