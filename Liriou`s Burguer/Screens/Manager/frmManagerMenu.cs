﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Liriou_s_Burguer.Screens.Manager
{
    public partial class frmManagerMenu : Form
    {
        public frmManagerMenu()
        {
            InitializeComponent();
            CustomizeDesign();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void imgMenu_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 40)
                MenuVertical.Width = 265;
            else
                MenuVertical.Width = 40;
        }

        private void CustomizeDesign()
        {
            panelSubMenuRecursosHumanos.Visible = false;
        }

        private void HideSubMenu()
        {
            if (panelSubMenuRecursosHumanos.Visible == true)
                panelSubMenuRecursosHumanos.Visible = false;
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

        private void btnRecursosHumanos_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSubMenuRecursosHumanos);
        }

        private void btnCadastrarFuncionário_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            HumanResources.frmRegisterEmployee registerEmployee = new HumanResources.frmRegisterEmployee();
            registerEmployee.Show();
            Hide();
        }

        private void btnConsultarFuncionário_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            HumanResources.frmConsultEmployee consultEmployee = new HumanResources.frmConsultEmployee();
            consultEmployee.Show();
            Hide();
        }

        private void btnAlterarFuncionário_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            HumanResources.frmChangeEmployee changeEmployee = new HumanResources.frmChangeEmployee();
            changeEmployee.Show();
            Hide();
        }

        private void btnDemitirFuncionário_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            HumanResources.frmDismissEmployee dismissEmployee = new HumanResources.frmDismissEmployee();
            dismissEmployee.Show();
            Hide();
        }

        private void btnFolhaDePagamento_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            HumanResources.frmPayroll payroll = new HumanResources.frmPayroll();
            payroll.Show();
            Hide();
        }

        private void btnConsultarCartãoDePonto_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            HumanResources.frmConsultTimeCard consultTimeCard = new HumanResources.frmConsultTimeCard();
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
    }
}
