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
            panelVerificador.Visible = true;
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

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

        }

        private void CustomizeDesign()
        {
            panelSubMenuRG.Visible = true;
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

        private void imgMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void imgFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRG_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSubMenuRG);
        }

        private void btnCPF_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSubMenuCPF);
        }

        private void btnCelular_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSubMenuCelular);
        }

        private void btnTelefone_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSubMenuTelefone);
        }
    }
}
