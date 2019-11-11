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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployeeTimeCard));
            this.DataHora = new System.Windows.Forms.Timer(this.components);
            this.panel = new System.Windows.Forms.Panel();
            this.lblTérmino = new System.Windows.Forms.Label();
            this.lbTérmino1 = new System.Windows.Forms.Label();
            this.lblTérminoDoIntervalo = new System.Windows.Forms.Label();
            this.lblTérminoDoIntervalo1 = new System.Windows.Forms.Label();
            this.lblInícioDoIntervalo = new System.Windows.Forms.Label();
            this.lblInícioDoIntervalo1 = new System.Windows.Forms.Label();
            this.lblInício = new System.Windows.Forms.Label();
            this.lblInício1 = new System.Windows.Forms.Label();
            this.btnBaterPonto = new System.Windows.Forms.Button();
            this.lblHorárioData = new System.Windows.Forms.Label();
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
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.BackColor = System.Drawing.Color.Transparent;
            this.panel.Controls.Add(this.lblTérmino);
            this.panel.Controls.Add(this.lbTérmino1);
            this.panel.Controls.Add(this.lblTérminoDoIntervalo);
            this.panel.Controls.Add(this.lblTérminoDoIntervalo1);
            this.panel.Controls.Add(this.lblInícioDoIntervalo);
            this.panel.Controls.Add(this.lblInícioDoIntervalo1);
            this.panel.Controls.Add(this.lblInício);
            this.panel.Controls.Add(this.lblInício1);
            this.panel.Controls.Add(this.btnBaterPonto);
            this.panel.Controls.Add(this.lblHorárioData);
            this.panel.Controls.Add(this.dataGridView1);
            this.panel.Location = new System.Drawing.Point(0, 41);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(710, 418);
            this.panel.TabIndex = 568;
            // 
            // lblTérmino
            // 
            this.lblTérmino.BackColor = System.Drawing.Color.Transparent;
            this.lblTérmino.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTérmino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTérmino.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTérmino.ForeColor = System.Drawing.Color.Black;
            this.lblTérmino.Location = new System.Drawing.Point(596, 147);
            this.lblTérmino.Name = "lblTérmino";
            this.lblTérmino.Size = new System.Drawing.Size(102, 28);
            this.lblTérmino.TabIndex = 616;
            this.lblTérmino.Text = "00:00:00";
            this.lblTérmino.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTérmino1
            // 
            this.lbTérmino1.AutoSize = true;
            this.lbTérmino1.BackColor = System.Drawing.Color.Transparent;
            this.lbTérmino1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTérmino1.ForeColor = System.Drawing.Color.Black;
            this.lbTérmino1.Location = new System.Drawing.Point(615, 179);
            this.lbTérmino1.Name = "lbTérmino1";
            this.lbTérmino1.Size = new System.Drawing.Size(65, 19);
            this.lbTérmino1.TabIndex = 615;
            this.lbTérmino1.Text = "Término";
            // 
            // lblTérminoDoIntervalo
            // 
            this.lblTérminoDoIntervalo.BackColor = System.Drawing.Color.Transparent;
            this.lblTérminoDoIntervalo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTérminoDoIntervalo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTérminoDoIntervalo.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTérminoDoIntervalo.ForeColor = System.Drawing.Color.Black;
            this.lblTérminoDoIntervalo.Location = new System.Drawing.Point(404, 147);
            this.lblTérminoDoIntervalo.Name = "lblTérminoDoIntervalo";
            this.lblTérminoDoIntervalo.Size = new System.Drawing.Size(102, 28);
            this.lblTérminoDoIntervalo.TabIndex = 614;
            this.lblTérminoDoIntervalo.Text = "00:00:00";
            this.lblTérminoDoIntervalo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTérminoDoIntervalo1
            // 
            this.lblTérminoDoIntervalo1.AutoSize = true;
            this.lblTérminoDoIntervalo1.BackColor = System.Drawing.Color.Transparent;
            this.lblTérminoDoIntervalo1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTérminoDoIntervalo1.ForeColor = System.Drawing.Color.Black;
            this.lblTérminoDoIntervalo1.Location = new System.Drawing.Point(380, 179);
            this.lblTérminoDoIntervalo1.Name = "lblTérminoDoIntervalo1";
            this.lblTérminoDoIntervalo1.Size = new System.Drawing.Size(151, 19);
            this.lblTérminoDoIntervalo1.TabIndex = 613;
            this.lblTérminoDoIntervalo1.Text = "Término do Intervalo";
            // 
            // lblInícioDoIntervalo
            // 
            this.lblInícioDoIntervalo.BackColor = System.Drawing.Color.Transparent;
            this.lblInícioDoIntervalo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInícioDoIntervalo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblInícioDoIntervalo.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInícioDoIntervalo.ForeColor = System.Drawing.Color.Black;
            this.lblInícioDoIntervalo.Location = new System.Drawing.Point(198, 147);
            this.lblInícioDoIntervalo.Name = "lblInícioDoIntervalo";
            this.lblInícioDoIntervalo.Size = new System.Drawing.Size(102, 28);
            this.lblInícioDoIntervalo.TabIndex = 612;
            this.lblInícioDoIntervalo.Text = "00:00:00";
            this.lblInícioDoIntervalo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInícioDoIntervalo1
            // 
            this.lblInícioDoIntervalo1.AutoSize = true;
            this.lblInícioDoIntervalo1.BackColor = System.Drawing.Color.Transparent;
            this.lblInícioDoIntervalo1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInícioDoIntervalo1.ForeColor = System.Drawing.Color.Black;
            this.lblInícioDoIntervalo1.Location = new System.Drawing.Point(183, 179);
            this.lblInícioDoIntervalo1.Name = "lblInícioDoIntervalo1";
            this.lblInícioDoIntervalo1.Size = new System.Drawing.Size(132, 19);
            this.lblInícioDoIntervalo1.TabIndex = 611;
            this.lblInícioDoIntervalo1.Text = "Início do Intervalo";
            // 
            // lblInício
            // 
            this.lblInício.BackColor = System.Drawing.Color.Transparent;
            this.lblInício.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInício.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblInício.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInício.ForeColor = System.Drawing.Color.Black;
            this.lblInício.Location = new System.Drawing.Point(12, 147);
            this.lblInício.Name = "lblInício";
            this.lblInício.Size = new System.Drawing.Size(102, 28);
            this.lblInício.TabIndex = 610;
            this.lblInício.Text = "00:00:00";
            this.lblInício.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInício1
            // 
            this.lblInício1.AutoSize = true;
            this.lblInício1.BackColor = System.Drawing.Color.Transparent;
            this.lblInício1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInício1.ForeColor = System.Drawing.Color.Black;
            this.lblInício1.Location = new System.Drawing.Point(39, 179);
            this.lblInício1.Name = "lblInício1";
            this.lblInício1.Size = new System.Drawing.Size(46, 19);
            this.lblInício1.TabIndex = 609;
            this.lblInício1.Text = "Início";
            // 
            // btnBaterPonto
            // 
            this.btnBaterPonto.BackColor = System.Drawing.Color.Transparent;
            this.btnBaterPonto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBaterPonto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaterPonto.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaterPonto.ForeColor = System.Drawing.Color.Black;
            this.btnBaterPonto.Location = new System.Drawing.Point(290, 376);
            this.btnBaterPonto.Name = "btnBaterPonto";
            this.btnBaterPonto.Size = new System.Drawing.Size(131, 30);
            this.btnBaterPonto.TabIndex = 608;
            this.btnBaterPonto.Text = "Bater Ponto";
            this.btnBaterPonto.UseVisualStyleBackColor = false;
            this.btnBaterPonto.Click += new System.EventHandler(this.btnBaterPonto_Click);
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
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Black;
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
            this.lblCartãoDePonto.BackColor = System.Drawing.Color.Transparent;
            this.lblCartãoDePonto.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCartãoDePonto.ForeColor = System.Drawing.Color.Black;
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
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Liriou_s_Burguer.Properties.Resources.Fundo;
            this.ClientSize = new System.Drawing.Size(710, 459);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.lblCartãoDePonto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Label lblHorárioData;
        private System.Windows.Forms.Button btnBaterPonto;
        private System.Windows.Forms.Label lblTérmino;
        private System.Windows.Forms.Label lbTérmino1;
        private System.Windows.Forms.Label lblTérminoDoIntervalo;
        private System.Windows.Forms.Label lblTérminoDoIntervalo1;
        private System.Windows.Forms.Label lblInícioDoIntervalo;
        private System.Windows.Forms.Label lblInícioDoIntervalo1;
        private System.Windows.Forms.Label lblInício;
        private System.Windows.Forms.Label lblInício1;
    }
}