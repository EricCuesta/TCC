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
            CustomizeDesign();
        }

        private void CustomizeDesign()
        {
            panelCPF.Visible = false;
            panelCNPJ.Visible = false;
        }

        private void HideSubMenu()
        {
            if (panelCPF.Visible == true)
                panelCPF.Visible = false;
            if (panelCNPJ.Visible == true)
                panelCNPJ.Visible = false;
        }

        private void ShowSubMenu(Panel SubMenu)
        {
            if (SubMenu.Visible == false)
            {
                HideSubMenu();
                SubMenu.Visible = true;
            }
            else
            {
                SubMenu.Visible = false;
            }
        }

        private void Limpar()
        {
            mtxtCPF.Clear();
            mtxtCNPJ.Clear();
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

        private void cboTipoDePessoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTipoDePessoa.Text == "Física")
            {
                HideSubMenu();
                ShowSubMenu(panelCPF);
                Limpar();
            }
            if (cboTipoDePessoa.Text == "Jurídica")
            {
                HideSubMenu();
                ShowSubMenu(panelCNPJ);
                Limpar();
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Database.Entities.tb_provider provider = new Database.Entities.tb_provider();
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
                busprovider.Inserir(provider);

                MessageBox.Show("Fornecedor cadastrado com sucesso");
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
