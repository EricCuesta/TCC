using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Liriou_s_Burguer.Screens.Employee
{
    public partial class frmUnavailability : Form
    {
        public frmUnavailability()
        {
            InitializeComponent();
        }

        private void inícioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmployeeMenu employeeMenu = new frmEmployeeMenu();
            employeeMenu.Show();
            Hide();
        }

        private void cartãoDePontoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmEmployeeTimeCard employeeTimeCard = new frmEmployeeTimeCard();
            employeeTimeCard.Show();
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
