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
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Carregando.Width += 3;

            if (Carregando.Width >= 800)
            {
                timer1.Stop();

                frmLogin start = new frmLogin();
                start.Show();
                Hide();
            }
        }
    }
}
