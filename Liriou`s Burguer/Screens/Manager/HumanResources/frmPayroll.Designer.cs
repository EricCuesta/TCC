namespace Liriou_s_Burguer.Screens.Manager.HumanResources
{
    partial class frmPayroll
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
            this.label1 = new System.Windows.Forms.Label();
            this.MenuLiriousBurger = new System.Windows.Forms.MenuStrip();
            this.menuInício = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRH = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarFuncionárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarFuncionárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarFuncionárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.demitirFuncionárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarCartãoDePontoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFinanceiro = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEstoque = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSuprimento = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnGerarFolha = new System.Windows.Forms.Button();
            this.lblLíquido = new System.Windows.Forms.Label();
            this.lblLíquido1 = new System.Windows.Forms.Label();
            this.lblBruto = new System.Windows.Forms.Label();
            this.lblBruto1 = new System.Windows.Forms.Label();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.groupProventos = new System.Windows.Forms.GroupBox();
            this.lblNulo5 = new System.Windows.Forms.Label();
            this.lblNulo4 = new System.Windows.Forms.Label();
            this.lblNulo3 = new System.Windows.Forms.Label();
            this.lblNulo6 = new System.Windows.Forms.Label();
            this.lblNulo7 = new System.Windows.Forms.Label();
            this.lblNulo8 = new System.Windows.Forms.Label();
            this.lblDependência = new System.Windows.Forms.Label();
            this.lblHorasExtras = new System.Windows.Forms.Label();
            this.lblSalário = new System.Windows.Forms.Label();
            this.groupDespesas = new System.Windows.Forms.GroupBox();
            this.lblPA = new System.Windows.Forms.Label();
            this.lblNulo2 = new System.Windows.Forms.Label();
            this.lblIR = new System.Windows.Forms.Label();
            this.lblINSS = new System.Windows.Forms.Label();
            this.lblFGTS = new System.Windows.Forms.Label();
            this.lblNulo1 = new System.Windows.Forms.Label();
            this.lblValeAlimentação = new System.Windows.Forms.Label();
            this.lblValeTransporte = new System.Windows.Forms.Label();
            this.lblNulo = new System.Windows.Forms.Label();
            this.groupItens = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblDependência1 = new System.Windows.Forms.Label();
            this.lblIR1 = new System.Windows.Forms.Label();
            this.lblINSS1 = new System.Windows.Forms.Label();
            this.lblFGTS1 = new System.Windows.Forms.Label();
            this.lblValeAlimentação1 = new System.Windows.Forms.Label();
            this.lblValeTransporte1 = new System.Windows.Forms.Label();
            this.lblHorasExtras1 = new System.Windows.Forms.Label();
            this.lblSalário1 = new System.Windows.Forms.Label();
            this.lblNomeDoFuncionário = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.lblRG = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblFolhaDePagamento = new System.Windows.Forms.Label();
            this.imgMinimizar = new System.Windows.Forms.PictureBox();
            this.imgFechar = new System.Windows.Forms.PictureBox();
            this.MenuLiriousBurger.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.groupProventos.SuspendLayout();
            this.groupDespesas.SuspendLayout();
            this.groupItens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFechar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(513, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 19);
            this.label1.TabIndex = 250;
            this.label1.Text = " __ __ __ __ __ __ __ __ __ __ __ __ __ __";
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
            this.MenuLiriousBurger.TabIndex = 249;
            this.MenuLiriousBurger.Text = "Liriou`s Burguer";
            // 
            // menuInício
            // 
            this.menuInício.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuInício.ForeColor = System.Drawing.Color.White;
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
            this.alterarFuncionárioToolStripMenuItem,
            this.demitirFuncionárioToolStripMenuItem,
            this.consultarCartãoDePontoToolStripMenuItem});
            this.menuRH.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuRH.ForeColor = System.Drawing.Color.White;
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
            // alterarFuncionárioToolStripMenuItem
            // 
            this.alterarFuncionárioToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.alterarFuncionárioToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.alterarFuncionárioToolStripMenuItem.Name = "alterarFuncionárioToolStripMenuItem";
            this.alterarFuncionárioToolStripMenuItem.Size = new System.Drawing.Size(291, 26);
            this.alterarFuncionárioToolStripMenuItem.Text = "Alterar Funcionário";
            // 
            // demitirFuncionárioToolStripMenuItem
            // 
            this.demitirFuncionárioToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.demitirFuncionárioToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.demitirFuncionárioToolStripMenuItem.Name = "demitirFuncionárioToolStripMenuItem";
            this.demitirFuncionárioToolStripMenuItem.Size = new System.Drawing.Size(291, 26);
            this.demitirFuncionárioToolStripMenuItem.Text = "Demitir Funcionário";
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
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(221, 102);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(134, 30);
            this.btnCalcular.TabIndex = 248;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            // 
            // btnGerarFolha
            // 
            this.btnGerarFolha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGerarFolha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGerarFolha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerarFolha.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarFolha.Location = new System.Drawing.Point(441, 102);
            this.btnGerarFolha.Name = "btnGerarFolha";
            this.btnGerarFolha.Size = new System.Drawing.Size(134, 30);
            this.btnGerarFolha.TabIndex = 247;
            this.btnGerarFolha.Text = "Gerar Folha";
            this.btnGerarFolha.UseVisualStyleBackColor = false;
            // 
            // lblLíquido
            // 
            this.lblLíquido.AutoSize = true;
            this.lblLíquido.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLíquido.Location = new System.Drawing.Point(591, 438);
            this.lblLíquido.Name = "lblLíquido";
            this.lblLíquido.Size = new System.Drawing.Size(138, 19);
            this.lblLíquido.TabIndex = 246;
            this.lblLíquido.Text = "R$___ ___ , ___ ___";
            // 
            // lblLíquido1
            // 
            this.lblLíquido1.AutoSize = true;
            this.lblLíquido1.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLíquido1.Location = new System.Drawing.Point(520, 440);
            this.lblLíquido1.Name = "lblLíquido1";
            this.lblLíquido1.Size = new System.Drawing.Size(65, 16);
            this.lblLíquido1.TabIndex = 245;
            this.lblLíquido1.Text = "Líquido:";
            // 
            // lblBruto
            // 
            this.lblBruto.AutoSize = true;
            this.lblBruto.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBruto.Location = new System.Drawing.Point(134, 438);
            this.lblBruto.Name = "lblBruto";
            this.lblBruto.Size = new System.Drawing.Size(138, 19);
            this.lblBruto.TabIndex = 244;
            this.lblBruto.Text = "R$___ ___ , ___ ___";
            // 
            // lblBruto1
            // 
            this.lblBruto1.AutoSize = true;
            this.lblBruto1.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBruto1.Location = new System.Drawing.Point(76, 440);
            this.lblBruto1.Name = "lblBruto1";
            this.lblBruto1.Size = new System.Drawing.Size(52, 16);
            this.lblBruto1.TabIndex = 243;
            this.lblBruto1.Text = "Bruto:";
            // 
            // dataGridView6
            // 
            this.dataGridView6.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Location = new System.Drawing.Point(69, 463);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.Size = new System.Drawing.Size(660, 2);
            this.dataGridView6.TabIndex = 242;
            // 
            // dataGridView4
            // 
            this.dataGridView4.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(69, 431);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(660, 2);
            this.dataGridView4.TabIndex = 241;
            // 
            // groupProventos
            // 
            this.groupProventos.Controls.Add(this.lblNulo5);
            this.groupProventos.Controls.Add(this.lblNulo4);
            this.groupProventos.Controls.Add(this.lblNulo3);
            this.groupProventos.Controls.Add(this.lblNulo6);
            this.groupProventos.Controls.Add(this.lblNulo7);
            this.groupProventos.Controls.Add(this.lblNulo8);
            this.groupProventos.Controls.Add(this.lblDependência);
            this.groupProventos.Controls.Add(this.lblHorasExtras);
            this.groupProventos.Controls.Add(this.lblSalário);
            this.groupProventos.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupProventos.Location = new System.Drawing.Point(512, 148);
            this.groupProventos.Name = "groupProventos";
            this.groupProventos.Size = new System.Drawing.Size(217, 267);
            this.groupProventos.TabIndex = 240;
            this.groupProventos.TabStop = false;
            this.groupProventos.Text = "Proventos";
            // 
            // lblNulo5
            // 
            this.lblNulo5.AutoSize = true;
            this.lblNulo5.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNulo5.Location = new System.Drawing.Point(104, 132);
            this.lblNulo5.Name = "lblNulo5";
            this.lblNulo5.Size = new System.Drawing.Size(25, 19);
            this.lblNulo5.TabIndex = 192;
            this.lblNulo5.Text = "----";
            // 
            // lblNulo4
            // 
            this.lblNulo4.AutoSize = true;
            this.lblNulo4.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNulo4.Location = new System.Drawing.Point(104, 94);
            this.lblNulo4.Name = "lblNulo4";
            this.lblNulo4.Size = new System.Drawing.Size(25, 19);
            this.lblNulo4.TabIndex = 191;
            this.lblNulo4.Text = "----";
            // 
            // lblNulo3
            // 
            this.lblNulo3.AutoSize = true;
            this.lblNulo3.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNulo3.Location = new System.Drawing.Point(104, 72);
            this.lblNulo3.Name = "lblNulo3";
            this.lblNulo3.Size = new System.Drawing.Size(25, 19);
            this.lblNulo3.TabIndex = 190;
            this.lblNulo3.Text = "----";
            // 
            // lblNulo6
            // 
            this.lblNulo6.AutoSize = true;
            this.lblNulo6.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNulo6.Location = new System.Drawing.Point(104, 154);
            this.lblNulo6.Name = "lblNulo6";
            this.lblNulo6.Size = new System.Drawing.Size(25, 19);
            this.lblNulo6.TabIndex = 189;
            this.lblNulo6.Text = "----";
            // 
            // lblNulo7
            // 
            this.lblNulo7.AutoSize = true;
            this.lblNulo7.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNulo7.Location = new System.Drawing.Point(104, 176);
            this.lblNulo7.Name = "lblNulo7";
            this.lblNulo7.Size = new System.Drawing.Size(25, 19);
            this.lblNulo7.TabIndex = 188;
            this.lblNulo7.Text = "----";
            // 
            // lblNulo8
            // 
            this.lblNulo8.AutoSize = true;
            this.lblNulo8.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNulo8.Location = new System.Drawing.Point(104, 198);
            this.lblNulo8.Name = "lblNulo8";
            this.lblNulo8.Size = new System.Drawing.Size(25, 19);
            this.lblNulo8.TabIndex = 185;
            this.lblNulo8.Text = "----";
            // 
            // lblDependência
            // 
            this.lblDependência.AutoSize = true;
            this.lblDependência.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDependência.Location = new System.Drawing.Point(39, 236);
            this.lblDependência.Name = "lblDependência";
            this.lblDependência.Size = new System.Drawing.Size(138, 19);
            this.lblDependência.TabIndex = 187;
            this.lblDependência.Text = "R$___ ___ , ___ ___";
            // 
            // lblHorasExtras
            // 
            this.lblHorasExtras.AutoSize = true;
            this.lblHorasExtras.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorasExtras.Location = new System.Drawing.Point(39, 51);
            this.lblHorasExtras.Name = "lblHorasExtras";
            this.lblHorasExtras.Size = new System.Drawing.Size(138, 19);
            this.lblHorasExtras.TabIndex = 186;
            this.lblHorasExtras.Text = "R$___ ___ , ___ ___";
            // 
            // lblSalário
            // 
            this.lblSalário.AutoSize = true;
            this.lblSalário.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalário.Location = new System.Drawing.Point(39, 30);
            this.lblSalário.Name = "lblSalário";
            this.lblSalário.Size = new System.Drawing.Size(138, 19);
            this.lblSalário.TabIndex = 185;
            this.lblSalário.Text = "R$___ ___ , ___ ___";
            // 
            // groupDespesas
            // 
            this.groupDespesas.Controls.Add(this.lblPA);
            this.groupDespesas.Controls.Add(this.lblNulo2);
            this.groupDespesas.Controls.Add(this.lblIR);
            this.groupDespesas.Controls.Add(this.lblINSS);
            this.groupDespesas.Controls.Add(this.lblFGTS);
            this.groupDespesas.Controls.Add(this.lblNulo1);
            this.groupDespesas.Controls.Add(this.lblValeAlimentação);
            this.groupDespesas.Controls.Add(this.lblValeTransporte);
            this.groupDespesas.Controls.Add(this.lblNulo);
            this.groupDespesas.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupDespesas.Location = new System.Drawing.Point(292, 148);
            this.groupDespesas.Name = "groupDespesas";
            this.groupDespesas.Size = new System.Drawing.Size(217, 267);
            this.groupDespesas.TabIndex = 239;
            this.groupDespesas.TabStop = false;
            this.groupDespesas.Text = "Despesas";
            // 
            // lblPA
            // 
            this.lblPA.AutoSize = true;
            this.lblPA.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPA.Location = new System.Drawing.Point(40, 154);
            this.lblPA.Name = "lblPA";
            this.lblPA.Size = new System.Drawing.Size(138, 19);
            this.lblPA.TabIndex = 185;
            this.lblPA.Text = "R$___ ___ , ___ ___";
            // 
            // lblNulo2
            // 
            this.lblNulo2.AutoSize = true;
            this.lblNulo2.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNulo2.Location = new System.Drawing.Point(97, 236);
            this.lblNulo2.Name = "lblNulo2";
            this.lblNulo2.Size = new System.Drawing.Size(25, 19);
            this.lblNulo2.TabIndex = 184;
            this.lblNulo2.Text = "----";
            // 
            // lblIR
            // 
            this.lblIR.AutoSize = true;
            this.lblIR.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIR.Location = new System.Drawing.Point(40, 132);
            this.lblIR.Name = "lblIR";
            this.lblIR.Size = new System.Drawing.Size(138, 19);
            this.lblIR.TabIndex = 183;
            this.lblIR.Text = "R$___ ___ , ___ ___";
            // 
            // lblINSS
            // 
            this.lblINSS.AutoSize = true;
            this.lblINSS.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblINSS.Location = new System.Drawing.Point(40, 176);
            this.lblINSS.Name = "lblINSS";
            this.lblINSS.Size = new System.Drawing.Size(138, 19);
            this.lblINSS.TabIndex = 182;
            this.lblINSS.Text = "R$___ ___ , ___ ___";
            // 
            // lblFGTS
            // 
            this.lblFGTS.AutoSize = true;
            this.lblFGTS.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFGTS.Location = new System.Drawing.Point(40, 198);
            this.lblFGTS.Name = "lblFGTS";
            this.lblFGTS.Size = new System.Drawing.Size(138, 19);
            this.lblFGTS.TabIndex = 181;
            this.lblFGTS.Text = "R$___ ___ , ___ ___";
            // 
            // lblNulo1
            // 
            this.lblNulo1.AutoSize = true;
            this.lblNulo1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNulo1.Location = new System.Drawing.Point(97, 51);
            this.lblNulo1.Name = "lblNulo1";
            this.lblNulo1.Size = new System.Drawing.Size(25, 19);
            this.lblNulo1.TabIndex = 180;
            this.lblNulo1.Text = "----";
            // 
            // lblValeAlimentação
            // 
            this.lblValeAlimentação.AutoSize = true;
            this.lblValeAlimentação.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValeAlimentação.Location = new System.Drawing.Point(40, 94);
            this.lblValeAlimentação.Name = "lblValeAlimentação";
            this.lblValeAlimentação.Size = new System.Drawing.Size(138, 19);
            this.lblValeAlimentação.TabIndex = 179;
            this.lblValeAlimentação.Text = "R$___ ___ , ___ ___";
            // 
            // lblValeTransporte
            // 
            this.lblValeTransporte.AutoSize = true;
            this.lblValeTransporte.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValeTransporte.Location = new System.Drawing.Point(40, 72);
            this.lblValeTransporte.Name = "lblValeTransporte";
            this.lblValeTransporte.Size = new System.Drawing.Size(138, 19);
            this.lblValeTransporte.TabIndex = 178;
            this.lblValeTransporte.Text = "R$___ ___ , ___ ___";
            // 
            // lblNulo
            // 
            this.lblNulo.AutoSize = true;
            this.lblNulo.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNulo.Location = new System.Drawing.Point(97, 30);
            this.lblNulo.Name = "lblNulo";
            this.lblNulo.Size = new System.Drawing.Size(25, 19);
            this.lblNulo.TabIndex = 176;
            this.lblNulo.Text = "----";
            // 
            // groupItens
            // 
            this.groupItens.Controls.Add(this.label10);
            this.groupItens.Controls.Add(this.lblDependência1);
            this.groupItens.Controls.Add(this.lblIR1);
            this.groupItens.Controls.Add(this.lblINSS1);
            this.groupItens.Controls.Add(this.lblFGTS1);
            this.groupItens.Controls.Add(this.lblValeAlimentação1);
            this.groupItens.Controls.Add(this.lblValeTransporte1);
            this.groupItens.Controls.Add(this.lblHorasExtras1);
            this.groupItens.Controls.Add(this.lblSalário1);
            this.groupItens.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupItens.Location = new System.Drawing.Point(69, 148);
            this.groupItens.Name = "groupItens";
            this.groupItens.Size = new System.Drawing.Size(217, 267);
            this.groupItens.TabIndex = 238;
            this.groupItens.TabStop = false;
            this.groupItens.Text = "Itens";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(9, 154);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 19);
            this.label10.TabIndex = 176;
            this.label10.Text = "PA";
            // 
            // lblDependência1
            // 
            this.lblDependência1.AutoSize = true;
            this.lblDependência1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDependência1.Location = new System.Drawing.Point(9, 236);
            this.lblDependência1.Name = "lblDependência1";
            this.lblDependência1.Size = new System.Drawing.Size(97, 19);
            this.lblDependência1.TabIndex = 175;
            this.lblDependência1.Text = "Dependência";
            // 
            // lblIR1
            // 
            this.lblIR1.AutoSize = true;
            this.lblIR1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIR1.Location = new System.Drawing.Point(9, 132);
            this.lblIR1.Name = "lblIR1";
            this.lblIR1.Size = new System.Drawing.Size(23, 19);
            this.lblIR1.TabIndex = 174;
            this.lblIR1.Text = "IR";
            // 
            // lblINSS1
            // 
            this.lblINSS1.AutoSize = true;
            this.lblINSS1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblINSS1.Location = new System.Drawing.Point(9, 176);
            this.lblINSS1.Name = "lblINSS1";
            this.lblINSS1.Size = new System.Drawing.Size(40, 19);
            this.lblINSS1.TabIndex = 173;
            this.lblINSS1.Text = "INSS";
            // 
            // lblFGTS1
            // 
            this.lblFGTS1.AutoSize = true;
            this.lblFGTS1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFGTS1.Location = new System.Drawing.Point(9, 198);
            this.lblFGTS1.Name = "lblFGTS1";
            this.lblFGTS1.Size = new System.Drawing.Size(43, 19);
            this.lblFGTS1.TabIndex = 172;
            this.lblFGTS1.Text = "FGTS";
            // 
            // lblValeAlimentação1
            // 
            this.lblValeAlimentação1.AutoSize = true;
            this.lblValeAlimentação1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValeAlimentação1.Location = new System.Drawing.Point(6, 94);
            this.lblValeAlimentação1.Name = "lblValeAlimentação1";
            this.lblValeAlimentação1.Size = new System.Drawing.Size(126, 19);
            this.lblValeAlimentação1.TabIndex = 171;
            this.lblValeAlimentação1.Text = "Vale Alimentação";
            // 
            // lblValeTransporte1
            // 
            this.lblValeTransporte1.AutoSize = true;
            this.lblValeTransporte1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValeTransporte1.Location = new System.Drawing.Point(6, 72);
            this.lblValeTransporte1.Name = "lblValeTransporte1";
            this.lblValeTransporte1.Size = new System.Drawing.Size(116, 19);
            this.lblValeTransporte1.TabIndex = 170;
            this.lblValeTransporte1.Text = "Vale Transporte";
            // 
            // lblHorasExtras1
            // 
            this.lblHorasExtras1.AutoSize = true;
            this.lblHorasExtras1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorasExtras1.Location = new System.Drawing.Point(6, 51);
            this.lblHorasExtras1.Name = "lblHorasExtras1";
            this.lblHorasExtras1.Size = new System.Drawing.Size(95, 19);
            this.lblHorasExtras1.TabIndex = 169;
            this.lblHorasExtras1.Text = "Horas Extras";
            // 
            // lblSalário1
            // 
            this.lblSalário1.AutoSize = true;
            this.lblSalário1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalário1.Location = new System.Drawing.Point(6, 30);
            this.lblSalário1.Name = "lblSalário1";
            this.lblSalário1.Size = new System.Drawing.Size(55, 19);
            this.lblSalário1.TabIndex = 168;
            this.lblSalário1.Text = "Salário";
            // 
            // lblNomeDoFuncionário
            // 
            this.lblNomeDoFuncionário.AutoSize = true;
            this.lblNomeDoFuncionário.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeDoFuncionário.Location = new System.Drawing.Point(408, 66);
            this.lblNomeDoFuncionário.Name = "lblNomeDoFuncionário";
            this.lblNomeDoFuncionário.Size = new System.Drawing.Size(95, 19);
            this.lblNomeDoFuncionário.TabIndex = 237;
            this.lblNomeDoFuncionário.Text = "Funcionário:";
            // 
            // dataGridView3
            // 
            this.dataGridView3.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(0, 91);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(800, 2);
            this.dataGridView3.TabIndex = 236;
            // 
            // txtRG
            // 
            this.txtRG.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRG.Location = new System.Drawing.Point(51, 64);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(341, 23);
            this.txtRG.TabIndex = 235;
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRG.Location = new System.Drawing.Point(12, 66);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(33, 19);
            this.lblRG.TabIndex = 234;
            this.lblRG.Text = "RG:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(400, 61);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(2, 30);
            this.dataGridView2.TabIndex = 233;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 2);
            this.dataGridView1.TabIndex = 232;
            // 
            // lblFolhaDePagamento
            // 
            this.lblFolhaDePagamento.AutoSize = true;
            this.lblFolhaDePagamento.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFolhaDePagamento.ForeColor = System.Drawing.Color.Black;
            this.lblFolhaDePagamento.Location = new System.Drawing.Point(287, 31);
            this.lblFolhaDePagamento.Name = "lblFolhaDePagamento";
            this.lblFolhaDePagamento.Size = new System.Drawing.Size(258, 28);
            this.lblFolhaDePagamento.TabIndex = 231;
            this.lblFolhaDePagamento.Text = "Folha de Pagamento";
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
            this.imgMinimizar.TabIndex = 252;
            this.imgMinimizar.TabStop = false;
            // 
            // imgFechar
            // 
            this.imgFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgFechar.BackColor = System.Drawing.Color.Transparent;
            this.imgFechar.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.imgFechar.Image = global::Liriou_s_Burguer.Properties.Resources.Fechar;
            this.imgFechar.Location = new System.Drawing.Point(771, 31);
            this.imgFechar.Name = "imgFechar";
            this.imgFechar.Size = new System.Drawing.Size(25, 25);
            this.imgFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgFechar.TabIndex = 251;
            this.imgFechar.TabStop = false;
            this.imgFechar.UseWaitCursor = true;
            // 
            // frmPayroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.imgMinimizar);
            this.Controls.Add(this.imgFechar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MenuLiriousBurger);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnGerarFolha);
            this.Controls.Add(this.lblLíquido);
            this.Controls.Add(this.lblLíquido1);
            this.Controls.Add(this.lblBruto);
            this.Controls.Add(this.lblBruto1);
            this.Controls.Add(this.dataGridView6);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.groupProventos);
            this.Controls.Add(this.groupDespesas);
            this.Controls.Add(this.groupItens);
            this.Controls.Add(this.lblNomeDoFuncionário);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.txtRG);
            this.Controls.Add(this.lblRG);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblFolhaDePagamento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPayroll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payroll";
            this.MenuLiriousBurger.ResumeLayout(false);
            this.MenuLiriousBurger.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.groupProventos.ResumeLayout(false);
            this.groupProventos.PerformLayout();
            this.groupDespesas.ResumeLayout(false);
            this.groupDespesas.PerformLayout();
            this.groupItens.ResumeLayout(false);
            this.groupItens.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFechar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgMinimizar;
        private System.Windows.Forms.PictureBox imgFechar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip MenuLiriousBurger;
        private System.Windows.Forms.ToolStripMenuItem menuInício;
        private System.Windows.Forms.ToolStripMenuItem menuRH;
        private System.Windows.Forms.ToolStripMenuItem cadastrarFuncionárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarFuncionárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarFuncionárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem demitirFuncionárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarCartãoDePontoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuFinanceiro;
        private System.Windows.Forms.ToolStripMenuItem MenuEstoque;
        private System.Windows.Forms.ToolStripMenuItem MenuSuprimento;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnGerarFolha;
        private System.Windows.Forms.Label lblLíquido;
        private System.Windows.Forms.Label lblLíquido1;
        private System.Windows.Forms.Label lblBruto;
        private System.Windows.Forms.Label lblBruto1;
        private System.Windows.Forms.DataGridView dataGridView6;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.GroupBox groupProventos;
        private System.Windows.Forms.Label lblNulo5;
        private System.Windows.Forms.Label lblNulo4;
        private System.Windows.Forms.Label lblNulo3;
        private System.Windows.Forms.Label lblNulo6;
        private System.Windows.Forms.Label lblNulo7;
        private System.Windows.Forms.Label lblNulo8;
        private System.Windows.Forms.Label lblDependência;
        private System.Windows.Forms.Label lblHorasExtras;
        private System.Windows.Forms.Label lblSalário;
        private System.Windows.Forms.GroupBox groupDespesas;
        private System.Windows.Forms.Label lblPA;
        private System.Windows.Forms.Label lblNulo2;
        private System.Windows.Forms.Label lblIR;
        private System.Windows.Forms.Label lblINSS;
        private System.Windows.Forms.Label lblFGTS;
        private System.Windows.Forms.Label lblNulo1;
        private System.Windows.Forms.Label lblValeAlimentação;
        private System.Windows.Forms.Label lblValeTransporte;
        private System.Windows.Forms.Label lblNulo;
        private System.Windows.Forms.GroupBox groupItens;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblDependência1;
        private System.Windows.Forms.Label lblIR1;
        private System.Windows.Forms.Label lblINSS1;
        private System.Windows.Forms.Label lblFGTS1;
        private System.Windows.Forms.Label lblValeAlimentação1;
        private System.Windows.Forms.Label lblValeTransporte1;
        private System.Windows.Forms.Label lblHorasExtras1;
        private System.Windows.Forms.Label lblSalário1;
        private System.Windows.Forms.Label lblNomeDoFuncionário;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblFolhaDePagamento;
    }
}