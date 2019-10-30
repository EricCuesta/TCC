﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Liriou_s_Burguer.Screens.Manager.Stock.Supplies
{
    public partial class frmChangeSupplies : Form
    {
        public frmChangeSupplies()
        {
            InitializeComponent();
        }

        private void nudId_ValueChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(nudId.Value);

            Business.SupplyBusiness bussupply = new Business.SupplyBusiness();
            Database.Entities.tb_supply supply = bussupply.ConsultarPorID(id);

            if (supply == null)
            {
                cboEstoque.Text = null;
                txtNome.Text = string.Empty;
                nudQuantidade.Value = 0;
                nudValor.Value = Convert.ToInt32("0,00");
                rtxtDescrição.Text = string.Empty;
            }
            else
            {
                cboEstoque.Text = supply.ds_typeStock;
                txtNome.Text = supply.nm_supply;
                nudQuantidade.Value = supply.vl_amount;
                nudValor.Value = supply.vl_value;
                rtxtDescrição.Text = supply.ds_note;
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                Database.Entities.tb_supply supply = new Database.Entities.tb_supply();
                supply.nm_supply = txtNome.Text;
                supply.ds_typeStock = cboEstoque.Text;
                supply.vl_amount = Convert.ToInt32(nudQuantidade.Value);
                supply.vl_value = nudValor.Value;
                supply.ds_note = rtxtDescrição.Text;

                Business.SupplyBusiness bussupply = new Business.SupplyBusiness();
                bussupply.Inserir(supply);

                MessageBox.Show("Suprimento cadastrado com sucesso");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}