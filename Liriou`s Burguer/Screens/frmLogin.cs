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

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                Database.Entities.tb_employees employees = new Database.Entities.tb_employees();

                employees.ds_email = txtEmail.Text.Trim();
                string email = employees.ds_email;
                employees.ds_password = txtSenha.Text.Trim();
                string senha = employees.ds_password;

                Business.EmployeesBusiness busemp = new Business.EmployeesBusiness();
                //bool verificação = busemp.Login(email, senha);

                //if (verificação == true)
                //{
                //    Manager.frmManagerMenu tela = new Manager.frmManagerMenu();
                //    tela.Show();
                //    this.Hide();
                //}
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
