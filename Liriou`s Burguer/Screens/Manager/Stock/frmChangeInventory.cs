using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Liriou_s_Burguer.Screens.Manager.Stock
{
    public partial class frmChangeInventory : Form
    {
        public frmChangeInventory()
        {
            InitializeComponent();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                Database.Entities.tb_stock stock = new Database.Entities.tb_stock();
                stock.ds_place = txtLocal.Text;
                stock.ds_typeStock = cboTipo.Text;
                stock.nr_maxAmount = Convert.ToInt32(nudQtdMáximo.Value);

                Business.StockBusiness busstock = new Business.StockBusiness();
                busstock.Inserir(stock);

                MessageBox.Show("Estoque cadastrado com sucesso");
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

        private void nudId_ValueChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(nudId.Value);

            Business.StockBusiness busstock = new Business.StockBusiness();
            Database.Entities.tb_stock stock = busstock.ConsultarPorID(id);

            if (stock == null)
            {
                txtLocal.Text = string.Empty;
                cboTipo.Text = null;
                nudQtdMáximo.Value = 0;

            }
            else
            {
                txtLocal.Text = stock.ds_place;
                cboTipo.Text = stock.ds_typeStock;
                nudQtdMáximo.Value = Convert.ToDecimal(stock.nr_maxAmount);
            }
        }
    }
}
