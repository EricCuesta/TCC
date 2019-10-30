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
    public partial class frmRegisterSupplies : Form
    {
        public frmRegisterSupplies()
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
