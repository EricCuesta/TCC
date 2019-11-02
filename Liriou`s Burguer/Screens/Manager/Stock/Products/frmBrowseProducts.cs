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
    public partial class frmBrowseProducts : Form
    {
        public frmBrowseProducts()
        {
            InitializeComponent();
            dgvConsultarProduto.AutoGenerateColumns = false;
        }

        private void Consulta()
        {
            Database.Entities.tb_product product = new Database.Entities.tb_product();
            product.nm_product = txtNome.Text.Trim();
            product.ds_typeProduct = cboTipo.Text.Trim();

            Business.ProductBusiness busproduct = new Business.ProductBusiness();
            List<Database.Entities.tb_product> productlista = busproduct.Consultar(product);

            dgvConsultarProduto.DataSource = productlista;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Business.ProductBusiness busproduct = new Business.ProductBusiness();
            List<Database.Entities.tb_product> productlista = busproduct.ConsultarTodos();

            dgvConsultarProduto.DataSource = productlista;
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            this.Consulta();
        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Consulta();
        }
    }
}
