namespace Liriou_s_Burguer.Screens.CRM
{
    partial class frmEmailSending
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmailSending));
            this.panel = new System.Windows.Forms.Panel();
            this.txtAssunto = new System.Windows.Forms.TextBox();
            this.listAnexo = new System.Windows.Forms.ListBox();
            this.btnAnexar = new System.Windows.Forms.Button();
            this.lblAnexo = new System.Windows.Forms.Label();
            this.rtxtConteúdo = new System.Windows.Forms.RichTextBox();
            this.txtBcc = new System.Windows.Forms.TextBox();
            this.txtPara = new System.Windows.Forms.TextBox();
            this.lblAssunto = new System.Windows.Forms.Label();
            this.lblBcc = new System.Windows.Forms.Label();
            this.lblPara = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblMensagemPorEmail = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.BackColor = System.Drawing.Color.Transparent;
            this.panel.Controls.Add(this.txtAssunto);
            this.panel.Controls.Add(this.listAnexo);
            this.panel.Controls.Add(this.btnAnexar);
            this.panel.Controls.Add(this.lblAnexo);
            this.panel.Controls.Add(this.rtxtConteúdo);
            this.panel.Controls.Add(this.txtBcc);
            this.panel.Controls.Add(this.txtPara);
            this.panel.Controls.Add(this.lblAssunto);
            this.panel.Controls.Add(this.lblBcc);
            this.panel.Controls.Add(this.lblPara);
            this.panel.Controls.Add(this.btnEnviar);
            this.panel.Controls.Add(this.dataGridView1);
            this.panel.Location = new System.Drawing.Point(0, 41);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(710, 418);
            this.panel.TabIndex = 570;
            // 
            // txtAssunto
            // 
            this.txtAssunto.Location = new System.Drawing.Point(91, 61);
            this.txtAssunto.Name = "txtAssunto";
            this.txtAssunto.Size = new System.Drawing.Size(607, 20);
            this.txtAssunto.TabIndex = 657;
            // 
            // listAnexo
            // 
            this.listAnexo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listAnexo.FormattingEnabled = true;
            this.listAnexo.Location = new System.Drawing.Point(91, 235);
            this.listAnexo.Name = "listAnexo";
            this.listAnexo.Size = new System.Drawing.Size(607, 91);
            this.listAnexo.TabIndex = 656;
            // 
            // btnAnexar
            // 
            this.btnAnexar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAnexar.BackColor = System.Drawing.Color.Black;
            this.btnAnexar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnexar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnexar.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnexar.ForeColor = System.Drawing.Color.White;
            this.btnAnexar.Location = new System.Drawing.Point(91, 328);
            this.btnAnexar.Name = "btnAnexar";
            this.btnAnexar.Size = new System.Drawing.Size(65, 26);
            this.btnAnexar.TabIndex = 655;
            this.btnAnexar.Text = "Anexar";
            this.btnAnexar.UseVisualStyleBackColor = false;
            this.btnAnexar.Click += new System.EventHandler(this.btnAnexar_Click);
            // 
            // lblAnexo
            // 
            this.lblAnexo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAnexo.AutoSize = true;
            this.lblAnexo.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnexo.ForeColor = System.Drawing.Color.Black;
            this.lblAnexo.Location = new System.Drawing.Point(25, 235);
            this.lblAnexo.Name = "lblAnexo";
            this.lblAnexo.Size = new System.Drawing.Size(57, 19);
            this.lblAnexo.TabIndex = 653;
            this.lblAnexo.Text = "Anexo:";
            // 
            // rtxtConteúdo
            // 
            this.rtxtConteúdo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtConteúdo.Location = new System.Drawing.Point(91, 87);
            this.rtxtConteúdo.Name = "rtxtConteúdo";
            this.rtxtConteúdo.Size = new System.Drawing.Size(607, 142);
            this.rtxtConteúdo.TabIndex = 652;
            this.rtxtConteúdo.Text = "";
            // 
            // txtBcc
            // 
            this.txtBcc.Location = new System.Drawing.Point(91, 35);
            this.txtBcc.Name = "txtBcc";
            this.txtBcc.Size = new System.Drawing.Size(607, 20);
            this.txtBcc.TabIndex = 651;
            // 
            // txtPara
            // 
            this.txtPara.Location = new System.Drawing.Point(91, 9);
            this.txtPara.Name = "txtPara";
            this.txtPara.Size = new System.Drawing.Size(607, 20);
            this.txtPara.TabIndex = 649;
            // 
            // lblAssunto
            // 
            this.lblAssunto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAssunto.AutoSize = true;
            this.lblAssunto.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssunto.ForeColor = System.Drawing.Color.Black;
            this.lblAssunto.Location = new System.Drawing.Point(12, 62);
            this.lblAssunto.Name = "lblAssunto";
            this.lblAssunto.Size = new System.Drawing.Size(70, 19);
            this.lblAssunto.TabIndex = 648;
            this.lblAssunto.Text = "Assunto:";
            // 
            // lblBcc
            // 
            this.lblBcc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBcc.AutoSize = true;
            this.lblBcc.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBcc.ForeColor = System.Drawing.Color.Black;
            this.lblBcc.Location = new System.Drawing.Point(45, 36);
            this.lblBcc.Name = "lblBcc";
            this.lblBcc.Size = new System.Drawing.Size(37, 19);
            this.lblBcc.TabIndex = 647;
            this.lblBcc.Text = "Bcc:";
            // 
            // lblPara
            // 
            this.lblPara.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPara.AutoSize = true;
            this.lblPara.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPara.ForeColor = System.Drawing.Color.Black;
            this.lblPara.Location = new System.Drawing.Point(38, 10);
            this.lblPara.Name = "lblPara";
            this.lblPara.Size = new System.Drawing.Size(44, 19);
            this.lblPara.TabIndex = 645;
            this.lblPara.Text = "Para:";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEnviar.BackColor = System.Drawing.Color.Transparent;
            this.btnEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.ForeColor = System.Drawing.Color.Black;
            this.btnEnviar.Location = new System.Drawing.Point(305, 377);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(107, 30);
            this.btnEnviar.TabIndex = 644;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
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
            // lblMensagemPorEmail
            // 
            this.lblMensagemPorEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMensagemPorEmail.AutoSize = true;
            this.lblMensagemPorEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblMensagemPorEmail.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagemPorEmail.ForeColor = System.Drawing.Color.Black;
            this.lblMensagemPorEmail.Location = new System.Drawing.Point(211, 11);
            this.lblMensagemPorEmail.Name = "lblMensagemPorEmail";
            this.lblMensagemPorEmail.Size = new System.Drawing.Size(277, 28);
            this.lblMensagemPorEmail.TabIndex = 569;
            this.lblMensagemPorEmail.Text = "Mensagem por E-mail";
            this.lblMensagemPorEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmEmailSending
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Liriou_s_Burguer.Properties.Resources.Fundo;
            this.ClientSize = new System.Drawing.Size(710, 459);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.lblMensagemPorEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEmailSending";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Email Sending";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TextBox txtAssunto;
        private System.Windows.Forms.ListBox listAnexo;
        private System.Windows.Forms.Button btnAnexar;
        private System.Windows.Forms.Label lblAnexo;
        private System.Windows.Forms.RichTextBox rtxtConteúdo;
        private System.Windows.Forms.TextBox txtBcc;
        private System.Windows.Forms.TextBox txtPara;
        private System.Windows.Forms.Label lblAssunto;
        private System.Windows.Forms.Label lblBcc;
        private System.Windows.Forms.Label lblPara;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblMensagemPorEmail;
    }
}