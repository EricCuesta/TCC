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
    public partial class frmConsultSupplies : Form
    {
        private void Consulta()
        {
            Database.Entities.tb_supply supply = new Database.Entities.tb_supply();
            supply.nm_supply = txtNome.Text;

            Business.SupplyBusiness bussupply = new Business.SupplyBusiness();
            List<Database.Entities.tb_supply> supplylista = bussupply.Consultar(supply);

            dgvConsultarSuprimento.DataSource = supplylista;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Business.SupplyBusiness bussupply = new Business.SupplyBusiness();
            List<Database.Entities.tb_supply> supplylista = bussupply.ConsultarTodos();

            dgvConsultarSuprimento.DataSource = supplylista;
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            this.Consulta();
        }
    }
}
