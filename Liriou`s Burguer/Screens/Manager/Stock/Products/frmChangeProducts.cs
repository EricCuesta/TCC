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
    public partial class frmChangeProducts : Form
    {
        public frmChangeProducts()
        {
            InitializeComponent();
        }

        private void nudId_ValueChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(nudId.Value);

            Business.ProductBusiness busproduct = new Business.ProductBusiness();
            Database.Entities.tb_product product = busproduct.ConsultarPorID(id);

            if (product == null)
            {
                txtNome.Text = string.Empty;
                cboTipo.Text = null;
                nudQuantidade.Value = 0;
                nudValor.Value = Convert.ToDecimal("0,00");
                rtxtDescrição.Text = string.Empty;
            }
            else
            {
                txtNome.Text = product.nm_product;
                cboTipo.Text = product.ds_typeProduct;
                nudQuantidade.Value = product.vl_amount;
                nudValor.Value = product.vl_value;
                rtxtDescrição.Text = product.ds_note;
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                Database.Entities.tb_product product = new Database.Entities.tb_product();
                product.id_product = Convert.ToInt32(nudId.Value);
                product.nm_product = txtNome.Text.Trim();
                product.ds_typeProduct = cboTipo.Text.Trim();
                product.vl_amount = Convert.ToInt32(nudQuantidade.Value);
                product.vl_value = nudValor.Value;
                product.ds_note = rtxtDescrição.Text.Trim();

                Business.ProductBusiness busproduct = new Business.ProductBusiness();
                busproduct.Alterar(product);

                MessageBox.Show("Produto alterado com sucesso");
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
