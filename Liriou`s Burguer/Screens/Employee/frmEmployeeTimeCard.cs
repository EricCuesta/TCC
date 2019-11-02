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
    public partial class frmEmployeeTimeCard : Form
    {
        public frmEmployeeTimeCard()
        {
            InitializeComponent();
        }

        private void DataHora_Tick(object sender, EventArgs e)
        {
            lblHorárioData.Text = DateTime.Now.ToString("dd/MM/yyyy    hh:mm:ss");
        }
    }
}
