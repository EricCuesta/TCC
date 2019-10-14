namespace Liriou_s_Burguer.Screens.Employee
{
    partial class frmUnavailability
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RichtxtObservação = new System.Windows.Forms.RichTextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.dgvIndisponibilidade = new System.Windows.Forms.DataGridView();
            this.Coluna1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.dtpIndisponibilidade = new System.Windows.Forms.DateTimePicker();
            this.lblDataIndisponibilidade = new System.Windows.Forms.Label();
            this.lblObservação = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblIndisponibilidade = new System.Windows.Forms.Label();
            this.MenuLiriousBurguer = new System.Windows.Forms.MenuStrip();
            this.cartãoDePontoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inícioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cartãoDePontoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.imgFechar = new System.Windows.Forms.PictureBox();
            this.imgMinimizar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIndisponibilidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.MenuLiriousBurguer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMinimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 91);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(470, 2);
            this.dataGridView2.TabIndex = 242;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.RichtxtObservação);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(9, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 325);
            this.panel1.TabIndex = 241;
            // 
            // RichtxtObservação
            // 
            this.RichtxtObservação.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RichtxtObservação.Location = new System.Drawing.Point(3, 3);
            this.RichtxtObservação.Name = "RichtxtObservação";
            this.RichtxtObservação.Size = new System.Drawing.Size(446, 319);
            this.RichtxtObservação.TabIndex = 221;
            this.RichtxtObservação.Text = "";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(182, 458);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(107, 30);
            this.btnSalvar.TabIndex = 240;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            // 
            // dgvIndisponibilidade
            // 
            this.dgvIndisponibilidade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIndisponibilidade.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Coluna1,
            this.Coluna2});
            this.dgvIndisponibilidade.Location = new System.Drawing.Point(483, 65);
            this.dgvIndisponibilidade.Name = "dgvIndisponibilidade";
            this.dgvIndisponibilidade.Size = new System.Drawing.Size(305, 426);
            this.dgvIndisponibilidade.TabIndex = 239;
            // 
            // Coluna1
            // 
            this.Coluna1.HeaderText = "Data";
            this.Coluna1.MaxInputLength = 100;
            this.Coluna1.Name = "Coluna1";
            this.Coluna1.Width = 110;
            // 
            // Coluna2
            // 
            this.Coluna2.HeaderText = "Observação";
            this.Coluna2.MaxInputLength = 100;
            this.Coluna2.Name = "Coluna2";
            this.Coluna2.Width = 155;
            // 
            // dataGridView4
            // 
            this.dataGridView4.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(468, 61);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(2, 439);
            this.dataGridView4.TabIndex = 238;
            // 
            // dtpIndisponibilidade
            // 
            this.dtpIndisponibilidade.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtpIndisponibilidade.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpIndisponibilidade.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIndisponibilidade.Location = new System.Drawing.Point(205, 64);
            this.dtpIndisponibilidade.Name = "dtpIndisponibilidade";
            this.dtpIndisponibilidade.Size = new System.Drawing.Size(254, 23);
            this.dtpIndisponibilidade.TabIndex = 237;
            // 
            // lblDataIndisponibilidade
            // 
            this.lblDataIndisponibilidade.AutoSize = true;
            this.lblDataIndisponibilidade.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataIndisponibilidade.Location = new System.Drawing.Point(12, 66);
            this.lblDataIndisponibilidade.Name = "lblDataIndisponibilidade";
            this.lblDataIndisponibilidade.Size = new System.Drawing.Size(187, 19);
            this.lblDataIndisponibilidade.TabIndex = 236;
            this.lblDataIndisponibilidade.Text = "Data de Indisponibilidade:";
            // 
            // lblObservação
            // 
            this.lblObservação.AutoSize = true;
            this.lblObservação.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservação.Location = new System.Drawing.Point(12, 96);
            this.lblObservação.Name = "lblObservação";
            this.lblObservação.Size = new System.Drawing.Size(94, 19);
            this.lblObservação.TabIndex = 234;
            this.lblObservação.Text = "Observação:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 2);
            this.dataGridView1.TabIndex = 233;
            // 
            // lblIndisponibilidade
            // 
            this.lblIndisponibilidade.AutoSize = true;
            this.lblIndisponibilidade.BackColor = System.Drawing.Color.Transparent;
            this.lblIndisponibilidade.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndisponibilidade.ForeColor = System.Drawing.Color.Black;
            this.lblIndisponibilidade.Location = new System.Drawing.Point(300, 29);
            this.lblIndisponibilidade.Name = "lblIndisponibilidade";
            this.lblIndisponibilidade.Size = new System.Drawing.Size(226, 28);
            this.lblIndisponibilidade.TabIndex = 232;
            this.lblIndisponibilidade.Text = "Indisponibilidade";
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
            this.MenuLiriousBurguer.TabIndex = 231;
            this.MenuLiriousBurguer.Text = "Liriou`s Burger";
            // 
            // cartãoDePontoToolStripMenuItem
            // 
            this.cartãoDePontoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inícioToolStripMenuItem,
            this.cartãoDePontoToolStripMenuItem1});
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
            this.inícioToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.inícioToolStripMenuItem.Text = "Início";
            this.inícioToolStripMenuItem.Click += new System.EventHandler(this.inícioToolStripMenuItem_Click);
            // 
            // cartãoDePontoToolStripMenuItem1
            // 
            this.cartãoDePontoToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.cartãoDePontoToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cartãoDePontoToolStripMenuItem1.Name = "cartãoDePontoToolStripMenuItem1";
            this.cartãoDePontoToolStripMenuItem1.Size = new System.Drawing.Size(212, 26);
            this.cartãoDePontoToolStripMenuItem1.Text = "Cartão de Ponto";
            this.cartãoDePontoToolStripMenuItem1.Click += new System.EventHandler(this.cartãoDePontoToolStripMenuItem1_Click);
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
            this.imgFechar.TabIndex = 256;
            this.imgFechar.TabStop = false;
            this.imgFechar.Click += new System.EventHandler(this.imgFechar_Click);
            // 
            // imgMinimizar
            // 
            this.imgMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgMinimizar.Image = global::Liriou_s_Burguer.Properties.Resources.Minimizar;
            this.imgMinimizar.Location = new System.Drawing.Point(740, 31);
            this.imgMinimizar.Name = "imgMinimizar";
            this.imgMinimizar.Size = new System.Drawing.Size(25, 25);
            this.imgMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgMinimizar.TabIndex = 255;
            this.imgMinimizar.TabStop = false;
            this.imgMinimizar.Click += new System.EventHandler(this.imgMinimizar_Click);
            // 
            // frmUnavailability
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.imgFechar);
            this.Controls.Add(this.imgMinimizar);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.dgvIndisponibilidade);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.dtpIndisponibilidade);
            this.Controls.Add(this.lblDataIndisponibilidade);
            this.Controls.Add(this.lblObservação);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblIndisponibilidade);
            this.Controls.Add(this.MenuLiriousBurguer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUnavailability";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unavailability";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIndisponibilidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.MenuLiriousBurguer.ResumeLayout(false);
            this.MenuLiriousBurguer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMinimizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox RichtxtObservação;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView dgvIndisponibilidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna2;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DateTimePicker dtpIndisponibilidade;
        private System.Windows.Forms.Label lblDataIndisponibilidade;
        private System.Windows.Forms.Label lblObservação;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblIndisponibilidade;
        private System.Windows.Forms.MenuStrip MenuLiriousBurguer;
        private System.Windows.Forms.ToolStripMenuItem cartãoDePontoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cartãoDePontoToolStripMenuItem1;
        private System.Windows.Forms.PictureBox imgFechar;
        private System.Windows.Forms.PictureBox imgMinimizar;
        private System.Windows.Forms.ToolStripMenuItem inícioToolStripMenuItem;
    }
}