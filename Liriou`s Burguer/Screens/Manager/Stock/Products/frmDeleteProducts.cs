using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Liriou_s_Burguer.Screens.Manager.Stock.Products
{
    public partial class frmDeleteProducts : Form
    {
        public frmDeleteProducts()
        {
            InitializeComponent();
        }

        private void nudID_ValueChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(nudID.Value);

            Business.ProductBusiness busproduct = new Business.ProductBusiness();
            Database.Entities.tb_product product = busproduct.ConsultarPorID(id);

            if (product == null)
            {
                txtNome.Text = string.Empty;
                cboTipo.Text = null;
                txtLocalDoEstoque.Text = string.Empty;
                nudQuantidade.Value = 0;
                nudValor.Value = Convert.ToDecimal("0,00");
                rtxtDescrição.Text = string.Empty;
            }
            else
            {
                txtNome.Text = product.nm_product;
                cboTipo.Text = product.ds_typeProduct;
                txtLocalDoEstoque.Text = product.ds_placeStock;
                nudQuantidade.Value = product.vl_amount;
                nudValor.Value = product.vl_value;
                rtxtDescrição.Text = product.ds_note;
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(nudID.Value);

            Business.ProductBusiness busproduct = new Business.ProductBusiness();
            busproduct.Remover(id);

            MessageBox.Show("Produto deletado com sucesso","Deletado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
