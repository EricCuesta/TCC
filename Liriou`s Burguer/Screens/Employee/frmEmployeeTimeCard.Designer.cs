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
            this.DataHora = new System.Windows.Forms.Timer(this.components);
            this.panel = new System.Windows.Forms.Panel();
            this.btnBaterPonto = new System.Windows.Forms.Button();
            this.lblTérmino = new System.Windows.Forms.Label();
            this.lblSaída1 = new System.Windows.Forms.Label();
            this.lblTérminoDoIntervalo = new System.Windows.Forms.Label();
            this.lblSaídaDoIntervalo1 = new System.Windows.Forms.Label();
            this.lblInícioDoIntervalo = new System.Windows.Forms.Label();
            this.lblEntradaDoIntervalo1 = new System.Windows.Forms.Label();
            this.lblHorárioData = new System.Windows.Forms.Label();
            this.lblInício = new System.Windows.Forms.Label();
            this.lblEntrada1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblCartãoDePonto = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DataHora
            // 
            this.DataHora.Enabled = true;
            this.DataHora.Interval = 1000;
            this.DataHora.Tick += new System.EventHandler(this.DataHora_Tick);
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(62)))));
            this.panel.Controls.Add(this.btnBaterPonto);
            this.panel.Controls.Add(this.lblTérmino);
            this.panel.Controls.Add(this.lblSaída1);
            this.panel.Controls.Add(this.lblTérminoDoIntervalo);
            this.panel.Controls.Add(this.lblSaídaDoIntervalo1);
            this.panel.Controls.Add(this.lblInícioDoIntervalo);
            this.panel.Controls.Add(this.lblEntradaDoIntervalo1);
            this.panel.Controls.Add(this.lblHorárioData);
            this.panel.Controls.Add(this.lblInício);
            this.panel.Controls.Add(this.lblEntrada1);
            this.panel.Controls.Add(this.dataGridView1);
            this.panel.Location = new System.Drawing.Point(0, 41);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(710, 418);
            this.panel.TabIndex = 568;
            // 
            // btnBaterPonto
            // 
            this.btnBaterPonto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBaterPonto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBaterPonto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaterPonto.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaterPonto.Location = new System.Drawing.Point(290, 376);
            this.btnBaterPonto.Name = "btnBaterPonto";
            this.btnBaterPonto.Size = new System.Drawing.Size(131, 30);
            this.btnBaterPonto.TabIndex = 608;
            this.btnBaterPonto.Text = "Bater Ponto";
            this.btnBaterPonto.UseVisualStyleBackColor = false;
            this.btnBaterPonto.Click += new System.EventHandler(this.btnBaterPonto_Click);
            // 
            // lblTérmino
            // 
            this.lblTérmino.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTérmino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTérmino.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTérmino.ForeColor = System.Drawing.Color.White;
            this.lblTérmino.Location = new System.Drawing.Point(449, 248);
            this.lblTérmino.Name = "lblTérmino";
            this.lblTérmino.Size = new System.Drawing.Size(230, 28);
            this.lblTérmino.TabIndex = 607;
            this.lblTérmino.Text = "_ _ / _ _ / _ _ _ _ 00:00";
            this.lblTérmino.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSaída1
            // 
            this.lblSaída1.AutoSize = true;
            this.lblSaída1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaída1.ForeColor = System.Drawing.Color.White;
            this.lblSaída1.Location = new System.Drawing.Point(531, 280);
            this.lblSaída1.Name = "lblSaída1";
            this.lblSaída1.Size = new System.Drawing.Size(65, 19);
            this.lblSaída1.TabIndex = 606;
            this.lblSaída1.Text = "Término";
            // 
            // lblTérminoDoIntervalo
            // 
            this.lblTérminoDoIntervalo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTérminoDoIntervalo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTérminoDoIntervalo.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTérminoDoIntervalo.ForeColor = System.Drawing.Color.White;
            this.lblTérminoDoIntervalo.Location = new System.Drawing.Point(449, 82);
            this.lblTérminoDoIntervalo.Name = "lblTérminoDoIntervalo";
            this.lblTérminoDoIntervalo.Size = new System.Drawing.Size(230, 28);
            this.lblTérminoDoIntervalo.TabIndex = 605;
            this.lblTérminoDoIntervalo.Text = "_ _ / _ _ / _ _ _ _ 00:00";
            this.lblTérminoDoIntervalo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSaídaDoIntervalo1
            // 
            this.lblSaídaDoIntervalo1.AutoSize = true;
            this.lblSaídaDoIntervalo1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaídaDoIntervalo1.ForeColor = System.Drawing.Color.White;
            this.lblSaídaDoIntervalo1.Location = new System.Drawing.Point(488, 114);
            this.lblSaídaDoIntervalo1.Name = "lblSaídaDoIntervalo1";
            this.lblSaídaDoIntervalo1.Size = new System.Drawing.Size(151, 19);
            this.lblSaídaDoIntervalo1.TabIndex = 604;
            this.lblSaídaDoIntervalo1.Text = "Término do Intervalo";
            // 
            // lblInícioDoIntervalo
            // 
            this.lblInícioDoIntervalo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInícioDoIntervalo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblInícioDoIntervalo.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInícioDoIntervalo.ForeColor = System.Drawing.Color.White;
            this.lblInícioDoIntervalo.Location = new System.Drawing.Point(35, 248);
            this.lblInícioDoIntervalo.Name = "lblInícioDoIntervalo";
            this.lblInícioDoIntervalo.Size = new System.Drawing.Size(230, 28);
            this.lblInícioDoIntervalo.TabIndex = 603;
            this.lblInícioDoIntervalo.Text = "_ _ / _ _ / _ _ _ _ 00:00";
            this.lblInícioDoIntervalo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEntradaDoIntervalo1
            // 
            this.lblEntradaDoIntervalo1.AutoSize = true;
            this.lblEntradaDoIntervalo1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntradaDoIntervalo1.ForeColor = System.Drawing.Color.White;
            this.lblEntradaDoIntervalo1.Location = new System.Drawing.Point(72, 280);
            this.lblEntradaDoIntervalo1.Name = "lblEntradaDoIntervalo1";
            this.lblEntradaDoIntervalo1.Size = new System.Drawing.Size(132, 19);
            this.lblEntradaDoIntervalo1.TabIndex = 602;
            this.lblEntradaDoIntervalo1.Text = "Início do Intervalo";
            // 
            // lblHorárioData
            // 
            this.lblHorárioData.AutoSize = true;
            this.lblHorárioData.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorárioData.ForeColor = System.Drawing.Color.White;
            this.lblHorárioData.Location = new System.Drawing.Point(488, 7);
            this.lblHorárioData.Name = "lblHorárioData";
            this.lblHorárioData.Size = new System.Drawing.Size(0, 20);
            this.lblHorárioData.TabIndex = 601;
            // 
            // lblInício
            // 
            this.lblInício.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInício.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblInício.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInício.ForeColor = System.Drawing.Color.White;
            this.lblInício.Location = new System.Drawing.Point(35, 82);
            this.lblInício.Name = "lblInício";
            this.lblInício.Size = new System.Drawing.Size(230, 28);
            this.lblInício.TabIndex = 600;
            this.lblInício.Text = "_ _ / _ _ / _ _ _ _ 00:00";
            this.lblInício.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEntrada1
            // 
            this.lblEntrada1.AutoSize = true;
            this.lblEntrada1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntrada1.ForeColor = System.Drawing.Color.White;
            this.lblEntrada1.Location = new System.Drawing.Point(127, 114);
            this.lblEntrada1.Name = "lblEntrada1";
            this.lblEntrada1.Size = new System.Drawing.Size(46, 19);
            this.lblEntrada1.TabIndex = 599;
            this.lblEntrada1.Text = "Início";
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
            // lblCartãoDePonto
            // 
            this.lblCartãoDePonto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCartãoDePonto.AutoSize = true;
            this.lblCartãoDePonto.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCartãoDePonto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCartãoDePonto.Location = new System.Drawing.Point(251, 9);
            this.lblCartãoDePonto.Name = "lblCartãoDePonto";
            this.lblCartãoDePonto.Size = new System.Drawing.Size(206, 28);
            this.lblCartãoDePonto.TabIndex = 567;
            this.lblCartãoDePonto.Text = "Cartão de Ponto";
            this.lblCartãoDePonto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmEmployeeTimeCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(710, 459);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.lblCartãoDePonto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEmployeeTimeCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Time Card";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer DataHora;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblCartãoDePonto;
        private System.Windows.Forms.Label lblInício;
        private System.Windows.Forms.Label lblEntrada1;
        private System.Windows.Forms.Label lblHorárioData;
        private System.Windows.Forms.Label lblInícioDoIntervalo;
        private System.Windows.Forms.Label lblEntradaDoIntervalo1;
        private System.Windows.Forms.Label lblTérminoDoIntervalo;
        private System.Windows.Forms.Label lblSaídaDoIntervalo1;
        private System.Windows.Forms.Label lblTérmino;
        private System.Windows.Forms.Label lblSaída1;
        private System.Windows.Forms.Button btnBaterPonto;
    }
}