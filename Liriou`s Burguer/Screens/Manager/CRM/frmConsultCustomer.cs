using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Liriou_s_Burguer.Screens.Manager.CRM
{
    public partial class frmConsultCustomer : Form
    {
        public frmConsultCustomer()
        {
            InitializeComponent();
            dgvConsultarCliente.AutoGenerateColumns = false;
        }

        private void Consulta()
        {
            Database.Entities.tb_client client = new Database.Entities.tb_client();
            client.nm_firstName = txtNome.Text.Trim();
            client.nr_rg = mtxtRG.Text;
            if (cboSexo.Text == "Masculino")
            {
                client.ds_sex = "M";
            }
            if (cboSexo.Text == "Feminino")
            {
                client.ds_sex = "F";
            }

            Business.ClientBusiness busclient = new Business.ClientBusiness();
            List<Database.Entities.tb_client> clientlista = busclient.Consultar(client);

            dgvConsultarCliente.DataSource = clientlista;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Business.ClientBusiness busclient = new Business.ClientBusiness();
            List<Database.Entities.tb_client> clientlista = busclient.ConsultarTodos();

            dgvConsultarCliente.DataSource = clientlista;
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            this.Consulta();
        }

        private void mtxtRG_TextChanged(object sender, EventArgs e)
        {
            this.Consulta();
        }

        private void cboSexo_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Consulta();
        }
    }
}
