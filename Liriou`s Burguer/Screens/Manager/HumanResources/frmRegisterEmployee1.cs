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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Database.Entities.tb_employees tbemployees = new Database.Entities.tb_employees();
                Database.Entities.tb_discounts tbdiscounts = new Database.Entities.tb_discounts();
                Database.Entities.tb_function tbfunction = new Database.Entities.tb_function();
                Database.Entities.tb_timecard tbtimecard = new Database.Entities.tb_timecard();
                Database.Entities.tb_financial financial = new Database.Entities.tb_financial();
                Database.Entities.tb_benefits tbbenefits = new Database.Entities.tb_benefits();
                Database.Entities.tb_department tb_Department = new Database.Entities.tb_department();
                Business.EmployeesBusiness busemployees = new Business.EmployeesBusiness();
                Business.DiscountsBusiness busdiscounts = new Business.DiscountsBusiness();
                Business.FunctionBusiness busfunction = new Business.FunctionBusiness();
                Business.TimeCardBusiness bustimecard = new Business.TimeCardBusiness();
                Business.FinancialBusiness busfinancial = new Business.FinancialBusiness();
                Business.BenefitsBusiness busbenefits = new Business.BenefitsBusiness();
                Business.DepartmentBusiness busdepartment = new Business.DepartmentBusiness();

                tbemployees.dt_hiring = dtpContratação.Value;
                tbemployees.dt_resignation = dtpDemissão.Value;
                financial.vl_grossSalary = nudSalarioBruto.Value;
                tbdiscounts.vl_foodPension = nudValeAlimentação.Value;
                tbbenefits.vl_lifeSafe = nudSeguroDeVida.Value;
                tb_Department.nm_department = cboDepartamento.Text;
                tbfunction.nm_function = cboCargo.Text;
                tbbenefits.vl_transport = nudValeTransporte.Value;
                tbbenefits.vl_planHealth = nudPlanoDeSáude.Value;


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
            frmRegisterEmployee registerEmployee = new frmRegisterEmployee();
            registerEmployee.CarregarFuncionario(employees);
            registerEmployee.Show();
            Hide();
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

        private void imgVoltar_MouseEnter(object sender, EventArgs e)
        {
            imgVoltar.Image = Properties.Resources.Voltar;
            imgVoltar.Image = Properties.Resources.Voltar02;
        }

        private void imgVoltar_MouseLeave(object sender, EventArgs e)
        {
            imgVoltar.Image = Properties.Resources.Voltar02;
            imgVoltar.Image = Properties.Resources.Voltar;
        }
    }
}
