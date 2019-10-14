namespace Liriou_s_Burguer.Screens.Employee
{
    partial class frmEmployeeTimeCard
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
            this.components = new System.ComponentModel.Container();
            this.lblSaída = new System.Windows.Forms.Label();
            this.lblSaídaDoIntervalo = new System.Windows.Forms.Label();
            this.lblEntradaDoIntervalo = new System.Windows.Forms.Label();
            this.lblEntrada = new System.Windows.Forms.Label();
            this.lblSaída1 = new System.Windows.Forms.Label();
            this.lblSaídaDoIntervalo1 = new System.Windows.Forms.Label();
            this.btnBaterPonto = new System.Windows.Forms.Button();
            this.lblEntradaDoIntervalo1 = new System.Windows.Forms.Label();
            this.lblEntrada1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblCartãoDePonto = new System.Windows.Forms.Label();
            this.lblHorárioData = new System.Windows.Forms.Label();
            this.MenuLiriousBurguer = new System.Windows.Forms.MenuStrip();
            this.cartãoDePontoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inícioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataDeIndisponibilidadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imgFechar = new System.Windows.Forms.PictureBox();
            this.imgMinimizar = new System.Windows.Forms.PictureBox();
            this.DataHora = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.MenuLiriousBurguer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMinimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSaída
            // 
            this.lblSaída.AutoSize = true;
            this.lblSaída.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSaída.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSaída.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaída.Location = new System.Drawing.Point(673, 203);
            this.lblSaída.Name = "lblSaída";
            this.lblSaída.Size = new System.Drawing.Size(67, 28);
            this.lblSaída.TabIndex = 241;
            this.lblSaída.Text = "00:00";
            // 
            // lblSaídaDoIntervalo
            // 
            this.lblSaídaDoIntervalo.AutoSize = true;
            this.lblSaídaDoIntervalo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSaídaDoIntervalo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSaídaDoIntervalo.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaídaDoIntervalo.Location = new System.Drawing.Point(483, 203);
            this.lblSaídaDoIntervalo.Name = "lblSaídaDoIntervalo";
            this.lblSaídaDoIntervalo.Size = new System.Drawing.Size(67, 28);
            this.lblSaídaDoIntervalo.TabIndex = 240;
            this.lblSaídaDoIntervalo.Text = "00:00";
            // 
            // lblEntradaDoIntervalo
            // 
            this.lblEntradaDoIntervalo.AutoSize = true;
            this.lblEntradaDoIntervalo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEntradaDoIntervalo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEntradaDoIntervalo.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntradaDoIntervalo.Location = new System.Drawing.Point(271, 203);
            this.lblEntradaDoIntervalo.Name = "lblEntradaDoIntervalo";
            this.lblEntradaDoIntervalo.Size = new System.Drawing.Size(67, 28);
            this.lblEntradaDoIntervalo.TabIndex = 239;
            this.lblEntradaDoIntervalo.Text = "00:00";
            // 
            // lblEntrada
            // 
            this.lblEntrada.AutoSize = true;
            this.lblEntrada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEntrada.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntrada.Location = new System.Drawing.Point(57, 203);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(67, 28);
            this.lblEntrada.TabIndex = 238;
            this.lblEntrada.Text = "00:00";
            // 
            // lblSaída1
            // 
            this.lblSaída1.AutoSize = true;
            this.lblSaída1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaída1.Location = new System.Drawing.Point(684, 233);
            this.lblSaída1.Name = "lblSaída1";
            this.lblSaída1.Size = new System.Drawing.Size(46, 19);
            this.lblSaída1.TabIndex = 237;
            this.lblSaída1.Text = "Saída";
            // 
            // lblSaídaDoIntervalo1
            // 
            this.lblSaídaDoIntervalo1.AutoSize = true;
            this.lblSaídaDoIntervalo1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaídaDoIntervalo1.Location = new System.Drawing.Point(444, 233);
            this.lblSaídaDoIntervalo1.Name = "lblSaídaDoIntervalo1";
            this.lblSaídaDoIntervalo1.Size = new System.Drawing.Size(132, 19);
            this.lblSaídaDoIntervalo1.TabIndex = 236;
            this.lblSaídaDoIntervalo1.Text = "Saída do Intervalo";
            // 
            // btnBaterPonto
            // 
            this.btnBaterPonto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBaterPonto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBaterPonto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaterPonto.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaterPonto.Location = new System.Drawing.Point(336, 464);
            this.btnBaterPonto.Name = "btnBaterPonto";
            this.btnBaterPonto.Size = new System.Drawing.Size(131, 30);
            this.btnBaterPonto.TabIndex = 235;
            this.btnBaterPonto.Text = "Bater Ponto";
            this.btnBaterPonto.UseVisualStyleBackColor = false;
            // 
            // lblEntradaDoIntervalo1
            // 
            this.lblEntradaDoIntervalo1.AutoSize = true;
            this.lblEntradaDoIntervalo1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntradaDoIntervalo1.Location = new System.Drawing.Point(222, 233);
            this.lblEntradaDoIntervalo1.Name = "lblEntradaDoIntervalo1";
            this.lblEntradaDoIntervalo1.Size = new System.Drawing.Size(149, 19);
            this.lblEntradaDoIntervalo1.TabIndex = 234;
            this.lblEntradaDoIntervalo1.Text = "Entrada do Intervalo";
            // 
            // lblEntrada1
            // 
            this.lblEntrada1.AutoSize = true;
            this.lblEntrada1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntrada1.Location = new System.Drawing.Point(59, 233);
            this.lblEntrada1.Name = "lblEntrada1";
            this.lblEntrada1.Size = new System.Drawing.Size(63, 19);
            this.lblEntrada1.TabIndex = 233;
            this.lblEntrada1.Text = "Entrada";
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
            // lblCartãoDePonto
            // 
            this.lblCartãoDePonto.AutoSize = true;
            this.lblCartãoDePonto.BackColor = System.Drawing.Color.Transparent;
            this.lblCartãoDePonto.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCartãoDePonto.ForeColor = System.Drawing.Color.Black;
            this.lblCartãoDePonto.Location = new System.Drawing.Point(300, 32);
            this.lblCartãoDePonto.Name = "lblCartãoDePonto";
            this.lblCartãoDePonto.Size = new System.Drawing.Size(206, 28);
            this.lblCartãoDePonto.TabIndex = 231;
            this.lblCartãoDePonto.Text = "Cartão de Ponto";
            // 
            // lblHorárioData
            // 
            this.lblHorárioData.AutoSize = true;
            this.lblHorárioData.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorárioData.Location = new System.Drawing.Point(594, 65);
            this.lblHorárioData.Name = "lblHorárioData";
            this.lblHorárioData.Size = new System.Drawing.Size(0, 20);
            this.lblHorárioData.TabIndex = 230;
            // 
            // MenuLiriousBurguer
            // 
            this.MenuLiriousBurguer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.MenuLiriousBurguer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cartãoDePontoToolStripMenuItem});
            this.MenuLiriousBurguer.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.MenuLiriousBurguer.Location = new System.Drawing.Point(0, 0);
            this.MenuLiriousBurguer.Name = "MenuLiriousBurguer";
            this.MenuLiriousBurguer.Size = new System.Drawing.Size(800, 29);
            this.MenuLiriousBurguer.TabIndex = 229;
            this.MenuLiriousBurguer.Text = "Liriou`s Burger";
            // 
            // cartãoDePontoToolStripMenuItem
            // 
            this.cartãoDePontoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inícioToolStripMenuItem,
            this.dataDeIndisponibilidadeToolStripMenuItem});
            this.cartãoDePontoToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartãoDePontoToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cartãoDePontoToolStripMenuItem.Name = "cartãoDePontoToolStripMenuItem";
            this.cartãoDePontoToolStripMenuItem.Size = new System.Drawing.Size(67, 25);
            this.cartãoDePontoToolStripMenuItem.Text = "Menu";
            // 
            // inícioToolStripMenuItem
            // 
            this.inícioToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.inícioToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.inícioToolStripMenuItem.Name = "inícioToolStripMenuItem";
            this.inícioToolStripMenuItem.Size = new System.Drawing.Size(282, 26);
            this.inícioToolStripMenuItem.Text = "Início";
            this.inícioToolStripMenuItem.Click += new System.EventHandler(this.inícioToolStripMenuItem_Click);
            // 
            // dataDeIndisponibilidadeToolStripMenuItem
            // 
            this.dataDeIndisponibilidadeToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.dataDeIndisponibilidadeToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dataDeIndisponibilidadeToolStripMenuItem.Name = "dataDeIndisponibilidadeToolStripMenuItem";
            this.dataDeIndisponibilidadeToolStripMenuItem.Size = new System.Drawing.Size(282, 26);
            this.dataDeIndisponibilidadeToolStripMenuItem.Text = "Data de Indisponibilidade";
            this.dataDeIndisponibilidadeToolStripMenuItem.Click += new System.EventHandler(this.dataDeIndisponibilidadeToolStripMenuItem_Click);
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
            this.imgFechar.TabIndex = 488;
            this.imgFechar.TabStop = false;
            this.imgFechar.Click += new System.EventHandler(this.imgFechar_Click);
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
            this.imgMinimizar.TabIndex = 487;
            this.imgMinimizar.TabStop = false;
            this.imgMinimizar.Click += new System.EventHandler(this.imgMinimizar_Click);
            // 
            // DataHora
            // 
            this.DataHora.Enabled = true;
            this.DataHora.Interval = 1000;
            this.DataHora.Tick += new System.EventHandler(this.DataHora_Tick);
            // 
            // frmEmployeeTimeCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.imgFechar);
            this.Controls.Add(this.imgMinimizar);
            this.Controls.Add(this.lblSaída);
            this.Controls.Add(this.lblSaídaDoIntervalo);
            this.Controls.Add(this.lblEntradaDoIntervalo);
            this.Controls.Add(this.lblEntrada);
            this.Controls.Add(this.lblSaída1);
            this.Controls.Add(this.lblSaídaDoIntervalo1);
            this.Controls.Add(this.btnBaterPonto);
            this.Controls.Add(this.lblEntradaDoIntervalo1);
            this.Controls.Add(this.lblEntrada1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblCartãoDePonto);
            this.Controls.Add(this.lblHorárioData);
            this.Controls.Add(this.MenuLiriousBurguer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEmployeeTimeCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Time Card";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.MenuLiriousBurguer.ResumeLayout(false);
            this.MenuLiriousBurguer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMinimizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSaída;
        private System.Windows.Forms.Label lblSaídaDoIntervalo;
        private System.Windows.Forms.Label lblEntradaDoIntervalo;
        private System.Windows.Forms.Label lblEntrada;
        private System.Windows.Forms.Label lblSaída1;
        private System.Windows.Forms.Label lblSaídaDoIntervalo1;
        private System.Windows.Forms.Button btnBaterPonto;
        private System.Windows.Forms.Label lblEntradaDoIntervalo1;
        private System.Windows.Forms.Label lblEntrada1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblCartãoDePonto;
        private System.Windows.Forms.Label lblHorárioData;
        private System.Windows.Forms.MenuStrip MenuLiriousBurguer;
        private System.Windows.Forms.ToolStripMenuItem cartãoDePontoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataDeIndisponibilidadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inícioToolStripMenuItem;
        private System.Windows.Forms.PictureBox imgFechar;
        private System.Windows.Forms.PictureBox imgMinimizar;
        private System.Windows.Forms.Timer DataHora;
    }
}