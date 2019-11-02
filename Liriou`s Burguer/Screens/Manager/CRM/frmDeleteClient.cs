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
    public partial class frmDeleteClient : Form
    {
        public frmDeleteClient()
        {
            InitializeComponent();
        }

        private void nudId_ValueChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(nudId.Value);

            Business.ClientBusiness busclient = new Business.ClientBusiness();
            Database.Entities.tb_client client = busclient.ConsultarPorID(id);

            if (client == null)
            {
                txtNome.Text = string.Empty;
                txtSobrenome.Text = string.Empty;
                mtxtRG.Text = string.Empty;
                mtxtCPF.Text = string.Empty;
                cboSexo.Text = null;
                dtpNascimento.Value = DateTime.Now;
                cboEstado.Text = null;
                txtEndereço.Text = string.Empty;
                mtxtCEP.Text = string.Empty;
                txtComplemento.Text = string.Empty;
                mtxtCelular.Text = string.Empty;
                mtxtTelefone.Text = string.Empty;
                txtEmail.Text = string.Empty;
            }
            else
            {
                txtNome.Text = client.nm_firstName;
                txtSobrenome.Text = client.nm_lastName;
                mtxtRG.Text = client.ds_rg;
                mtxtCPF.Text = client.ds_cpf;
                if (client.ds_sex == "M")
                    cboSexo.Text = "Masculino";
                else
                    cboEstado.Text = "Feminino";
                dtpNascimento.Value = client.dt_birth;
                cboEstado.Text = client.ds_state;
                mtxtCEP.Text = client.ds_cep;
                txtEndereço.Text = client.ds_address;
                txtComplemento.Text = client.ds_note;
                mtxtCelular.Text = client.nr_cellphone;
                mtxtTelefone.Text = client.nr_tellphone;
                txtEmail.Text = client.ds_email;
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(nudId.Value);

            Business.ClientBusiness busclient = new Business.ClientBusiness();
            busclient.Deletar(id);

            MessageBox.Show("Cliente deletado com sucesso");
        }
    }
}
