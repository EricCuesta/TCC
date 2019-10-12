using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Liriou_s_Burguer.Screens.Manager
{
    public partial class frmStart : Form
    {
        public frmStart()
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

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.ShowDialog();
            Hide();
        }
    }
}
