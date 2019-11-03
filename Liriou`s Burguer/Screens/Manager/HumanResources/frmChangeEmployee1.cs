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
            tela.txtNome.Text = employees.firstName;
            tela.txtSobrenome.Text = employees.lastName;
            tela.mtxtCPF.Text = employees.CPF;
            tela.mtxtRG.Text = employees.RG;
            tela.nudDependentes.Value = Convert.ToInt32(employees.dependents);
            tela.cboSexo.Text = employees.sex;
            tela.dtpNascimento.Value = Convert.ToDateTime(employees.birth);
            tela.cboEstado.Text = employees.state;
            tela.mtxtCEP.Text = employees.CEP;
            tela.txtEndereço.Text = employees.address;
            tela.txtComplemento.Text = employees.note;
            tela.mtxtCelular.Text = employees.cellphone;
            tela.mtxtTelefone.Text = employees.tellphone;
            tela.txtEmail.Text = employees.email;
            tela.txtSenha.Text = employees.password;
            tela.ShowDialog();
            tela.Show();
        }
    }
}
