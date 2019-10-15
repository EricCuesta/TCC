using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Liriou_s_Burguer.Screens.Manager.HumanResources
{
    public partial class frmRegisterEmployee1 : Form
    {
        public frmRegisterEmployee1()
        {
            InitializeComponent();
        }

        Database.Entities.tb_employees employees;
        Database.Entities.tb_discounts discounts;
        Database.Entities.tb_function function;
        Database.Entities.tb_timecard timecard;

        public void CarregarFuncionario(Database.Entities.tb_employees employees, Database.Entities.tb_discounts discounts,
                               Database.Entities.tb_function function, Database.Entities.tb_timecard timecard)
        {
            this.employees = employees;
            this.discounts = discounts;
            this.function = function;
            this.timecard = timecard;
        }

        private void imgMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void imgVoltar_Click(object sender, EventArgs e)
        {
            frmRegisterEmployee registerEmployee = new frmRegisterEmployee();
            registerEmployee.CarregarFuncionario(this.employees, discounts, function, timecard);
            registerEmployee.Show();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Database.Entities.tb_employees tbemployees = new Database.Entities.tb_employees();

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

        private void frmRegisterEmployee1_Load(object sender, EventArgs e)
        {

        }
    }
}
