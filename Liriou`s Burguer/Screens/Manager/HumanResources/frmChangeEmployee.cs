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

namespace Liriou_s_Burguer.Screens.Manager.HumanResources
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
                Database.Entities.tb_employees employees = new Database.Entities.tb_employees();
                employees.nm_firstName = txtNome.Text.Trim();
                employees.nm_lastName = txtSobrenome.Text.Trim();
                employees.nr_rg = mtxtRG.Text.Trim();
                employees.nr_cpf = mtxtCPF.Text.Trim();
                employees.nr_dependents = Convert.ToInt32(nudDependentes.Value);
                employees.ds_sex = cboSexo.Text;
                employees.dt_birth = dtpNascimento.Value.ToLongDateString();
                employees.ds_state = cboEstado.Text;
                employees.nr_cep = mtxtCEP.Text.Trim();
                employees.ds_note = txtComplemento.Text.Trim();
                employees.ds_address = txtEndereço.Text.Trim();
                employees.nr_cellphone = mtxtCelular.Text.Trim();
                employees.nr_tellphone = mtxtTelefone.Text.Trim();
                employees.ds_email = txtEmail.Text.Trim();
                employees.pw_password = txtSenha.Text.Trim();
                employees.bt_manager = rdbGerente.Checked;
                employees.bt_employee = rdbFuncionário.Checked;
                employees.bt_rh = chkRH.Checked;
                employees.bt_financial = chkFinanceiro.Checked;
                employees.bt_stock = chkEstoque.Checked;
                employees.bt_crm = chkCRM.Checked;

                Business.EmployeesBusiness db = new Business.EmployeesBusiness();
                db.Inserir(employees);

                frmRegisterEmployee1 registerEmployee1 = new frmRegisterEmployee1();
                registerEmployee1.ShowDialog();
                Hide();
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

        private void nudId_ValueChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(nudId.Value);

            Business.EmployeesBusiness busemployees = new Business.EmployeesBusiness();
            Database.Entities.tb_employees employees = busemployees.ConsultarPorID(id);

            if (employees == null)
            {
                txtNome.Text = string.Empty;
                txtSobrenome.Text = string.Empty;
                mtxtRG.Text = string.Empty;
                mtxtCPF.Text = string.Empty;
                nudDependentes.Value = 0;
                cboSexo.Text = null;
                dtpNascimento.Value = DateTime.Now;
                cboEstado.Text = null;
                mtxtCEP.Text = string.Empty;
                txtEndereço.Text = string.Empty;
                txtComplemento.Text = string.Empty;
                mtxtCelular.Text = string.Empty;
                mtxtTelefone.Text = string.Empty;
                txtEmail.Text = string.Empty;
                txtSenha.Text = string.Empty;
                rdbFuncionário.Checked = Convert.ToBoolean(string.Empty);
                rdbGerente.Checked = Convert.ToBoolean(string.Empty);
                chkRH.Checked = Convert.ToBoolean(string.Empty);
                chkFinanceiro.Checked = Convert.ToBoolean(string.Empty);
                chkFornecedor.Checked = Convert.ToBoolean(string.Empty);
                chkEstoque.Checked = Convert.ToBoolean(string.Empty);
                chkCRM.Checked = Convert.ToBoolean(string.Empty);
            }
            else
            {
                txtNome.Text = employees.nm_firstName;
                txtSobrenome.Text = employees.nm_lastName;
                mtxtRG.Text = employees.nr_rg;
                mtxtCPF.Text = employees.nr_cpf;
                if (employees.ds_sex == "M")
                    cboSexo.Text = "Masculino";
                else
                    cboEstado.Text = "Feminino";
                nudDependentes.Value = employees.nr_dependents;
                dtpNascimento.Value = Convert.ToDateTime(employees.dt_birth);
                cboEstado.Text = employees.ds_state;
                mtxtCEP.Text = employees.nr_cep;
                txtEndereço.Text = employees.ds_address;
                txtComplemento.Text = employees.ds_note;
                mtxtCelular.Text = employees.nr_cellphone;
                mtxtTelefone.Text = employees.nr_tellphone;
                txtEmail.Text = employees.ds_email;
                txtSenha.Text = employees.pw_password;
                rdbFuncionário.Checked = Convert.ToBoolean(employees.bt_employee);
                rdbGerente.Checked = Convert.ToBoolean(employees.bt_manager);
                chkRH.Checked = Convert.ToBoolean(employees.bt_rh);
                chkFinanceiro.Checked = Convert.ToBoolean(employees.bt_financial);
                chkFornecedor.Checked = Convert.ToBoolean(employees.bt_provider);
                chkEstoque.Checked = Convert.ToBoolean(employees.bt_stock);
                chkCRM.Checked = Convert.ToBoolean(employees.bt_crm);
            }
        }
    }
}
