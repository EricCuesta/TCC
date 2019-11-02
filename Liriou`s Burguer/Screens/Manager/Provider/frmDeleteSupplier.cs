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
    public partial class frmDeleteSupplier : Form
    {
        public frmDeleteSupplier()
        {
            InitializeComponent();
            CustomizeDesign();
        }

        private void CustomizeDesign()
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

        private void cboTipoDePessoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTipoDePessoa.Text == "Física")
            {
                lblCNPJ.Visible = false;
                mtxtCNPJ.Visible = false;
                lblCPF.Visible = true;
                mtxtCPF.Visible = true;
                Limpar();
            }
            if (cboTipoDePessoa.Text == "Jurídica")
            {
                lblCPF.Visible = false;
                mtxtCPF.Visible = false;
                lblCNPJ.Visible = true;
                mtxtCNPJ.Visible = true;
                Limpar();
            }
        }

        private void nudId_ValueChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(nudId.Value);

            Business.ProviderBusiness busprovider = new Business.ProviderBusiness();
            Database.Entities.tb_provider provider = busprovider.ConsultarPorID(id);

            if (provider == null)
            {
                txtNome.Text = string.Empty;
                txtNomeFantásia.Text = string.Empty;
                cboTipoDePessoa.Text = null;
                CustomizeDesign();
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
                mtxtCEP.Text = provider.ds_cep;
                txtComplemento.Text = provider.ds_note;
                mtxtCelular.Text = provider.nr_cellphone;
                mtxtTelefone.Text = provider.nr_tellphone;
                txtEmail.Text = provider.ds_email;
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(nudId.Value);

            Business.ClientBusiness busclient = new Business.ClientBusiness();
            busclient.Deletar(id);

            MessageBox.Show("Fornecedor deletado com sucesso");
        }
    }
}
