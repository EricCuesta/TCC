using System;
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
    public partial class frmDeleteSupplies : Form
    {
        public frmDeleteSupplies()
        {
            InitializeComponent();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(nudId.Value);

            Business.SupplyBusiness bussupplies = new Business.SupplyBusiness();
            bussupplies.Deletar(id);

            MessageBox.Show("Suprimento deletado com sucesso");
        }

        private void nudId_ValueChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(nudId.Value);

            Business.ProductBusiness busproduct = new Business.ProductBusiness();
            Database.Entities.tb_product product = busproduct.ConsultarPorID(id);

            if (product == null)
            {
                cboEstoque.Text = null;
                txtNome.Text = string.Empty;
                nudQuantidade.Value = 0;
                nudValor.Value = Convert.ToInt32("0,00");
                rtxtDescrição.Text = string.Empty;
            }
            else
            {
                cboEstoque.Text = product.ds_typeStock;
                txtNome.Text = product.nm_product;
                nudQuantidade.Value = product.vl_amount;
                nudValor.Value = product.vl_value;
                rtxtDescrição.Text = product.ds_note;
            }
        }
    }
}
