using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using Liriou_s_Burguer.Database.Entities;
using Liriou_s_Burguer.Business;
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                tb_employees tbemployees = new tb_employees();
                tb_discounts tbdiscounts = new tb_discounts();
                tb_function tbfunction = new tb_function();
                tb_timecard tbtimecard = new tb_timecard();
                tb_financial financial = new tb_financial();
                tb_benefits tbbenefits = new tb_benefits();
                tb_department tb_Department = new tb_department();

                EmployeesBusiness busemployees = new EmployeesBusiness();
                DiscountsBusiness busdiscounts = new DiscountsBusiness();
                FunctionBusiness busfunction = new FunctionBusiness();
                TimeCardBusiness bustimecard = new TimeCardBusiness();
                FinancialBusiness busfinancial = new FinancialBusiness();
                BenefitsBusiness busbenefits = new BenefitsBusiness();
                DepartmentBusiness busdepartment = new DepartmentBusiness();

                tbemployees.dt_hiring = dtpContratação.Value;
                tbemployees.dt_resignation = dtpDemissão.Value;
                financial.vl_grossSalary = nudSalárioBruto.Value;
                tbbenefits.bl_food = chkValeAlimentação.Checked;
                tbbenefits.bl_meal = chkValeRefeição.Checked;
                tbbenefits.bl_lifeSafe = chkSeguroDeVida.Checked;
                tb_Department.nm_department = cboDepartamento.Text;
                tbfunction.nm_function = cboCargo.Text;
                tbbenefits.bl_transport = chkValeTransporte.Checked;
                tbbenefits.bl_planHealth = chkPlanoDeSáude.Checked;
                tbbenefits.bl_planDental = chkPlanoDental.Checked;


                busemployees.Inserir(tbemployees);
                busdiscounts.Inserir(tbdiscounts);
                busfunction.Inserir(tbfunction);
                bustimecard.Inserir(tbtimecard);
                busfinancial.Inserir(financial);
                busbenefits.Inserir(tbbenefits);
                busdepartment.Inserir(tb_Department);

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

        Database.Entities.tb_employees employees;

        public void CarregarFuncionario(Database.Entities.tb_employees employees)
        {
            this.employees = employees;
          
        }

        private void imgMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void imgVoltar_Click(object sender, EventArgs e)
        {
            frmRegisterEmployee tela = new frmRegisterEmployee();
            Model.EmployeesModel model = new Model.EmployeesModel();

            this.Hide();
            tela.Show(); 
        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {

        }
    }
}
