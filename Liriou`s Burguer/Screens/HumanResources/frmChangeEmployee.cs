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
using Liriou_s_Burguer.Business;
using Liriou_s_Burguer.Database.Entities;

namespace Liriou_s_Burguer.Screens.HumanResources
{
    public partial class frmChangeEmployee : Form
    {
        public frmChangeEmployee()
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

                frmMenu.Current.openContedor(new frmChangeEmployee1());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocorreu um erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        EmployeesBusiness EB = new EmployeesBusiness();
        private void nudID_Leave(object sender, EventArgs e)
        {
            try
            {
                tb_employees emp = EB.ConsultarPorID(Convert.ToInt32(nudID.Value));
                if (emp != null)
                {
                    txtNome.Text = emp.nm_firstName;
                    txtSobrenome.Text = emp.nm_lastName;
                    mtxtRG.Text = emp.nr_rg;
                    mtxtCPF.Text = emp.nr_cpf;
                    nudDependentes.Value = emp.nr_dependents;
                    cboSexo.Text = emp.ds_sex == "M" ? "Masculino" : "Feminino";
                    dtpNascimento.Value = Convert.ToDateTime(emp.dt_birth);
                    cboEstado.Text = emp.ds_state;
                    mtxtCEP.Text = emp.nr_cep;
                    txtEndereço.Text = emp.ds_address;
                    txtComplemento.Text = emp.ds_note;
                    mtxtCelular.Text = emp.nr_cellphone;
                    mtxtTelefone.Text = emp.nr_tellphone;
                    txtEmail.Text = emp.ds_email;
                    txtSenha.Text = emp.pw_password;
                    rdbFuncionário.Checked = Convert.ToBoolean(emp.bt_employee);
                    rdbGerente.Checked = Convert.ToBoolean(emp.bt_manager);
                    chkCRM.Checked = Convert.ToBoolean(emp.bt_crm);
                    chkFornecedor.Checked = Convert.ToBoolean(emp.bt_provider);
                    chkEstoque.Checked = Convert.ToBoolean(emp.bt_stock);
                    chkRH.Checked = Convert.ToBoolean(emp.bt_rh);
                    chkFinanceiro.Checked = Convert.ToBoolean(emp.bt_financial);
                }
                else
                {
                    this.EmptyControls();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocorreu um erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReadControls()
        {
            EmployeesModel.ID = Convert.ToInt32(nudID.Value);
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

        private void EmptyControls()
        {
            txtNome.Text = string.Empty;
            txtSobrenome.Text = string.Empty;
            mtxtRG.Text = string.Empty;
            mtxtCPF.Text = string.Empty;
            nudDependentes.Value = 0;
            dtpNascimento.Value = DateTime.Today;
            cboSexo.Text = "Empty";
            cboEstado.Text = "Empty";
            mtxtCEP.Text = string.Empty;
            txtEndereço.Text = string.Empty;
            txtComplemento.Text = string.Empty;
            mtxtCelular.Text = string.Empty;
            mtxtTelefone.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtSenha.Text = string.Empty;
            rdbFuncionário.Checked = false;
            rdbGerente.Checked = false;
            chkCRM.Checked = false;
            chkFornecedor.Checked = false;
            chkEstoque.Checked = false;
            chkRH.Checked = false;
            chkFinanceiro.Checked = false;
        }

        private void rdbFuncionário_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rdbFuncionário.Checked == true)
            {
                panelAcesso.Visible = true;
            }
        }

        private void rdbGerente_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbGerente.Checked == true)
            {
                panelAcesso.Visible = false;
            }
        }


    }
}
