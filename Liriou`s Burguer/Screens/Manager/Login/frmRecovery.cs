using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Liriou_s_Burguer.Screens.Login
{
    public partial class frmRecovery : Form
    {
        public frmRecovery()
        {
            InitializeComponent();
            CustomizeDesign();
            panelOpção.Visible = true;
            btnVerificar.Visible = true;
            btnAlterar.Visible = false;
            panelAlterarSenha.Visible = false;
        }

        Database.Entities.tb_employees employees = new Database.Entities.tb_employees();

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboOpção.Text == "RG")
                {
                    employees.nr_rg = mtxtRG.Text.Trim();
                }
                if (cboOpção.Text == "CPF")
                {
                    employees.nr_cpf = mtxtCPF.Text.Trim();
                }
                if (cboOpção.Text == "Número do Celular")
                {
                    employees.nr_cellphone = mtxtCelular.Text.Trim();
                }

                Business.EmployeesBusiness busemp = new Business.EmployeesBusiness();
                busemp.VerificarRecuperação(employees);

                Modificar();
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

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                employees.nr_cpf = mtxtCPF.Text;
                employees.nr_rg = mtxtRG.Text;
                employees.nr_cellphone = mtxtCelular.Text;
                employees.pw_password = txtSenha.Text;

                Business.EmployeesBusiness db = new Business.EmployeesBusiness();
                db.AlterarRecuperação(employees);

                MessageBox.Show("Senha alterada com sucesso");
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

        private void Modificar()
        {
            panelOpção.Visible = false;
            btnVerificar.Visible = false;
            btnAlterar.Visible = true;
            panelAlterarSenha.Visible = true;
        }

        private void CustomizeDesign()
        {
            panelSubMenuRG.Visible = false;
            panelSubMenuCPF.Visible = false;
            panelSubMenuCelular.Visible = false;
        }

        private void HideSubMenu()
        {
            if (panelSubMenuRG.Visible == true)
                panelSubMenuRG.Visible = false;
            if (panelSubMenuCPF.Visible == true)
                panelSubMenuCPF.Visible = false;
            if (panelSubMenuCelular.Visible == true)
                panelSubMenuCelular.Visible = false;
        }

        private void ShowSubMenu(Panel SubMenu)
        {
            if (SubMenu.Visible == false)
            {
                HideSubMenu();
                SubMenu.Visible = true;
            }
            else
            {
                SubMenu.Visible = false;
            }
        }

        private void Limpar()
        {
            mtxtRG.Clear();
            mtxtCPF.Clear();
            mtxtCelular.Clear();
        }

        private void imgVoltar_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
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

        private void imgVoltar_MouseEnter(object sender, EventArgs e)
        {
            imgVoltar.Image = Properties.Resources.Voltar01;
            imgVoltar.Image = Properties.Resources.Voltar02;
        }

        private void imgVoltar_MouseLeave(object sender, EventArgs e)
        {
            imgVoltar.Image = Properties.Resources.Voltar02;
            imgVoltar.Image = Properties.Resources.Voltar01;
        }

        private void cboOpção_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboOpção.Text == "RG")
            {
                HideSubMenu();
                ShowSubMenu(panelSubMenuRG);
                Limpar();     
            }
            else if (cboOpção.Text == "CPF")
            {
                HideSubMenu();
                ShowSubMenu(panelSubMenuCPF);
                Limpar();
            }
            else if (cboOpção.Text == "Número do Celular")
            {
                HideSubMenu();
                ShowSubMenu(panelSubMenuCelular);
                Limpar();
            }
        }
    }
}
