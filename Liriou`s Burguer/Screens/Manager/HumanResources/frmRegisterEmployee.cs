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

                model.FirstName = txtNome.Text;
                model.LastName = txtSobrenome.Text;
                model.Sex = cboSexo.Text;
                model.Birth = dtpNascimento.MinDate;
                model.CPF = mtxtCPF.Text;
                model.RG = mtxtRG.Text;
                model.State = cboEstado.Text;
                model.CEP = mtxtCEP.Text;
                model.Note = txtComplemento.Text;
                model.Address = txtEndereço.Text;
                model.Cellphone = mtxtCelular.Text;
                model.Tellphone = mtxtTelefone.Text;
                model.Email = txtEmail.Text;
                model.Password = txtSenha.Text;

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
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro. Tente mais tarde.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            txtNome.Text = model.FirstName;
            txtSobrenome.Text = model.LastName;
            cboSexo.Text = model.Sex;
            dtpNascimento.MinDate = model.Birth;
            mtxtCPF.Text = model.CPF;
            mtxtRG.Text = model.RG;
            cboEstado.Text = model.State;
            mtxtCEP.Text = model.CEP;
            txtComplemento.Text = model.Note;
            txtEndereço.Text = model.Address;
            mtxtCelular.Text = model.Cellphone;
            mtxtTelefone.Text = model.Tellphone;
            txtEmail.Text = model.Email;
            txtSenha.Text = model.Password;
        }

        private void mtxtCEP_Enter(object sender, EventArgs e)
        {
            string CEP = mtxtRG.Text;
            CorreioApi.CorreioApi api = new CorreioApi.CorreioApi();
            txtEndereço.Text = api.Buscar(CEP);

        }

        private void mtxtCEP_Leave(object sender, EventArgs e)
        {
            string CEP = mtxtRG.Text;
            CorreioApi.CorreioApi api = new CorreioApi.CorreioApi();
            txtEndereço.Text = api.Buscar(CEP);

        }
    }
}
