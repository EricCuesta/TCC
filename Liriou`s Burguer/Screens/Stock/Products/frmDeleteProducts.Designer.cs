﻿namespace Liriou_s_Burguer.Screens.Stock.Products
{
    partial class frmDeleteProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeleteProducts));
            this.panel = new System.Windows.Forms.Panel();
            this.txtLocalDoEstoque = new System.Windows.Forms.TextBox();
            this.lblLocalDoStock = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.rtxtDescrição = new System.Windows.Forms.RichTextBox();
            this.lblDescrição = new System.Windows.Forms.Label();
            this.nudValor = new System.Windows.Forms.NumericUpDown();
            this.lblValor = new System.Windows.Forms.Label();
            this.dataGridView16 = new System.Windows.Forms.DataGridView();
            this.nudQuantidade = new System.Windows.Forms.NumericUpDown();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.nudID = new System.Windows.Forms.NumericUpDown();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.lblID = new System.Windows.Forms.Label();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblDeletarProduto = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.BackColor = System.Drawing.Color.Transparent;
            this.panel.Controls.Add(this.txtLocalDoEstoque);
            this.panel.Controls.Add(this.lblLocalDoStock);
            this.panel.Controls.Add(this.dataGridView2);
            this.panel.Controls.Add(this.rtxtDescrição);
            this.panel.Controls.Add(this.lblDescrição);
            this.panel.Controls.Add(this.nudValor);
            this.panel.Controls.Add(this.lblValor);
            this.panel.Controls.Add(this.dataGridView16);
            this.panel.Controls.Add(this.nudQuantidade);
            this.panel.Controls.Add(this.lblQuantidade);
            this.panel.Controls.Add(this.cboTipo);
            this.panel.Controls.Add(this.lblTipo);
            this.panel.Controls.Add(this.txtNome);
            this.panel.Controls.Add(this.lblNome);
            this.panel.Controls.Add(this.dataGridView5);
            this.panel.Controls.Add(this.dataGridView3);
            this.panel.Controls.Add(this.dataGridView6);
            this.panel.Controls.Add(this.nudID);
            this.panel.Controls.Add(this.dataGridView4);
            this.panel.Controls.Add(this.lblID);
            this.panel.Controls.Add(this.btnDeletar);
            this.panel.Controls.Add(this.dataGridView1);
            this.panel.Location = new System.Drawing.Point(0, 41);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(710, 418);
            this.panel.TabIndex = 570;
            // 
            // txtLocalDoEstoque
            // 
            this.txtLocalDoEstoque.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLocalDoEstoque.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtLocalDoEstoque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLocalDoEstoque.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocalDoEstoque.Location = new System.Drawing.Point(121, 102);
            this.txtLocalDoEstoque.MaxLength = 32;
            this.txtLocalDoEstoque.Name = "txtLocalDoEstoque";
            this.txtLocalDoEstoque.ReadOnly = true;
            this.txtLocalDoEstoque.Size = new System.Drawing.Size(586, 23);
            this.txtLocalDoEstoque.TabIndex = 688;
            // 
            // lblLocalDoStock
            // 
            this.lblLocalDoStock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLocalDoStock.AutoSize = true;
            this.lblLocalDoStock.BackColor = System.Drawing.Color.Transparent;
            this.lblLocalDoStock.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalDoStock.ForeColor = System.Drawing.Color.Black;
            this.lblLocalDoStock.Location = new System.Drawing.Point(4, 104);
            this.lblLocalDoStock.Name = "lblLocalDoStock";
            this.lblLocalDoStock.Size = new System.Drawing.Size(111, 19);
            this.lblLocalDoStock.TabIndex = 687;
            this.lblLocalDoStock.Text = "Local do Stock:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(1, 129);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(709, 2);
            this.dataGridView2.TabIndex = 686;
            // 
            // rtxtDescrição
            // 
            this.rtxtDescrição.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtDescrição.Location = new System.Drawing.Point(7, 156);
            this.rtxtDescrição.MaxLength = 256;
            this.rtxtDescrição.Name = "rtxtDescrição";
            this.rtxtDescrição.ReadOnly = true;
            this.rtxtDescrição.Size = new System.Drawing.Size(698, 170);
            this.rtxtDescrição.TabIndex = 685;
            this.rtxtDescrição.Text = "";
            // 
            // lblDescrição
            // 
            this.lblDescrição.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDescrição.AutoSize = true;
            this.lblDescrição.BackColor = System.Drawing.Color.Transparent;
            this.lblDescrição.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescrição.ForeColor = System.Drawing.Color.Black;
            this.lblDescrição.Location = new System.Drawing.Point(4, 134);
            this.lblDescrição.Name = "lblDescrição";
            this.lblDescrição.Size = new System.Drawing.Size(79, 19);
            this.lblDescrição.TabIndex = 684;
            this.lblDescrição.Text = "Descrição:";
            // 
            // nudValor
            // 
            this.nudValor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nudValor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.nudValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudValor.DecimalPlaces = 2;
            this.nudValor.Increment = new decimal(new int[] {
            10,
            0,
            0,
            131072});
            this.nudValor.Location = new System.Drawing.Point(437, 72);
            this.nudValor.Name = "nudValor";
            this.nudValor.ReadOnly = true;
            this.nudValor.Size = new System.Drawing.Size(270, 20);
            this.nudValor.TabIndex = 674;
            // 
            // lblValor
            // 
            this.lblValor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblValor.AutoSize = true;
            this.lblValor.BackColor = System.Drawing.Color.Transparent;
            this.lblValor.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.ForeColor = System.Drawing.Color.Black;
            this.lblValor.Location = new System.Drawing.Point(362, 71);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(69, 19);
            this.lblValor.TabIndex = 673;
            this.lblValor.Text = "Valor: R$";
            // 
            // dataGridView16
            // 
            this.dataGridView16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView16.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView16.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView16.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView16.Location = new System.Drawing.Point(354, 67);
            this.dataGridView16.Name = "dataGridView16";
            this.dataGridView16.Size = new System.Drawing.Size(2, 30);
            this.dataGridView16.TabIndex = 672;
            // 
            // nudQuantidade
            // 
            this.nudQuantidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nudQuantidade.BackColor = System.Drawing.Color.WhiteSmoke;
            this.nudQuantidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudQuantidade.Location = new System.Drawing.Point(104, 71);
            this.nudQuantidade.Name = "nudQuantidade";
            this.nudQuantidade.ReadOnly = true;
            this.nudQuantidade.Size = new System.Drawing.Size(244, 20);
            this.nudQuantidade.TabIndex = 671;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantidade.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.ForeColor = System.Drawing.Color.Black;
            this.lblQuantidade.Location = new System.Drawing.Point(4, 72);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(94, 19);
            this.lblQuantidade.TabIndex = 670;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // cboTipo
            // 
            this.cboTipo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboTipo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboTipo.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Items.AddRange(new object[] {
            "Comida",
            "Bebida"});
            this.cboTipo.Location = new System.Drawing.Point(418, 38);
            this.cboTipo.MaxLength = 32;
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(289, 23);
            this.cboTipo.TabIndex = 669;
            // 
            // lblTipo
            // 
            this.lblTipo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTipo.AutoSize = true;
            this.lblTipo.BackColor = System.Drawing.Color.Transparent;
            this.lblTipo.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ForeColor = System.Drawing.Color.Black;
            this.lblTipo.Location = new System.Drawing.Point(362, 39);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(43, 19);
            this.lblTipo.TabIndex = 668;
            this.lblTipo.Text = "Tipo:";
            // 
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNome.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(64, 38);
            this.txtNome.MaxLength = 32;
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(284, 23);
            this.txtNome.TabIndex = 667;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.Black;
            this.lblNome.Location = new System.Drawing.Point(4, 40);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(54, 19);
            this.lblNome.TabIndex = 666;
            this.lblNome.Text = "Nome:";
            // 
            // dataGridView5
            // 
            this.dataGridView5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView5.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Location = new System.Drawing.Point(1, 97);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.Size = new System.Drawing.Size(709, 2);
            this.dataGridView5.TabIndex = 665;
            // 
            // dataGridView3
            // 
            this.dataGridView3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView3.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(1, 65);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(709, 2);
            this.dataGridView3.TabIndex = 664;
            // 
            // dataGridView6
            // 
            this.dataGridView6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView6.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Location = new System.Drawing.Point(354, 35);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.Size = new System.Drawing.Size(2, 30);
            this.dataGridView6.TabIndex = 663;
            // 
            // nudID
            // 
            this.nudID.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudID.Location = new System.Drawing.Point(45, 6);
            this.nudID.Name = "nudID";
            this.nudID.Size = new System.Drawing.Size(121, 23);
            this.nudID.TabIndex = 661;
            this.nudID.ValueChanged += new System.EventHandler(this.nudID_ValueChanged);
            // 
            // dataGridView4
            // 
            this.dataGridView4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView4.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(1, 33);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(709, 2);
            this.dataGridView4.TabIndex = 660;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.Black;
            this.lblID.Location = new System.Drawing.Point(2, 5);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(37, 26);
            this.lblID.TabIndex = 658;
            this.lblID.Text = "ID:";
            // 
            // btnDeletar
            // 
            this.btnDeletar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDeletar.BackColor = System.Drawing.Color.Transparent;
            this.btnDeletar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletar.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletar.ForeColor = System.Drawing.Color.Black;
            this.btnDeletar.Location = new System.Drawing.Point(305, 377);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(107, 30);
            this.btnDeletar.TabIndex = 644;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = false;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
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
            // lblDeletarProduto
            // 
            this.lblDeletarProduto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDeletarProduto.AutoSize = true;
            this.lblDeletarProduto.BackColor = System.Drawing.Color.Transparent;
            this.lblDeletarProduto.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeletarProduto.ForeColor = System.Drawing.Color.Black;
            this.lblDeletarProduto.Location = new System.Drawing.Point(252, 9);
            this.lblDeletarProduto.Name = "lblDeletarProduto";
            this.lblDeletarProduto.Size = new System.Drawing.Size(207, 28);
            this.lblDeletarProduto.TabIndex = 569;
            this.lblDeletarProduto.Text = "Deletar Produto";
            this.lblDeletarProduto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmDeleteProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Liriou_s_Burguer.Properties.Resources.Fundo;
            this.ClientSize = new System.Drawing.Size(710, 459);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.lblDeletarProduto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDeleteProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete Products";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblDeletarProduto;
        private System.Windows.Forms.NumericUpDown nudID;
        public System.Windows.Forms.NumericUpDown nudValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.DataGridView dataGridView16;
        public System.Windows.Forms.NumericUpDown nudQuantidade;
        private System.Windows.Forms.Label lblQuantidade;
        public System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Label lblTipo;
        protected System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView6;
        private System.Windows.Forms.DataGridView dataGridView4;
        protected System.Windows.Forms.TextBox txtLocalDoEstoque;
        private System.Windows.Forms.Label lblLocalDoStock;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.RichTextBox rtxtDescrição;
        private System.Windows.Forms.Label lblDescrição;
    }
}