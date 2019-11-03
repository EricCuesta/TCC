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
    public partial class frmRegisterProducts : Form
    {
        public frmRegisterProducts()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Database.Entities.tb_product product = new Database.Entities.tb_product();
                product.nm_product = txtNome.Text.Trim();
                product.ds_typeProduct = cboTipo.Text.Trim();
                product.ds_placeStock = txtLocalDoEstoque.Text.Trim();
                product.vl_amount = Convert.ToInt32(nudQuantidade.Value);
                product.vl_value = nudValor.Value;
                product.ds_note = rtxtDescrição.Text.Trim();

                Business.ProductBusiness busproduct = new Business.ProductBusiness();
                busproduct.Inserir(product);

                MessageBox.Show("Produto cadastrado com sucesso");
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
