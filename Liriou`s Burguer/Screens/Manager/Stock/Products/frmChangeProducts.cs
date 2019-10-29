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
            this.loadcombo();
        }
        public void loadcombo()
        {
            Database.StockDatabase db = new Database.StockDatabase();
            List<Database.Entities.tb_stock> list = db.ListarEstoque();

            cboEstoque.DisplayMember = nameof(Database.Entities.tb_stock.nm_stock);
            cboEstoque.DataSource = list;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

        }
    }
}
