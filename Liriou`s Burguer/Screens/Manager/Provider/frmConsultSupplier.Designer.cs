namespace Liriou_s_Burguer.Screens.Manager.Provider
{
    partial class frmConsultSupplier
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboTipoDePessoa = new System.Windows.Forms.ComboBox();
            this.dgvConsultarFornecedor = new System.Windows.Forms.DataGridView();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.lblConsultarFornecedor = new System.Windows.Forms.Label();
            this.Coluna1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarFornecedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.cboTipoDePessoa);
            this.panel.Controls.Add(this.dgvConsultarFornecedor);
            this.panel.Controls.Add(this.btnConsultar);
            this.panel.Controls.Add(this.txtNome);
            this.panel.Controls.Add(this.lblNome);
            this.panel.Controls.Add(this.dataGridView3);
            this.panel.Controls.Add(this.dataGridView1);
            this.panel.Controls.Add(this.dataGridView2);
            this.panel.Location = new System.Drawing.Point(1, 40);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(709, 418);
            this.panel.TabIndex = 570;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(361, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 19);
            this.label1.TabIndex = 657;
            this.label1.Text = "Tipo de Pessoa:";
            // 
            // cboTipoDePessoa
            // 
            this.cboTipoDePessoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboTipoDePessoa.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboTipoDePessoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoDePessoa.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboTipoDePessoa.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoDePessoa.FormattingEnabled = true;
            this.cboTipoDePessoa.Items.AddRange(new object[] {
            "Física",
            "Jurídica"});
            this.cboTipoDePessoa.Location = new System.Drawing.Point(481, 6);
            this.cboTipoDePessoa.MaxLength = 32;
            this.cboTipoDePessoa.Name = "cboTipoDePessoa";
            this.cboTipoDePessoa.Size = new System.Drawing.Size(224, 23);
            this.cboTipoDePessoa.TabIndex = 656;
            this.cboTipoDePessoa.SelectedIndexChanged += new System.EventHandler(this.cboTipoDePessoa_SelectedIndexChanged);
            // 
            // dgvConsultarFornecedor
            // 
            this.dgvConsultarFornecedor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(86)))), ((int)(((byte)(112)))));
            this.dgvConsultarFornecedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvConsultarFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultarFornecedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Coluna1,
            this.Coluna2,
            this.Coluna3,
            this.Coluna4,
            this.Coluna5,
            this.Coluna6,
            this.Coluna7,
            this.Coluna8,
            this.Coluna9,
            this.Coluna10,
            this.Coluna11,
            this.Coluna12});
            this.dgvConsultarFornecedor.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgvConsultarFornecedor.Location = new System.Drawing.Point(3, 77);
            this.dgvConsultarFornecedor.Name = "dgvConsultarFornecedor";
            this.dgvConsultarFornecedor.Size = new System.Drawing.Size(703, 338);
            this.dgvConsultarFornecedor.TabIndex = 651;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.Color.Black;
            this.btnConsultar.Location = new System.Drawing.Point(590, 41);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(107, 30);
            this.btnConsultar.TabIndex = 644;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
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
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
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
            // lblConsultarFornecedor
            // 
            this.lblConsultarFornecedor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblConsultarFornecedor.AutoSize = true;
            this.lblConsultarFornecedor.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultarFornecedor.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblConsultarFornecedor.Location = new System.Drawing.Point(218, 9);
            this.lblConsultarFornecedor.Name = "lblConsultarFornecedor";
            this.lblConsultarFornecedor.Size = new System.Drawing.Size(276, 28);
            this.lblConsultarFornecedor.TabIndex = 569;
            this.lblConsultarFornecedor.Text = "Consultar Fornecedor";
            this.lblConsultarFornecedor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Coluna1
            // 
            this.Coluna1.DataPropertyName = "id_provider";
            this.Coluna1.HeaderText = "ID";
            this.Coluna1.Name = "Coluna1";
            this.Coluna1.ReadOnly = true;
            // 
            // Coluna2
            // 
            this.Coluna2.DataPropertyName = "nm_provider";
            this.Coluna2.HeaderText = "Nome";
            this.Coluna2.Name = "Coluna2";
            this.Coluna2.ReadOnly = true;
            this.Coluna2.Width = 140;
            // 
            // Coluna3
            // 
            this.Coluna3.DataPropertyName = "nm_name";
            this.Coluna3.HeaderText = "Nome Fantásia";
            this.Coluna3.Name = "Coluna3";
            this.Coluna3.ReadOnly = true;
            this.Coluna3.Width = 140;
            // 
            // Coluna4
            // 
            this.Coluna4.DataPropertyName = "ds_typePerson";
            this.Coluna4.HeaderText = "Tipo de Pessoa";
            this.Coluna4.Name = "Coluna4";
            this.Coluna4.ReadOnly = true;
            this.Coluna4.Width = 120;
            // 
            // Coluna5
            // 
            this.Coluna5.DataPropertyName = "nr_identification";
            this.Coluna5.HeaderText = "Numeração";
            this.Coluna5.Name = "Coluna5";
            this.Coluna5.ReadOnly = true;
            this.Coluna5.Width = 120;
            // 
            // Coluna6
            // 
            this.Coluna6.DataPropertyName = "ds_state";
            this.Coluna6.HeaderText = "Estado";
            this.Coluna6.Name = "Coluna6";
            this.Coluna6.ReadOnly = true;
            this.Coluna6.Width = 120;
            // 
            // Coluna7
            // 
            this.Coluna7.DataPropertyName = "ds_cep";
            this.Coluna7.HeaderText = "CEP";
            this.Coluna7.Name = "Coluna7";
            this.Coluna7.ReadOnly = true;
            // 
            // Coluna8
            // 
            this.Coluna8.DataPropertyName = "ds_address";
            this.Coluna8.HeaderText = "Endereço";
            this.Coluna8.Name = "Coluna8";
            this.Coluna8.ReadOnly = true;
            this.Coluna8.Width = 120;
            // 
            // Coluna9
            // 
            this.Coluna9.DataPropertyName = "ds_note";
            this.Coluna9.HeaderText = "Complemento";
            this.Coluna9.Name = "Coluna9";
            this.Coluna9.ReadOnly = true;
            this.Coluna9.Width = 120;
            // 
            // Coluna10
            // 
            this.Coluna10.DataPropertyName = "nr_cellphone";
            this.Coluna10.HeaderText = "Celular";
            this.Coluna10.Name = "Coluna10";
            this.Coluna10.ReadOnly = true;
            // 
            // Coluna11
            // 
            this.Coluna11.DataPropertyName = "nr_tellphone";
            this.Coluna11.HeaderText = "Telefone";
            this.Coluna11.Name = "Coluna11";
            this.Coluna11.ReadOnly = true;
            // 
            // Coluna12
            // 
            this.Coluna12.DataPropertyName = "ds_email";
            this.Coluna12.HeaderText = "E-mail";
            this.Coluna12.Name = "Coluna12";
            this.Coluna12.ReadOnly = true;
            this.Coluna12.Width = 120;
            // 
            // frmConsultSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(710, 459);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.lblConsultarFornecedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConsultSupplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consult Supplier";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarFornecedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.DataGridView dgvConsultarFornecedor;
        private System.Windows.Forms.Button btnConsultar;
        protected System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label lblConsultarFornecedor;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cboTipoDePessoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna12;
    }
}