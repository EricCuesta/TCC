namespace Liriou_s_Burguer.Screens.Manager.Stock
{
    partial class frmDeleteInventory
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.nudId = new System.Windows.Forms.NumericUpDown();
            this.lblID = new System.Windows.Forms.Label();
            this.nudQtdMáximo = new System.Windows.Forms.NumericUpDown();
            this.lblQtdMáximo = new System.Windows.Forms.Label();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.lblLocal = new System.Windows.Forms.Label();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblDeletarEstoque = new System.Windows.Forms.Label();
            this.dgvConsultarEstoque = new System.Windows.Forms.DataGridView();
            this.Coluna1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtdMáximo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.panel.Controls.Add(this.dataGridView2);
            this.panel.Controls.Add(this.nudId);
            this.panel.Controls.Add(this.lblID);
            this.panel.Controls.Add(this.nudQtdMáximo);
            this.panel.Controls.Add(this.lblQtdMáximo);
            this.panel.Controls.Add(this.cboTipo);
            this.panel.Controls.Add(this.lblTipo);
            this.panel.Controls.Add(this.txtLocal);
            this.panel.Controls.Add(this.lblLocal);
            this.panel.Controls.Add(this.btnDeletar);
            this.panel.Controls.Add(this.dataGridView5);
            this.panel.Controls.Add(this.dataGridView3);
            this.panel.Controls.Add(this.dataGridView6);
            this.panel.Controls.Add(this.dataGridView1);
            this.panel.Location = new System.Drawing.Point(0, 41);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(710, 418);
            this.panel.TabIndex = 566;
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(1, 33);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(709, 2);
            this.dataGridView2.TabIndex = 662;
            // 
            // nudId
            // 
            this.nudId.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudId.Location = new System.Drawing.Point(45, 6);
            this.nudId.Name = "nudId";
            this.nudId.Size = new System.Drawing.Size(120, 23);
            this.nudId.TabIndex = 661;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblID.Location = new System.Drawing.Point(2, 5);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(37, 26);
            this.lblID.TabIndex = 660;
            this.lblID.Text = "ID:";
            // 
            // nudQtdMáximo
            // 
            this.nudQtdMáximo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nudQtdMáximo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.nudQtdMáximo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudQtdMáximo.Location = new System.Drawing.Point(520, 72);
            this.nudQtdMáximo.Name = "nudQtdMáximo";
            this.nudQtdMáximo.ReadOnly = true;
            this.nudQtdMáximo.Size = new System.Drawing.Size(187, 20);
            this.nudQtdMáximo.TabIndex = 654;
            // 
            // lblQtdMáximo
            // 
            this.lblQtdMáximo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblQtdMáximo.AutoSize = true;
            this.lblQtdMáximo.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdMáximo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblQtdMáximo.Location = new System.Drawing.Point(362, 72);
            this.lblQtdMáximo.Name = "lblQtdMáximo";
            this.lblQtdMáximo.Size = new System.Drawing.Size(152, 19);
            this.lblQtdMáximo.TabIndex = 651;
            this.lblQtdMáximo.Text = "Quantidade Máxima:\r\n";
            // 
            // cboTipo
            // 
            this.cboTipo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboTipo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboTipo.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(53, 70);
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
            this.lblTipo.Location = new System.Drawing.Point(4, 72);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(43, 19);
            this.lblTipo.TabIndex = 649;
            this.lblTipo.Text = "Tipo:";
            // 
            // txtLocal
            // 
            this.txtLocal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLocal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtLocal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLocal.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocal.Location = new System.Drawing.Point(63, 38);
            this.txtLocal.MaxLength = 32;
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(644, 23);
            this.txtLocal.TabIndex = 648;
            // 
            // lblLocal
            // 
            this.lblLocal.AutoSize = true;
            this.lblLocal.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblLocal.Location = new System.Drawing.Point(3, 40);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(54, 19);
            this.lblLocal.TabIndex = 647;
            this.lblLocal.Text = "Nome:";
            // 
            // btnDeletar
            // 
            this.btnDeletar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDeletar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDeletar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletar.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletar.ForeColor = System.Drawing.Color.Black;
            this.btnDeletar.Location = new System.Drawing.Point(591, 105);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(107, 30);
            this.btnDeletar.TabIndex = 644;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = false;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // dataGridView5
            // 
            this.dataGridView5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView5.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Location = new System.Drawing.Point(1, 97);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.Size = new System.Drawing.Size(709, 2);
            this.dataGridView5.TabIndex = 626;
            // 
            // dataGridView3
            // 
            this.dataGridView3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView3.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(1, 65);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(709, 2);
            this.dataGridView3.TabIndex = 625;
            // 
            // dataGridView6
            // 
            this.dataGridView6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView6.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Location = new System.Drawing.Point(354, 67);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.Size = new System.Drawing.Size(2, 30);
            this.dataGridView6.TabIndex = 599;
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
            // lblDeletarEstoque
            // 
            this.lblDeletarEstoque.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDeletarEstoque.AutoSize = true;
            this.lblDeletarEstoque.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeletarEstoque.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDeletarEstoque.Location = new System.Drawing.Point(252, 9);
            this.lblDeletarEstoque.Name = "lblDeletarEstoque";
            this.lblDeletarEstoque.Size = new System.Drawing.Size(207, 28);
            this.lblDeletarEstoque.TabIndex = 565;
            this.lblDeletarEstoque.Text = "Deletar Estoque";
            this.lblDeletarEstoque.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.dgvConsultarEstoque.Location = new System.Drawing.Point(3, 141);
            this.dgvConsultarEstoque.Name = "dgvConsultarEstoque";
            this.dgvConsultarEstoque.Size = new System.Drawing.Size(704, 274);
            this.dgvConsultarEstoque.TabIndex = 664;
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
            // frmDeleteInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(710, 459);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.lblDeletarEstoque);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDeleteInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete Inventory";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtdMáximo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarEstoque)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.NumericUpDown nudId;
        private System.Windows.Forms.Label lblID;
        public System.Windows.Forms.NumericUpDown nudQtdMáximo;
        private System.Windows.Forms.Label lblQtdMáximo;
        public System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Label lblTipo;
        protected System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.Label lblLocal;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblDeletarEstoque;
        private System.Windows.Forms.DataGridView dgvConsultarEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna4;
    }
}