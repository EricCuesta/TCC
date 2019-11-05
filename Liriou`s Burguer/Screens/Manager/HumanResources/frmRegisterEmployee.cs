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
                    dt_birth = dtpNascimento.Value.ToLongDateString(),
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

                frmRegisterEmployee1 tela = new frmRegisterEmployee1();
                this.Hide();
                tela.Show();
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
            EmployeesModel.firstName = txtNome.Text;
            EmployeesModel.lastName = txtSenha.Text;
            EmployeesModel.RG = mtxtRG.Text;
            EmployeesModel.CPF = mtxtCPF.Text;
            EmployeesModel.dependents = Convert.ToInt32(nudDependentes.Value);
            EmployeesModel.sex = cboSexo.Text;
            EmployeesModel.birth = dtpNascimento.Value.ToString();
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
    }
}
