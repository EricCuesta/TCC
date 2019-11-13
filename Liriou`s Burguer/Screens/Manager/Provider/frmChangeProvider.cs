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
    public partial class frmChangeProvider : Form
    {
        public frmChangeProvider()
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

        private void nudID_ValueChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(nudID.Value);

            Business.ProviderBusiness busprovider = new Business.ProviderBusiness();
            Database.Entities.tb_provider provider = busprovider.ConsultarPorID(id);

            if (provider == null)
            {
                txtNome.Text = string.Empty;
                txtNomeFantásia.Text = string.Empty;
                cboTipoDePessoa.Text = null;
                HideControls();
                Limpar();
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
                txtNome.Text = provider.nm_provider;
                txtNomeFantásia.Text = provider.nm_provider;
                cboTipoDePessoa.Text = provider.ds_typePerson;
                if (cboTipoDePessoa.Text == "Física")
                {
                    mtxtCPF.Text = provider.nr_identification;
                }
                if (cboTipoDePessoa.Text == "Jurídica")
                {
                    mtxtCPF.Text = provider.nr_identification;
                }
                cboEstado.Text = provider.ds_state;
                txtEndereço.Text = provider.ds_address;
                mtxtCEP.Text = provider.nr_cep;
                txtComplemento.Text = provider.ds_note;
                mtxtCelular.Text = provider.nr_cellphone;
                mtxtTelefone.Text = provider.nr_tellphone;
                txtEmail.Text = provider.ds_email;
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                Database.Entities.tb_provider provider = new Database.Entities.tb_provider();
                provider.id_provider = Convert.ToInt32(nudID.Value);
                provider.nm_provider = txtNome.Text.Trim();
                provider.nm_name = txtNomeFantásia.Text.Trim();
                provider.ds_typePerson = cboTipoDePessoa.Text;
                if (cboTipoDePessoa.Text == "Física")
                {
                    provider.ds_typePerson = cboTipoDePessoa.Text;
                    provider.nr_identification = mtxtCPF.Text.Trim();
                }
                if (cboTipoDePessoa.Text == "Jurídica")
                {
                    provider.ds_typePerson = cboTipoDePessoa.Text;
                    provider.nr_identification = mtxtCNPJ.Text.Trim();
                }
                provider.ds_state = cboEstado.Text;
                provider.nr_cep = mtxtCEP.Text.Trim();
                provider.ds_address = txtEndereço.Text.Trim();
                provider.ds_note = txtComplemento.Text.Trim();
                provider.nr_cellphone = mtxtCelular.Text.Trim();
                provider.nr_tellphone = mtxtTelefone.Text.Trim();
                provider.ds_email = txtEmail.Text.Trim();

                Business.ProviderBusiness busprovider = new Business.ProviderBusiness();
                busprovider.Alterar(provider);

                MessageBox.Show("Fornecedor alterado com sucesso","Alterado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void cboTipoDePessoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTipoDePessoa.Text == "Física")
            {
                HideControls();
                Limpar();
                lblCPF.Visible = true;
                mtxtCPF.Visible = true;
            }
            else if (cboTipoDePessoa.Text == "Jurídica")
            {
                HideControls();
                Limpar();
                lblCNPJ.Visible = true;
                mtxtCNPJ.Visible = true;
            }
        }

        private void HideControls()
        {
            lblCPF.Visible = false;
            mtxtCPF.Visible = false;
            lblCNPJ.Visible = false;
            mtxtCNPJ.Visible = false;
        }

        private void Limpar()
        {
            mtxtCPF.Clear();
            mtxtCNPJ.Clear();
        }

        private void mtxtTelefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mtxtTelefone_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
