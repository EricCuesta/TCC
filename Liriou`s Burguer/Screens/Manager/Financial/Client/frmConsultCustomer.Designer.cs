namespace Liriou_s_Burguer.Screens.Manager.Financial.Client
{
    partial class frmConsultCustomer
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
            this.lblConsultarCliente = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.cboSexo = new System.Windows.Forms.ComboBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.mtxtAnoDeNascimento = new System.Windows.Forms.MaskedTextBox();
            this.lblNascimento = new System.Windows.Forms.Label();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.mtxtRG = new System.Windows.Forms.MaskedTextBox();
            this.lblRG = new System.Windows.Forms.Label();
            this.dgvConsultarProduto = new System.Windows.Forms.DataGridView();
            this.Coluna1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblConsultarCliente
            // 
            this.lblConsultarCliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblConsultarCliente.AutoSize = true;
            this.lblConsultarCliente.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultarCliente.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblConsultarCliente.Location = new System.Drawing.Point(242, 9);
            this.lblConsultarCliente.Name = "lblConsultarCliente";
            this.lblConsultarCliente.Size = new System.Drawing.Size(228, 28);
            this.lblConsultarCliente.TabIndex = 564;
            this.lblConsultarCliente.Text = "Consultar Cliente";
            this.lblConsultarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.Controls.Add(this.cboSexo);
            this.panel.Controls.Add(this.lblSexo);
            this.panel.Controls.Add(this.mtxtAnoDeNascimento);
            this.panel.Controls.Add(this.lblNascimento);
            this.panel.Controls.Add(this.dataGridView5);
            this.panel.Controls.Add(this.dataGridView4);
            this.panel.Controls.Add(this.mtxtRG);
            this.panel.Controls.Add(this.lblRG);
            this.panel.Controls.Add(this.dgvConsultarProduto);
            this.panel.Controls.Add(this.btnConsultar);
            this.panel.Controls.Add(this.txtNome);
            this.panel.Controls.Add(this.lblNome);
            this.panel.Controls.Add(this.dataGridView3);
            this.panel.Controls.Add(this.dataGridView1);
            this.panel.Controls.Add(this.dataGridView2);
            this.panel.Location = new System.Drawing.Point(1, 40);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(709, 418);
            this.panel.TabIndex = 568;
            // 
            // cboSexo
            // 
            this.cboSexo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboSexo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSexo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboSexo.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSexo.FormattingEnabled = true;
            this.cboSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.cboSexo.Location = new System.Drawing.Point(413, 38);
            this.cboSexo.MaxLength = 32;
            this.cboSexo.Name = "cboSexo";
            this.cboSexo.Size = new System.Drawing.Size(292, 23);
            this.cboSexo.TabIndex = 659;
            // 
            // lblSexo
            // 
            this.lblSexo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSexo.Location = new System.Drawing.Point(361, 40);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(46, 19);
            this.lblSexo.TabIndex = 658;
            this.lblSexo.Text = "Sexo:";
            // 
            // mtxtAnoDeNascimento
            // 
            this.mtxtAnoDeNascimento.Location = new System.Drawing.Point(153, 40);
            this.mtxtAnoDeNascimento.Mask = "0000";
            this.mtxtAnoDeNascimento.Name = "mtxtAnoDeNascimento";
            this.mtxtAnoDeNascimento.Size = new System.Drawing.Size(194, 20);
            this.mtxtAnoDeNascimento.TabIndex = 657;
            // 
            // lblNascimento
            // 
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNascimento.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNascimento.Location = new System.Drawing.Point(3, 40);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(144, 19);
            this.lblNascimento.TabIndex = 656;
            this.lblNascimento.Text = "Ano de nascimento:";
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
            this.dataGridView5.TabIndex = 655;
            // 
            // dataGridView4
            // 
            this.dataGridView4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView4.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(353, 35);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(2, 30);
            this.dataGridView4.TabIndex = 654;
            // 
            // mtxtRG
            // 
            this.mtxtRG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtxtRG.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mtxtRG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtxtRG.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtRG.Location = new System.Drawing.Point(400, 6);
            this.mtxtRG.Mask = "00.000.000-0";
            this.mtxtRG.Name = "mtxtRG";
            this.mtxtRG.Size = new System.Drawing.Size(305, 23);
            this.mtxtRG.TabIndex = 653;
            // 
            // lblRG
            // 
            this.lblRG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRG.AutoSize = true;
            this.lblRG.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRG.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblRG.Location = new System.Drawing.Point(361, 8);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(33, 19);
            this.lblRG.TabIndex = 652;
            this.lblRG.Text = "RG:";
            // 
            // dgvConsultarProduto
            // 
            this.dgvConsultarProduto.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(86)))), ((int)(((byte)(112)))));
            this.dgvConsultarProduto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvConsultarProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultarProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Coluna1,
            this.Coluna2,
            this.Coluna4,
            this.Coluna3,
            this.Coluna5,
            this.Coluna6,
            this.Coluna7,
            this.Coluna8,
            this.Coluna9,
            this.Coluna10,
            this.Coluna11,
            this.Coluna12,
            this.Coluna13});
            this.dgvConsultarProduto.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgvConsultarProduto.Location = new System.Drawing.Point(3, 109);
            this.dgvConsultarProduto.Name = "dgvConsultarProduto";
            this.dgvConsultarProduto.Size = new System.Drawing.Size(703, 306);
            this.dgvConsultarProduto.TabIndex = 651;
            // 
            // Coluna1
            // 
            this.Coluna1.HeaderText = "Nome";
            this.Coluna1.Name = "Coluna1";
            this.Coluna1.ReadOnly = true;
            this.Coluna1.Width = 140;
            // 
            // Coluna2
            // 
            this.Coluna2.HeaderText = "Sobrenome";
            this.Coluna2.Name = "Coluna2";
            this.Coluna2.ReadOnly = true;
            this.Coluna2.Width = 140;
            // 
            // Coluna4
            // 
            this.Coluna4.HeaderText = "RG";
            this.Coluna4.Name = "Coluna4";
            this.Coluna4.ReadOnly = true;
            this.Coluna4.Width = 120;
            // 
            // Coluna3
            // 
            this.Coluna3.HeaderText = "CPF";
            this.Coluna3.Name = "Coluna3";
            this.Coluna3.ReadOnly = true;
            this.Coluna3.Width = 120;
            // 
            // Coluna5
            // 
            this.Coluna5.HeaderText = "Sexo";
            this.Coluna5.Name = "Coluna5";
            this.Coluna5.ReadOnly = true;
            this.Coluna5.Width = 80;
            // 
            // Coluna6
            // 
            this.Coluna6.HeaderText = "Nascimento";
            this.Coluna6.Name = "Coluna6";
            this.Coluna6.ReadOnly = true;
            // 
            // Coluna7
            // 
            this.Coluna7.HeaderText = "Estado";
            this.Coluna7.Name = "Coluna7";
            this.Coluna7.ReadOnly = true;
            this.Coluna7.Width = 120;
            // 
            // Coluna8
            // 
            this.Coluna8.HeaderText = "CEP";
            this.Coluna8.Name = "Coluna8";
            this.Coluna8.ReadOnly = true;
            // 
            // Coluna9
            // 
            this.Coluna9.HeaderText = "Endereço";
            this.Coluna9.Name = "Coluna9";
            this.Coluna9.ReadOnly = true;
            this.Coluna9.Width = 120;
            // 
            // Coluna10
            // 
            this.Coluna10.HeaderText = "Complemento";
            this.Coluna10.Name = "Coluna10";
            this.Coluna10.ReadOnly = true;
            this.Coluna10.Width = 120;
            // 
            // Coluna11
            // 
            this.Coluna11.HeaderText = "Celular";
            this.Coluna11.Name = "Coluna11";
            this.Coluna11.ReadOnly = true;
            // 
            // Coluna12
            // 
            this.Coluna12.HeaderText = "Telefone";
            this.Coluna12.Name = "Coluna12";
            this.Coluna12.ReadOnly = true;
            // 
            // Coluna13
            // 
            this.Coluna13.HeaderText = "E-mail";
            this.Coluna13.Name = "Coluna13";
            this.Coluna13.ReadOnly = true;
            this.Coluna13.Width = 120;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(590, 73);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(107, 30);
            this.btnConsultar.TabIndex = 644;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
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
            // frmConsultCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(710, 459);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.lblConsultarCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConsultCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consult Customer";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConsultarCliente;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.DataGridView dgvConsultarProduto;
        private System.Windows.Forms.Button btnConsultar;
        protected System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.DataGridView dataGridView4;
        public System.Windows.Forms.MaskedTextBox mtxtRG;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.MaskedTextBox mtxtAnoDeNascimento;
        private System.Windows.Forms.Label lblNascimento;
        public System.Windows.Forms.ComboBox cboSexo;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna13;
    }
}