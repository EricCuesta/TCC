using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Liriou_s_Burguer.Screens.Manager.HumanResources
{
    public partial class frmChangeEmployee1 : Form
    {
        public frmChangeEmployee1()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {

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

        private void imgVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Model.EmployeesModel employees = new Model.EmployeesModel();
            frmChangeEmployee tela = new frmChangeEmployee();
            tela.txtNome.Text = employees.FirstName;
            tela.txtSobrenome.Text = employees.LastName;
            tela.mtxtCPF.Text = employees.CPF;
            tela.mtxtRG.Text = employees.RG;
            tela.nudDependentes.Value = Convert.ToInt32(employees.Dependents);
            tela.cboSexo.Text = employees.Sex;
            tela.dtpNascimento.Value = Convert.ToDateTime(employees.Birth);
            tela.cboEstado.Text = employees.State;
            tela.mtxtCEP.Text = employees.CEP;
            tela.txtEndereço.Text = employees.Address;
            tela.txtComplemento.Text = employees.Note;
            tela.mtxtCelular.Text = employees.Cellphone;
            tela.mtxtTelefone.Text = employees.Tellphone;
            tela.txtEmail.Text = employees.Email;
            tela.txtSenha.Text = employees.Password;
            tela.ShowDialog();
            tela.Show();
        }

        private void imgMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void imgVoltar_MouseEnter(object sender, EventArgs e)
        {
            imgVoltar.Image = Properties.Resources.Voltar;
            imgVoltar.Image = Properties.Resources.Voltar02;
        }

        private void imgVoltar_MouseLeave(object sender, EventArgs e)
        {
            imgVoltar.Image = Properties.Resources.Voltar02;
            imgVoltar.Image = Properties.Resources.Voltar;
        }
    }
}
