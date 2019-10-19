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
                Model.EmployeesModel model = new Model.EmployeesModel();

                model.firstName = txtNome.Text;
                model.lastName = txtSobrenome.Text;
                model.Sex = cboSexo.Text;
                model.birth = dtpNascimento.MinDate;
                model.CPF = mtxtCPF.Text;
                model.RG = mtxtRG.Text;
                model.state = cboEstado.Text;
                model.CEP = mtxtCEP.Text;
                model.note = txtComplemento.Text;
                model.adress = txtEndereço.Text;
                model.cellphone = mtxtCelular.Text;
                model.tellphone = mtxtTelefone.Text;
                model.email = txtEmail.Text;
                model.password = txtSenha.Text;

                ControlAccessibleObject control = new ControlAccessibleObject(txtNome);
                Business.EmployeesBusiness EB = new Business.EmployeesBusiness();
                string r = EB.VerificarCadastro(model);

                if (r == "true")
                {
                    this.Hide();
                    frmRegisterEmployee1 tela = new frmRegisterEmployee1();
                    tela.Show();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void frmRegisterEmployee_Load(object sender, EventArgs e)
        {
            Model.EmployeesModel model = new Model.EmployeesModel();

            txtNome.Text = model.firstName;
            txtSobrenome.Text = model.lastName;
            cboSexo.Text = model.Sex;
            dtpNascimento.MinDate = model.birth;
            mtxtCPF.Text = model.CPF;
            mtxtRG.Text = model.RG;
            cboEstado.Text = model.state;
            mtxtCEP.Text = model.CEP;
            txtComplemento.Text = model.note;
            txtEndereço.Text = model.adress;
            mtxtCelular.Text = model.cellphone;
            mtxtTelefone.Text = model.tellphone;
            txtEmail.Text = model.email;
            txtSenha.Text = model.password;
        }
    }
}
