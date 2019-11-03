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
                employees.bt_admin = chkAdministrador.Checked;
                employees.bt_funcionaro = chkFuncionário.Checked;
                employees.bt_rh = chkRH.Checked;
                employees.bt_financial = chkFinanceiro.Checked;
                employees.bt_stock = chkEstoque.Checked;
                employees.bt_crm = chkCRM.Checked;

                Business.EmployeesBusiness db = new Business.EmployeesBusiness();
                db.Inserir(employees);

                frmRegisterEmployee1 registerEmployee1 = new frmRegisterEmployee1();
                registerEmployee1.ShowDialog();
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
