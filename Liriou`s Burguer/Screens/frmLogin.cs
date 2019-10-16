using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Liriou_s_Burguer.Screens
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                Database.Entities.tb_employees employees = new Database.Entities.tb_employees();

                employees.ds_email = txtEmail.Text.Trim();
                string email = employees.ds_email;
                employees.pw_password = txtSenha.Text.Trim();
                string senha = employees.pw_password;

                Business.EmployeesBusiness busemp = new Business.EmployeesBusiness();
                string r = busemp.Login(email, senha);

                if (r == "true")
                {
                    this.Hide();
                    Manager.frmManagerMenu tela = new Manager.frmManagerMenu();
                    tela.Show();
                    Hide();
                }
                else if (r == "false")
                {
                    this.Hide();
                    Employee.frmEmployeeMenu tela = new Employee.frmEmployeeMenu();
                    tela.Show();
                    Hide();
                }

                MessageBox.Show(r);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro!","Login",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void imgMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void imgFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblRecuperarSenha_Click(object sender, EventArgs e)
        {
            frmRecovery recovery = new frmRecovery();
            recovery.Show();
            Hide();
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Email do usuário")
                txtEmail.Clear();
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == string.Empty)
                txtEmail.Text = "Email do usuário";
        }

        private void txtSenha_Click(object sender, EventArgs e)
        {
            if (txtSenha.Text == "Senha do usuário")
            {
                txtSenha.Clear();
                txtSenha.UseSystemPasswordChar = true;
            }
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            if (txtSenha.Text == string.Empty)
            {
                txtSenha.Text = "Senha do usuário";
                txtSenha.UseSystemPasswordChar = false;
            }
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            if (txtSenha.Text == "Senha do usuário")
            {
                txtSenha.Clear();
                txtSenha.UseSystemPasswordChar = true;
            }
        }

        private void imgFechar_MouseEnter(object sender, EventArgs e)
        {
            imgFechar.Image = Properties.Resources.Fechar01;
            imgFechar.Image = Properties.Resources.Fechar02;
        }

        private void imgFechar_MouseLeave(object sender, EventArgs e)
        {
            imgFechar.Image = Properties.Resources.Fechar02;
            imgFechar.Image = Properties.Resources.Fechar01;
        }

        private void imgMinimizar_MouseEnter(object sender, EventArgs e)
        {
            imgMinimizar.Image = Properties.Resources.Minimizar01;
            imgMinimizar.Image = Properties.Resources.Minimizar02;
        }

        private void imgMinimizar_MouseLeave(object sender, EventArgs e)
        {
            imgMinimizar.Image = Properties.Resources.Minimizar02;
            imgMinimizar.Image = Properties.Resources.Minimizar01;
        }
    }
}
