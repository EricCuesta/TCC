using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Liriou_s_Burguer.Screens.CRM
{
    public partial class frmRegisterCustomer : Form
    {
        public frmRegisterCustomer()
        {
            InitializeComponent();
        }

        private void mtxtCEP_TextChanged(object sender, EventArgs e)
        {
            if (mtxtCEP.Text.Length == 9)
            {
                string CEP = mtxtCEP.Text;
                CorreioApi.CorreioApi api = new CorreioApi.CorreioApi();
                txtEndereço.Text = api.Buscar(CEP);
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Database.Entities.tb_client client = new Database.Entities.tb_client();
                client.nm_firstName = txtNome.Text;
                client.nm_lastName = txtSobrenome.Text;
                client.nr_rg = mtxtRG.Text;
                client.nr_cpf = mtxtCPF.Text;
                client.ds_sex = cboSexo.Text;
                client.dt_birth = dtpNascimento.Value.ToShortDateString();
                client.ds_state = cboEstado.Text;
                client.nr_cep = mtxtCEP.Text;
                client.ds_address = txtEndereço.Text;
                client.ds_note = txtComplemento.Text;
                client.nr_cellphone = mtxtCelular.Text;
                client.nr_tellphone = mtxtTelefone.Text;
                client.ds_email = txtEmail.Text;

                Business.ClientBusiness busclient = new Business.ClientBusiness();
                busclient.Inserir(client);

                MessageBox.Show("Cliente cadastrado com sucesso","Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
