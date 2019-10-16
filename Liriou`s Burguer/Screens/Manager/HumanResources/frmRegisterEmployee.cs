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

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            try
            {
                Database.Entities.tb_employees employees = new Database.Entities.tb_employees();
                Business.EmployeesBusiness business = new Business.EmployeesBusiness();

                employees.nm_firstName = txtNome.Text.Trim();
                employees.nm_lastName = txtSobrenome.Text.Trim();
                employees.ds_sex = cboGênero.Text.Trim();
                employees.dt_birth = Convert.ToDateTime(dtpNascimento.Value);
                employees.ds_cpf = mtxtCPF.Text.Trim();
                employees.ds_rg = mtxtRG.Text.Trim();
                employees.ds_country = txtPaís.Text.Trim();
                employees.ds_state = cboEstado.Text.Trim();
                employees.ds_cep = lblCEP.Text.Trim();
                employees.ds_complement = txtComplemento.Text.Trim();
                employees.ds_address = txtEndereço.Text.Trim();
                employees.mr_cellphone = mtxtCelular.Text.Trim();
                employees.mr_tellphone = mtxtTelefone.Text.Trim();
                employees.ds_email = txtEmail.Text.Trim();
                employees.ds_password = txtSenha.Text;

                string email = txtEmail.Text;
                Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                Match match = regex.Match(email);
                if (match.Success)
                {
                    frmRegisterEmployee1 tela = new frmRegisterEmployee1();
                    tela.CarregarFuncionario(employees, discounts, function, timecard);
                    tela.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show(email + " é um Email inválido!");
                }
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

        public void CarregarFuncionario(Database.Entities.tb_employees employees, Database.Entities.tb_discounts discounts,
                               Database.Entities.tb_function function, Database.Entities.tb_timecard timecard)
        {
            this.employees = employees;
            this.discounts = discounts;
            this.function = function;
            this.timecard = timecard;


            txtNome.Text = employees.nm_firstName;
            txtSobrenome.Text = employees.nm_lastName;
            cboGênero.Text = employees.ds_sex;
            dtpNascimento.Value = employees.dt_birth;
            mtxtCPF.Text = employees.ds_rg;
            mtxtRG.Text = employees.ds_cpf;
            txtPaís.Text = employees.ds_country;
            cboEstado.Text = employees.ds_state;
            lblCEP.Text = employees.ds_cep;
            txtComplemento.Text = employees.ds_complement;
            txtEndereço.Text = employees.ds_address;
            mtxtCelular.Text = employees.mr_cellphone;
            mtxtTelefone.Text = employees.mr_tellphone;
            txtEmail.Text = employees.ds_email;
            txtSenha.Text = employees.ds_password;
        }

        private void menuInício_Click(object sender, EventArgs e)
        {
            frmManagerMenu managerMenu = new frmManagerMenu();
            managerMenu.Show();
            Hide();
        }

        private void consultarFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultEmployee consultEmployee = new frmConsultEmployee();
            consultEmployee.Show();
            Hide();
        }

        private void alterarFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangeEmployee changeEmployee = new frmChangeEmployee();
            changeEmployee.Show();
            Hide();
        }

        private void dimitirFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
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

        Database.Entities.tb_employees employees;
        Database.Entities.tb_discounts discounts;
        Database.Entities.tb_function function;
        Database.Entities.tb_timecard timecard;

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
