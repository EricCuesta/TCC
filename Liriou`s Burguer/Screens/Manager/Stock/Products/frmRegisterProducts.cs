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
            this.loadcombo();
        }
        public void loadcombo()
        {
            Database.StockDatabase db = new Database.StockDatabase();
            List<Database.Entities.tb_stock> list = db.ListarEstoque();

            cboEstoque.DisplayMember = nameof(Database.Entities.tb_stock.ds_typeStock);
            cboEstoque.DataSource = list;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Database.Entities.tb_product product = new Database.Entities.tb_product();
                product.nm_product = txtNome.Text;
                product.ds_typeStock = cboEstoque.Text;
                product.ds_typeProduct = cboTipo.Text;
                product.vl_amount = Convert.ToInt32(nudQuantidade.Value);
                product.vl_value = nudValor.Value;
                product.ds_note = rtxtDescrição.Text;

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
