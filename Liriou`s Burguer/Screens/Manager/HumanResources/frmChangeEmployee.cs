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

        Database.Entities.tb_employees employees;

        public void CarregarFuncionario2(Database.Entities.tb_employees employees)
        {
            this.employees = employees;

            txtNome.Text = employees.nm_firstName;
            txtSobrenome.Text = employees.nm_lastName;
            cboSexo.Text = employees.ds_sex;
            dtpNascimento.MinDate = employees.dt_birth;
            mtxtCPF.Text = employees.nr_rg;
            mtxtRG.Text = employees.nr_cpf;
            cboEstado.Text = employees.ds_state;
            lblCEP.Text = employees.nr_cep;
            txtComplemento.Text = employees.ds_note;
            txtEndereço.Text = employees.ds_address;
            mtxtCelular.Text = employees.nr_cellphone;
            mtxtTelefone.Text = employees.nr_tellphone;
            txtEmail.Text = employees.ds_email;
            txtSenha.Text = employees.pw_password;
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

        private void mtxtCEP_TextChanged_1(object sender, EventArgs e)
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
                Model.EmployeesModel Model = new Model.EmployeesModel();

                Model.firstName = txtNome.Text.Trim();
                Model.lastName = txtSobrenome.Text.Trim();
                Model.sex = cboSexo.Text.Trim();
                Model.birth = Convert.ToDateTime(dtpNascimento.Value);
                Model.RG = mtxtRG.Text.Trim();
                Model.state = cboEstado.Text.Trim();
                Model.CEP = lblCEP.Text.Trim();
                Model.note = txtComplemento.Text.Trim();
                Model.address = txtEndereço.Text.Trim();
                Model.cellphone = mtxtCelular.Text.Trim();
                Model.tellphone = mtxtTelefone.Text.Trim();
                Model.email = txtEmail.Text.Trim();
                Model.password = txtSenha.Text;

                string email = txtEmail.Text;
                Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                Match match = regex.Match(email);
                if (match.Success)
                {
                    frmChangeEmployee1 tela2 = new frmChangeEmployee1();

                    tela2.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show(email + " é um Email inválido!");
                }

                frmChangeEmployee1 tela = new frmChangeEmployee1();
                tela.Show();
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
    }
}
