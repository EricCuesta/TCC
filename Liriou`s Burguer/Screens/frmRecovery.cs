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
    public partial class frmRecovery : Form
    {
        public frmRecovery()
        {
            InitializeComponent();
            panelVerificador.Visible = false;
            btnVerificar.Visible = true;
            btnAlterar.Visible = false;
            panelAlterarSenha.Visible = false;
        }

        private void Modificar()
        {
            panelVerificador.Visible = false;
            btnVerificar.Visible = false;
            btnAlterar.Visible = true;
            panelAlterarSenha.Visible = true;
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            try
            {
                Database.Entities.tb_employees employees = new Database.Entities.tb_employees();

                if (cboOpção.Text == "RG")
                {
                    ShowSubMenu(panelSubMenuRG);
                    employees.ds_rg = mtxtRG.Text.Trim();
                }
                else if (cboOpção.Text == "CPF")
                {
                    ShowSubMenu(panelSubMenuCPF);
                    employees.ds_cpf = mtxtCPF.Text.Trim();
                }
                else if (cboOpção.Text == "Número do Celular")
                {
                    ShowSubMenu(panelSubMenuCelular);
                    employees.mr_cellphone = mtxtCelular.Text.Trim();
                }
                else if (cboOpção.Text == "Número do Telefone")
                {
                    ShowSubMenu(panelSubMenuTelefone);
                    employees.mr_tellphone = mtxtTelefone.Text.Trim();
                }

                Business.EmployeesBusiness busemp = new Business.EmployeesBusiness();
                busemp.Verificar(employees);

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
                Database.Entities.tb_employees employees = new Database.Entities.tb_employees();
                employees.ds_password = txtSenha.Text.Trim();

                Business.EmployeesBusiness busemp = new Business.EmployeesBusiness();
                busemp.AlterarRecuperação(employees);

                MessageBox.Show("Senha Alterada com sucesso");
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

        private void CustomizeDesign()
        {
            panelSubMenuRG.Visible = false;
            panelSubMenuCPF.Visible = false;
            panelSubMenuCelular.Visible = false;
            panelSubMenuTelefone.Visible = false;
        }

        private void HideSubMenu()
        {
            if (panelSubMenuRG.Visible == true)
                panelSubMenuRG.Visible = false;
            if (panelSubMenuCPF.Visible == true)
                panelSubMenuCPF.Visible = false;
            if (panelSubMenuCelular.Visible == true)
                panelSubMenuCelular.Visible = false;
            if (panelSubMenuTelefone.Visible == true)
                panelSubMenuTelefone.Visible = false;
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

        private void cboOpção_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboOpção.Text == "RG")
            {
                ShowSubMenu(panelSubMenuRG);
            }
            else if (cboOpção.Text == "CPF")
            {
                ShowSubMenu(panelSubMenuCPF);
            }
            else if (cboOpção.Text == "Número do Celular")
            {
                ShowSubMenu(panelSubMenuCelular);
            }
            else if (cboOpção.Text == "Número do Telefone")
            {
                ShowSubMenu(panelSubMenuTelefone);
            }
        }
    }
}
