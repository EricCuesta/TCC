namespace Liriou_s_Burguer.Screens.Login
{
    partial class frmSplash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplash));
            this.BarraDeCarregamento = new System.Windows.Forms.Panel();
            this.Carregando = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.imgSplash = new System.Windows.Forms.PictureBox();
            this.BarraDeCarregamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSplash)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraDeCarregamento
            // 
            this.BarraDeCarregamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(57)))), ((int)(((byte)(79)))));
            this.BarraDeCarregamento.Controls.Add(this.Carregando);
            this.BarraDeCarregamento.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BarraDeCarregamento.Location = new System.Drawing.Point(0, 475);
            this.BarraDeCarregamento.Name = "BarraDeCarregamento";
            this.BarraDeCarregamento.Size = new System.Drawing.Size(800, 25);
            this.BarraDeCarregamento.TabIndex = 3;
            // 
            // Carregando
            // 
            this.Carregando.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(109)))), ((int)(((byte)(137)))));
            this.Carregando.Location = new System.Drawing.Point(0, 0);
            this.Carregando.Name = "Carregando";
            this.Carregando.Size = new System.Drawing.Size(40, 25);
            this.Carregando.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // imgSplash
            // 
            this.imgSplash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.imgSplash.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.imgSplash.Image = global::Liriou_s_Burguer.Properties.Resources.Hamburger_1_;
            this.imgSplash.Location = new System.Drawing.Point(0, 0);
            this.imgSplash.Name = "imgSplash";
            this.imgSplash.Size = new System.Drawing.Size(800, 475);
            this.imgSplash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imgSplash.TabIndex = 2;
            this.imgSplash.TabStop = false;
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.BarraDeCarregamento);
            this.Controls.Add(this.imgSplash);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash";
            this.BarraDeCarregamento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgSplash)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarraDeCarregamento;
        private System.Windows.Forms.Panel Carregando;
        private System.Windows.Forms.PictureBox imgSplash;
        private System.Windows.Forms.Timer timer1;
    }
}