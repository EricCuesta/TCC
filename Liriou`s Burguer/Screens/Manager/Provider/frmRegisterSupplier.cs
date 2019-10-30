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
    public partial class frmRegisterSupplier : Form
    {
        public frmRegisterSupplier()
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
                Database.Entities.tb_provider provider = new Database.Entities.tb_provider();
                provider.nm_provider = txtNome.Text;
                provider.nm_name = txtNomeFantásia.Text;
                provider.ds_country = txtPaís.Text;
                provider.ds_state = cboEstado.Text;
                provider.ds_cep = mtxtCEP.Text;
                provider.ds_address = txtEndereço.Text;
                provider.ds_note = txtComplemento.Text;
                provider.nr_cellphone = mtxtCelular.Text;
                provider.nr_tellphone = mtxtTelefone.Text;
                provider.ds_email = txtEmail.Text;

                Business.ProviderBusiness busclient = new Business.ProviderBusiness();
                busclient.Inserir(provider);

                MessageBox.Show("Cliente cadastrado com sucesso");
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
