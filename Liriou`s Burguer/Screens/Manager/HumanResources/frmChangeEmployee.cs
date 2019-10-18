using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Regex;
using System.Text;
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

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            try
            {
                Model.EmployeesModel Model = new Model.EmployeesModel();
                
                Model.firstName = txtNome.Text.Trim();
                Model.lastName = txtSobrenome.Text.Trim();
                Model.Sex = cboGênero.Text.Trim();
                Model.birth = Convert.ToDateTime(dtpNascimento.Value);
                string antigo = mtxtCPF.Text.Trim();
                bool novo = antigo.Contains("/");
                if (novo == true)
                {
                    string alterado = antigo.Replace("/", "");
                    employees.ds_cpf = alterado;
                }

                Model.RG = mtxtRG.Text.Trim();
                Model.country = txtPaís.Text.Trim();
                Model.state = cboEstado.Text.Trim();
                Model.CEP = lblCEP.Text.Trim();
                Model.note = txtComplemento.Text.Trim();
                Model.adress = txtEndereço.Text.Trim();
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
        Database.Entities.tb_employees employees;

        public void CarregarFuncionario2(Database.Entities.tb_employees employees)
        {
            this.employees = employees;

            txtNome.Text = employees.nm_firstName;
            txtSobrenome.Text = employees.nm_lastName;
            cboGênero.Text = employees.ds_sex;
            dtpNascimento.MinDate = employees.dt_birth;
            mtxtCPF.Text = employees.ds_rg;
            mtxtRG.Text = employees.ds_cpf;
            txtPaís.Text = employees.ds_country;
            cboEstado.Text = employees.ds_state;
            lblCEP.Text = employees.ds_cep;
            txtComplemento.Text = employees.ds_note;
            txtEndereço.Text = employees.ds_address;
            mtxtCelular.Text = employees.nr_cellphone;
            mtxtTelefone.Text = employees.nr_tellphone;
            txtEmail.Text = employees.ds_email;
            txtSenha.Text = employees.pw_password;
        }

        private void menuInício_Click(object sender, EventArgs e)
        {
            frmManagerMenu managerMenu = new frmManagerMenu();
            managerMenu.Show();
            Hide();
        }

        private void cadastrarFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmRegisterEmployee registerEmployee = new frmRegisterEmployee();
            registerEmployee.Show();
            Hide();
        }

        private void consultarFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultEmployee consultEmployee = new frmConsultEmployee();
            consultEmployee.Show();
            Hide();
        }

        private void demitirFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDismissEmployee dismissEmployee = new frmDismissEmployee();
            dismissEmployee.Show();
            Hide();
        }

        private void folhaDePagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPayroll payroll = new frmPayroll();
            payroll.Show();
            Hide();
        }

        private void consultarCartãoDePontoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultTimeCard consultTimeCard = new frmConsultTimeCard();
            consultTimeCard.Show();
            Hide();
        }

        private void imgMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void imgFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void imgFechar_MouseEnter(object sender, EventArgs e)
        {
            imgFechar.Image = Properties.Resources.Fechar;
            imgFechar.Image = Properties.Resources.Fechar02;
        }

        private void imgFechar_MouseLeave(object sender, EventArgs e)
        {
            imgFechar.Image = Properties.Resources.Fechar02;
            imgFechar.Image = Properties.Resources.Fechar;
        }

        private void imgMinimizar_MouseEnter(object sender, EventArgs e)
        {
            imgMinimizar.Image = Properties.Resources.Minimizar;
            imgMinimizar.Image = Properties.Resources.Minimizar02;
        }

        private void imgMinimizar_MouseLeave(object sender, EventArgs e)
        {
            imgMinimizar.Image = Properties.Resources.Minimizar02;
            imgMinimizar.Image = Properties.Resources.Minimizar;
        }
    }
}
