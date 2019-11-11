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

namespace Liriou_s_Burguer.Screens.Manager.HumanResources
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
                this.InserirModel();

                Database.Entities.tb_employees employees = new Database.Entities.tb_employees
                {
                    nm_firstName = txtNome.Text.Trim(),
                    nm_lastName = txtSobrenome.Text.Trim(),
                    nr_rg = mtxtRG.Text.Trim(),
                    nr_cpf = mtxtCPF.Text.Trim(),
                    nr_dependents = Convert.ToInt32(nudDependentes.Value),
                    ds_sex = cboSexo.Text,
                    dt_birth = dtpNascimento.Value.ToShortDateString(),
                    ds_state = cboEstado.Text,
                    nr_cep = mtxtCEP.Text.Trim(),
                    ds_note = txtComplemento.Text.Trim(),
                    ds_address = txtEndereço.Text.Trim(),
                    nr_cellphone = mtxtCelular.Text.Trim(),
                    nr_tellphone = mtxtTelefone.Text.Trim(),
                    ds_email = txtEmail.Text.Trim(),
                    pw_password = txtSenha.Text.Trim(),
                    bt_manager = rdbGerente.Checked,
                    bt_employee = rdbFuncionário.Checked,
                    bt_rh = chkRH.Checked,
                    bt_financial = chkFinanceiro.Checked,
                    bt_stock = chkEstoque.Checked,
                    bt_crm = chkCRM.Checked
                };

                Business.EmployeesBusiness db = new Business.EmployeesBusiness();
                db.Inserir(employees);

                frmMenu.Current.openContedor(new frmRegisterEmployee1());
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

        private void InserirModel()
        {
            Model.EmployeesModel.firstName = txtNome.Text;
            Model.EmployeesModel.lastName = txtSenha.Text;
            Model.EmployeesModel.RG = mtxtRG.Text;
            Model.EmployeesModel.CPF = mtxtCPF.Text;
            Model.EmployeesModel.dependents = Convert.ToInt32(nudDependentes.Value);
            Model.EmployeesModel.sex = cboSexo.Text;
            Model.EmployeesModel.birth = dtpNascimento.Value.ToShortDateString();
            Model.EmployeesModel.state = cboEstado.Text;
            Model.EmployeesModel.CEP = mtxtCEP.Text;
            Model.EmployeesModel.address = txtEndereço.Text;
            Model.EmployeesModel.note = txtComplemento.Text;
            Model.EmployeesModel.cellphone = mtxtCelular.Text;
            Model.EmployeesModel.tellphone = mtxtTelefone.Text;
            Model.EmployeesModel.email = txtEmail.Text;
            Model.EmployeesModel.password = txtSenha.Text;
            Model.EmployeesModel.employeer = rdbFuncionário.Checked;
            Model.EmployeesModel.manager = rdbGerente.Checked;
            Model.EmployeesModel.CRM = chkCRM.Checked;
            Model.EmployeesModel.Provider = chkFornecedor.Checked;
            Model.EmployeesModel.stock = chkEstoque.Checked;
            Model.EmployeesModel.RH = chkRH.Checked;
            Model.EmployeesModel.financial = chkFinanceiro.Checked;
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
