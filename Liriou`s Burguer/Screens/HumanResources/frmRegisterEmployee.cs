using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Liriou_s_Burguer.Model;

namespace Liriou_s_Burguer.Screens.HumanResources
{
    public partial class frmRegisterEmployee : Form
    {
        public frmRegisterEmployee()
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

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            try
            {
                this.ReadControls();

                frmMenu.Current.openContedor(new frmRegisterEmployee1());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocorreu um Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReadControls()
        {
            EmployeesModel.firstName = txtNome.Text;
            EmployeesModel.lastName = txtSobrenome.Text;
            EmployeesModel.RG = mtxtRG.Text;
            EmployeesModel.CPF = mtxtCPF.Text;
            EmployeesModel.dependents = Convert.ToInt32(nudDependentes.Value);
            EmployeesModel.sex = cboSexo.Text;
            EmployeesModel.birth = dtpNascimento.Value.ToShortDateString();
            EmployeesModel.state = cboEstado.Text;
            EmployeesModel.CEP = mtxtCEP.Text;
            EmployeesModel.address = txtEndereço.Text;
            EmployeesModel.note = txtComplemento.Text;
            EmployeesModel.cellphone = mtxtCelular.Text;
            EmployeesModel.tellphone = mtxtTelefone.Text;
            EmployeesModel.email = txtEmail.Text;
            EmployeesModel.password = txtSenha.Text;
            EmployeesModel.employeer = rdbFuncionário.Checked;
            EmployeesModel.manager = rdbGerente.Checked;
            EmployeesModel.CRM = chkCRM.Checked;
            EmployeesModel.Provider = chkFornecedor.Checked;
            EmployeesModel.stock = chkEstoque.Checked;
            EmployeesModel.RH = chkRH.Checked;
            EmployeesModel.financial = chkFinanceiro.Checked;
        }

        private void rdbFuncionário_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbFuncionário.Checked == true)
            {
                panelFunções.Visible = true;
            }
        }

        private void rdbGerente_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbGerente.Checked == true)
            {
                panelFunções.Visible = false;
            }
        }
    }
}
