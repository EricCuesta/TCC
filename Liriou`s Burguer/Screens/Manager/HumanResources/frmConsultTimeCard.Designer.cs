namespace Liriou_s_Burguer.Screens.Manager.HumanResources
{
    partial class frmConsultTimeCard
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
            this.imgFechar = new System.Windows.Forms.PictureBox();
            this.imgMinimizar = new System.Windows.Forms.PictureBox();
            this.MenuLiriousBurger = new System.Windows.Forms.MenuStrip();
            this.menuInício = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRH = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarFuncionárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarFuncionárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.demitirFuncionárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folhaDePagamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarCartãoDePontoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFinanceiro = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEstoque = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSuprimento = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblAlterarFuncionário = new System.Windows.Forms.Label();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.lblCargo = new System.Windows.Forms.Label();
            this.cboDepartamento = new System.Windows.Forms.ComboBox();
            this.dataGridView17 = new System.Windows.Forms.DataGridView();
            this.cboCargo = new System.Windows.Forms.ComboBox();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.lblDataDaFolha = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMinimizar)).BeginInit();
            this.MenuLiriousBurger.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.SuspendLayout();
            // 
            // imgFechar
            // 
            this.imgFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgFechar.BackColor = System.Drawing.Color.Transparent;
            this.imgFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgFechar.Image = global::Liriou_s_Burguer.Properties.Resources.Fechar;
            this.imgFechar.Location = new System.Drawing.Point(771, 31);
            this.imgFechar.Name = "imgFechar";
            this.imgFechar.Size = new System.Drawing.Size(25, 25);
            this.imgFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgFechar.TabIndex = 372;
            this.imgFechar.TabStop = false;
            // 
            // imgMinimizar
            // 
            this.imgMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.imgMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgMinimizar.Image = global::Liriou_s_Burguer.Properties.Resources.Minimizar;
            this.imgMinimizar.Location = new System.Drawing.Point(740, 31);
            this.imgMinimizar.Name = "imgMinimizar";
            this.imgMinimizar.Size = new System.Drawing.Size(25, 25);
            this.imgMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgMinimizar.TabIndex = 371;
            this.imgMinimizar.TabStop = false;
            // 
            // MenuLiriousBurger
            // 
            this.MenuLiriousBurger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.MenuLiriousBurger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MenuLiriousBurger.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuInício,
            this.menuRH,
            this.MenuFinanceiro,
            this.MenuEstoque,
            this.MenuSuprimento});
            this.MenuLiriousBurger.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.MenuLiriousBurger.Location = new System.Drawing.Point(0, 0);
            this.MenuLiriousBurger.Name = "MenuLiriousBurger";
            this.MenuLiriousBurger.Size = new System.Drawing.Size(800, 29);
            this.MenuLiriousBurger.TabIndex = 370;
            this.MenuLiriousBurger.Text = "Liriou`s Burguer";
            // 
            // menuInício
            // 
            this.menuInício.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuInício.ForeColor = System.Drawing.Color.White;
            this.menuInício.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuInício.ImageTransparentColor = System.Drawing.Color.Black;
            this.menuInício.Name = "menuInício";
            this.menuInício.Size = new System.Drawing.Size(63, 25);
            this.menuInício.Text = "Início";
            // 
            // menuRH
            // 
            this.menuRH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.menuRH.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarFuncionárioToolStripMenuItem,
            this.consultarFuncionárioToolStripMenuItem,
            this.demitirFuncionárioToolStripMenuItem,
            this.folhaDePagamentoToolStripMenuItem,
            this.consultarCartãoDePontoToolStripMenuItem});
            this.menuRH.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuRH.ForeColor = System.Drawing.Color.White;
            this.menuRH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuRH.Name = "menuRH";
            this.menuRH.Size = new System.Drawing.Size(166, 25);
            this.menuRH.Text = "Recursos Humanos";
            // 
            // cadastrarFuncionárioToolStripMenuItem
            // 
            this.cadastrarFuncionárioToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.cadastrarFuncionárioToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.cadastrarFuncionárioToolStripMenuItem.Name = "cadastrarFuncionárioToolStripMenuItem";
            this.cadastrarFuncionárioToolStripMenuItem.Size = new System.Drawing.Size(291, 26);
            this.cadastrarFuncionárioToolStripMenuItem.Text = "Cadastrar Funcionário";
            // 
            // consultarFuncionárioToolStripMenuItem
            // 
            this.consultarFuncionárioToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.consultarFuncionárioToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.consultarFuncionárioToolStripMenuItem.Name = "consultarFuncionárioToolStripMenuItem";
            this.consultarFuncionárioToolStripMenuItem.Size = new System.Drawing.Size(291, 26);
            this.consultarFuncionárioToolStripMenuItem.Text = "Consultar Funcionário";
            // 
            // demitirFuncionárioToolStripMenuItem
            // 
            this.demitirFuncionárioToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.demitirFuncionárioToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.demitirFuncionárioToolStripMenuItem.Name = "demitirFuncionárioToolStripMenuItem";
            this.demitirFuncionárioToolStripMenuItem.Size = new System.Drawing.Size(291, 26);
            this.demitirFuncionárioToolStripMenuItem.Text = "Demitir Funcionário";
            // 
            // folhaDePagamentoToolStripMenuItem
            // 
            this.folhaDePagamentoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.folhaDePagamentoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.folhaDePagamentoToolStripMenuItem.Name = "folhaDePagamentoToolStripMenuItem";
            this.folhaDePagamentoToolStripMenuItem.Size = new System.Drawing.Size(291, 26);
            this.folhaDePagamentoToolStripMenuItem.Text = "Folha de Pagamento";
            // 
            // consultarCartãoDePontoToolStripMenuItem
            // 
            this.consultarCartãoDePontoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.consultarCartãoDePontoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.consultarCartãoDePontoToolStripMenuItem.Name = "consultarCartãoDePontoToolStripMenuItem";
            this.consultarCartãoDePontoToolStripMenuItem.Size = new System.Drawing.Size(291, 26);
            this.consultarCartãoDePontoToolStripMenuItem.Text = "Consultar Cartão de Ponto";
            // 
            // MenuFinanceiro
            // 
            this.MenuFinanceiro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuFinanceiro.ForeColor = System.Drawing.Color.White;
            this.MenuFinanceiro.Name = "MenuFinanceiro";
            this.MenuFinanceiro.Size = new System.Drawing.Size(102, 25);
            this.MenuFinanceiro.Text = "Financeiro";
            // 
            // MenuEstoque
            // 
            this.MenuEstoque.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuEstoque.ForeColor = System.Drawing.Color.White;
            this.MenuEstoque.Name = "MenuEstoque";
            this.MenuEstoque.Size = new System.Drawing.Size(85, 25);
            this.MenuEstoque.Text = "Estoque";
            // 
            // MenuSuprimento
            // 
            this.MenuSuprimento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuSuprimento.ForeColor = System.Drawing.Color.White;
            this.MenuSuprimento.Name = "MenuSuprimento";
            this.MenuSuprimento.Size = new System.Drawing.Size(111, 25);
            this.MenuSuprimento.Text = "Suprimento";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 2);
            this.dataGridView1.TabIndex = 369;
            // 
            // lblAlterarFuncionário
            // 
            this.lblAlterarFuncionário.AutoSize = true;
            this.lblAlterarFuncionário.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlterarFuncionário.ForeColor = System.Drawing.Color.Black;
            this.lblAlterarFuncionário.Location = new System.Drawing.Point(250, 29);
            this.lblAlterarFuncionário.Name = "lblAlterarFuncionário";
            this.lblAlterarFuncionário.Size = new System.Drawing.Size(334, 28);
            this.lblAlterarFuncionário.TabIndex = 368;
            this.lblAlterarFuncionário.Text = "Consultar Cartão de Ponto";
            // 
            // txtRG
            // 
            this.txtRG.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRG.Location = new System.Drawing.Point(531, 64);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(257, 23);
            this.txtRG.TabIndex = 377;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.Location = new System.Drawing.Point(492, 66);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(33, 19);
            this.lblCPF.TabIndex = 376;
            this.lblCPF.Text = "RG:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(72, 64);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(406, 23);
            this.txtNome.TabIndex = 374;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(12, 66);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(54, 19);
            this.lblNome.TabIndex = 373;
            this.lblNome.Text = "Nome:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 91);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(800, 2);
            this.dataGridView2.TabIndex = 378;
            // 
            // dataGridView4
            // 
            this.dataGridView4.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(484, 61);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(2, 30);
            this.dataGridView4.TabIndex = 379;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Location = new System.Drawing.Point(310, 97);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(54, 19);
            this.lblCargo.TabIndex = 384;
            this.lblCargo.Text = "Cargo:";
            // 
            // cboDepartamento
            // 
            this.cboDepartamento.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepartamento.FormattingEnabled = true;
            this.cboDepartamento.Location = new System.Drawing.Point(53, 120);
            this.cboDepartamento.Name = "cboDepartamento";
            this.cboDepartamento.Size = new System.Drawing.Size(185, 23);
            this.cboDepartamento.TabIndex = 383;
            // 
            // dataGridView17
            // 
            this.dataGridView17.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView17.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView17.Location = new System.Drawing.Point(244, 93);
            this.dataGridView17.Name = "dataGridView17";
            this.dataGridView17.Size = new System.Drawing.Size(2, 62);
            this.dataGridView17.TabIndex = 382;
            // 
            // cboCargo
            // 
            this.cboCargo.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCargo.FormattingEnabled = true;
            this.cboCargo.Location = new System.Drawing.Point(251, 120);
            this.cboCargo.Name = "cboCargo";
            this.cboCargo.Size = new System.Drawing.Size(178, 23);
            this.cboCargo.TabIndex = 381;
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartamento.Location = new System.Drawing.Point(94, 98);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(113, 19);
            this.lblDepartamento.TabIndex = 380;
            this.lblDepartamento.Text = "Departamento:";
            // 
            // dataGridView3
            // 
            this.dataGridView3.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(-4, 155);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(800, 2);
            this.dataGridView3.TabIndex = 385;
            // 
            // dataGridView5
            // 
            this.dataGridView5.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Location = new System.Drawing.Point(484, 93);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.Size = new System.Drawing.Size(2, 62);
            this.dataGridView5.TabIndex = 386;
            // 
            // lblDataDaFolha
            // 
            this.lblDataDaFolha.AutoSize = true;
            this.lblDataDaFolha.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataDaFolha.Location = new System.Drawing.Point(492, 98);
            this.lblDataDaFolha.Name = "lblDataDaFolha";
            this.lblDataDaFolha.Size = new System.Drawing.Size(106, 19);
            this.lblDataDaFolha.TabIndex = 387;
            this.lblDataDaFolha.Text = "Data da Folha:";
            // 
            // frmConsultTimeCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.lblDataDaFolha);
            this.Controls.Add(this.dataGridView5);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.cboDepartamento);
            this.Controls.Add(this.dataGridView17);
            this.Controls.Add(this.cboCargo);
            this.Controls.Add(this.lblDepartamento);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.txtRG);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.imgFechar);
            this.Controls.Add(this.imgMinimizar);
            this.Controls.Add(this.MenuLiriousBurger);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblAlterarFuncionário);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConsultTimeCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consult Time Card";
            ((System.ComponentModel.ISupportInitialize)(this.imgFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMinimizar)).EndInit();
            this.MenuLiriousBurger.ResumeLayout(false);
            this.MenuLiriousBurger.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgFechar;
        private System.Windows.Forms.PictureBox imgMinimizar;
        private System.Windows.Forms.MenuStrip MenuLiriousBurger;
        private System.Windows.Forms.ToolStripMenuItem menuInício;
        private System.Windows.Forms.ToolStripMenuItem menuRH;
        private System.Windows.Forms.ToolStripMenuItem cadastrarFuncionárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarFuncionárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem demitirFuncionárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem folhaDePagamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarCartãoDePontoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuFinanceiro;
        private System.Windows.Forms.ToolStripMenuItem MenuEstoque;
        private System.Windows.Forms.ToolStripMenuItem MenuSuprimento;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblAlterarFuncionário;
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.ComboBox cboDepartamento;
        private System.Windows.Forms.DataGridView dataGridView17;
        private System.Windows.Forms.ComboBox cboCargo;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.Label lblDataDaFolha;
    }
}