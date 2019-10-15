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
                    MessageBox.Show((email + " Está correto"));
                else
                    MessageBox.Show(email + " é um Email inválido!");

                business.Inserir(employees);

                frmRegisterEmployee1 tela = new frmRegisterEmployee1();
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
