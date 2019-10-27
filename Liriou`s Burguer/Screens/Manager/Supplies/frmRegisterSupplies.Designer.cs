﻿namespace Liriou_s_Burguer.Screens.Manager.Supplies
{
    partial class frmRegisterSupplies
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
            this.rtxDescrição = new System.Windows.Forms.RichTextBox();
            this.lblDescrição = new System.Windows.Forms.Label();
            this.nudValor = new System.Windows.Forms.NumericUpDown();
            this.lblValor = new System.Windows.Forms.Label();
            this.dataGridView16 = new System.Windows.Forms.DataGridView();
            this.nudQuantidade = new System.Windows.Forms.NumericUpDown();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.cboEstoque = new System.Windows.Forms.ComboBox();
            this.lblEstoque = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.lblCadastrarSuprimento = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudValor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
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
            this.panel.Controls.Add(this.rtxDescrição);
            this.panel.Controls.Add(this.lblDescrição);
            this.panel.Controls.Add(this.nudValor);
            this.panel.Controls.Add(this.lblValor);
            this.panel.Controls.Add(this.dataGridView16);
            this.panel.Controls.Add(this.nudQuantidade);
            this.panel.Controls.Add(this.lblQuantidade);
            this.panel.Controls.Add(this.txtNome);
            this.panel.Controls.Add(this.lblNome);
            this.panel.Controls.Add(this.cboEstoque);
            this.panel.Controls.Add(this.lblEstoque);
            this.panel.Controls.Add(this.btnCadastrar);
            this.panel.Controls.Add(this.dataGridView5);
            this.panel.Controls.Add(this.dataGridView3);
            this.panel.Controls.Add(this.dataGridView1);
            this.panel.Controls.Add(this.dataGridView2);
            this.panel.Location = new System.Drawing.Point(1, 40);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(709, 418);
            this.panel.TabIndex = 568;
            // 
            // rtxDescrição
            // 
            this.rtxDescrição.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxDescrição.Location = new System.Drawing.Point(7, 92);
            this.rtxDescrição.MaxLength = 256;
            this.rtxDescrição.Name = "rtxDescrição";
            this.rtxDescrição.Size = new System.Drawing.Size(698, 170);
            this.rtxDescrição.TabIndex = 657;
            this.rtxDescrição.Text = "";
            // 
            // lblDescrição
            // 
            this.lblDescrição.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDescrição.AutoSize = true;
            this.lblDescrição.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescrição.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDescrição.Location = new System.Drawing.Point(3, 70);
            this.lblDescrição.Name = "lblDescrição";
            this.lblDescrição.Size = new System.Drawing.Size(79, 19);
            this.lblDescrição.TabIndex = 656;
            this.lblDescrição.Text = "Descrição:";
            // 
            // nudValor
            // 
            this.nudValor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nudValor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.nudValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudValor.DecimalPlaces = 2;
            this.nudValor.Location = new System.Drawing.Point(436, 40);
            this.nudValor.Name = "nudValor";
            this.nudValor.Size = new System.Drawing.Size(269, 20);
            this.nudValor.TabIndex = 655;
            // 
            // lblValor
            // 
            this.lblValor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblValor.Location = new System.Drawing.Point(361, 40);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(69, 19);
            this.lblValor.TabIndex = 654;
            this.lblValor.Text = "Valor: R$";
            // 
            // dataGridView16
            // 
            this.dataGridView16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView16.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView16.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView16.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView16.Location = new System.Drawing.Point(353, 37);
            this.dataGridView16.Name = "dataGridView16";
            this.dataGridView16.Size = new System.Drawing.Size(2, 30);
            this.dataGridView16.TabIndex = 653;
            // 
            // nudQuantidade
            // 
            this.nudQuantidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nudQuantidade.BackColor = System.Drawing.Color.WhiteSmoke;
            this.nudQuantidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudQuantidade.Location = new System.Drawing.Point(103, 40);
            this.nudQuantidade.Name = "nudQuantidade";
            this.nudQuantidade.Size = new System.Drawing.Size(244, 20);
            this.nudQuantidade.TabIndex = 652;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblQuantidade.Location = new System.Drawing.Point(3, 40);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(94, 19);
            this.lblQuantidade.TabIndex = 651;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNome.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(421, 6);
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
            this.lblNome.Location = new System.Drawing.Point(361, 8);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(54, 19);
            this.lblNome.TabIndex = 647;
            this.lblNome.Text = "Nome:";
            // 
            // cboEstoque
            // 
            this.cboEstoque.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboEstoque.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboEstoque.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstoque.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboEstoque.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEstoque.FormattingEnabled = true;
            this.cboEstoque.Location = new System.Drawing.Point(78, 6);
            this.cboEstoque.MaxLength = 32;
            this.cboEstoque.Name = "cboEstoque";
            this.cboEstoque.Size = new System.Drawing.Size(269, 23);
            this.cboEstoque.TabIndex = 646;
            // 
            // lblEstoque
            // 
            this.lblEstoque.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEstoque.AutoSize = true;
            this.lblEstoque.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstoque.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblEstoque.Location = new System.Drawing.Point(3, 8);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(69, 19);
            this.lblEstoque.TabIndex = 645;
            this.lblEstoque.Text = "Estoque:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(304, 377);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(107, 30);
            this.btnCadastrar.TabIndex = 644;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
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
            this.dataGridView5.TabIndex = 626;
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
            // lblCadastrarSuprimento
            // 
            this.lblCadastrarSuprimento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCadastrarSuprimento.AutoSize = true;
            this.lblCadastrarSuprimento.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastrarSuprimento.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCadastrarSuprimento.Location = new System.Drawing.Point(237, 9);
            this.lblCadastrarSuprimento.Name = "lblCadastrarSuprimento";
            this.lblCadastrarSuprimento.Size = new System.Drawing.Size(283, 28);
            this.lblCadastrarSuprimento.TabIndex = 567;
            this.lblCadastrarSuprimento.Text = "Cadastrar Suprimento";
            this.lblCadastrarSuprimento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmRegisterSupplies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(710, 459);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.lblCadastrarSuprimento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRegisterSupplies";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register Supplies";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudValor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.RichTextBox rtxDescrição;
        private System.Windows.Forms.Label lblDescrição;
        public System.Windows.Forms.NumericUpDown nudValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.DataGridView dataGridView16;
        public System.Windows.Forms.NumericUpDown nudQuantidade;
        private System.Windows.Forms.Label lblQuantidade;
        protected System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        public System.Windows.Forms.ComboBox cboEstoque;
        private System.Windows.Forms.Label lblEstoque;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label lblCadastrarSuprimento;
    }
}