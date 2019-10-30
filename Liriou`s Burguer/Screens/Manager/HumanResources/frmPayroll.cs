using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Liriou_s_Burguer.Database.Entities;

namespace Liriou_s_Burguer.Screens.Manager.HumanResources
{
    public partial class frmPayroll : Form
    {
        public frmPayroll()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string rg = mtxtRG.Text;

            Business.FinancialBusiness FB = new Business.FinancialBusiness();
            tb_financial financial = FB.ConsultarFinancial(rg);

            lblBruto.Text = financial.vl_grossSalary.ToString();
        }

        private void btnGerarFolha_Click(object sender, EventArgs e)
        {

        }
    }
}
