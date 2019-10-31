using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Liriou_s_Burguer.Screens.Manager.Provider
{
    public partial class frmConsultSupplier : Form
    {
        public frmConsultSupplier()
        {
            InitializeComponent();
            dgvConsultarFornecedor.AutoGenerateColumns = false;
        }

        private void Consulta()
        {
            Database.Entities.tb_provider provider = new Database.Entities.tb_provider();
            provider.nm_provider = txtNome.Text;
            provider.ds_typePerson = cboTipoDePessoa.Text;


            Business.ProviderBusiness busprovider = new Business.ProviderBusiness();
            List<Database.Entities.tb_provider> providerlista = busprovider.Consultar(provider);

            dgvConsultarFornecedor.DataSource = providerlista;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Business.ProviderBusiness busprovider = new Business.ProviderBusiness();
            List<Database.Entities.tb_provider> providerlista = busprovider.ConsultarTodos();

            dgvConsultarFornecedor.DataSource = providerlista;
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            this.Consulta();
        }

        private void cboTipoDePessoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Consulta();
        }
    }
}
