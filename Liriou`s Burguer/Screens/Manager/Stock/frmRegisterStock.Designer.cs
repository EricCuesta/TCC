namespace Liriou_s_Burguer.Screens.Manager.Stock
{
    partial class frmRegisterStock
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
            this.dgvConsultarEstoque = new System.Windows.Forms.DataGridView();
            this.nudQtdMáximo = new System.Windows.Forms.NumericUpDown();
            this.lblQtdMáximo = new System.Windows.Forms.Label();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblCadastrarEstoque = new System.Windows.Forms.Label();
            this.Coluna1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtdMáximo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.Controls.Add(this.dgvConsultarEstoque);
            this.panel.Controls.Add(this.nudQtdMáximo);
            this.panel.Controls.Add(this.lblQtdMáximo);
            this.panel.Controls.Add(this.cboTipo);
            this.panel.Controls.Add(this.lblTipo);
            this.panel.Controls.Add(this.txtNome);
            this.panel.Controls.Add(this.lblNome);
            this.panel.Controls.Add(this.btnCadastrar);
            this.panel.Controls.Add(this.dataGridView5);
            this.panel.Controls.Add(this.dataGridView3);
            this.panel.Controls.Add(this.dataGridView6);
            this.panel.Controls.Add(this.dataGridView1);
            this.panel.Location = new System.Drawing.Point(1, 40);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(709, 418);
            this.panel.TabIndex = 566;
            // 
            // dgvConsultarEstoque
            // 
            this.dgvConsultarEstoque.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(86)))), ((int)(((byte)(112)))));
            this.dgvConsultarEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultarEstoque.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Coluna1,
            this.Coluna2,
            this.Coluna3});
            this.dgvConsultarEstoque.Location = new System.Drawing.Point(11, 109);
            this.dgvConsultarEstoque.Name = "dgvConsultarEstoque";
            this.dgvConsultarEstoque.Size = new System.Drawing.Size(686, 298);
            this.dgvConsultarEstoque.TabIndex = 655;
            // 
            // nudQtdMáximo
            // 
            this.nudQtdMáximo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nudQtdMáximo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.nudQtdMáximo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudQtdMáximo.Location = new System.Drawing.Point(519, 40);
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
            this.lblQtdMáximo.Location = new System.Drawing.Point(361, 40);
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
            this.cboTipo.Location = new System.Drawing.Point(52, 38);
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
            this.lblTipo.Location = new System.Drawing.Point(3, 39);
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
            this.txtNome.Size = new System.Drawing.Size(643, 23);
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
            // btnCadastrar
            // 
            this.btnCadastrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(590, 73);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(107, 30);
            this.btnCadastrar.TabIndex = 644;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // dataGridView5
            // 
            this.dataGridView5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView5.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Location = new System.Drawing.Point(0, 65);
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
            this.dataGridView3.Location = new System.Drawing.Point(0, 33);
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
            this.dataGridView6.Location = new System.Drawing.Point(353, 35);
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
            this.dataGridView1.Location = new System.Drawing.Point(0, 1);
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
            this.lblCadastrarEstoque.Location = new System.Drawing.Point(237, 9);
            this.lblCadastrarEstoque.Name = "lblCadastrarEstoque";
            this.lblCadastrarEstoque.Size = new System.Drawing.Size(237, 28);
            this.lblCadastrarEstoque.TabIndex = 565;
            this.lblCadastrarEstoque.Text = "Cadastrar Estoque";
            this.lblCadastrarEstoque.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Coluna1
            // 
            this.Coluna1.HeaderText = "Nome";
            this.Coluna1.Name = "Coluna1";
            this.Coluna1.ReadOnly = true;
            this.Coluna1.Width = 220;
            // 
            // Coluna2
            // 
            this.Coluna2.HeaderText = "Tipo";
            this.Coluna2.Name = "Coluna2";
            this.Coluna2.ReadOnly = true;
            this.Coluna2.Width = 220;
            // 
            // Coluna3
            // 
            this.Coluna3.HeaderText = "Quantidade Máxima";
            this.Coluna3.Name = "Coluna3";
            this.Coluna3.ReadOnly = true;
            this.Coluna3.Width = 203;
            // 
            // frmRegisterStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(710, 459);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.lblCadastrarEstoque);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRegisterStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register Stock";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtdMáximo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.DataGridView dgvConsultarEstoque;
        public System.Windows.Forms.NumericUpDown nudQtdMáximo;
        private System.Windows.Forms.Label lblQtdMáximo;
        public System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Label lblTipo;
        protected System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblCadastrarEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna3;
    }
}