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

        tb_employees employees;

        public void CarregarFuncionario(tb_employees employees)
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                tb_employees tbemployees = new tb_employees();
                EmployeesBusiness busemployees = new EmployeesBusiness();

                tb_discounts tbdiscounts = new tb_discounts();
                DiscountsBusiness busdiscounts = new DiscountsBusiness();

                tb_function tbfunction = new tb_function();
                FunctionBusiness busfunction = new FunctionBusiness();

                tb_timecard tbtimecard = new tb_timecard();
                TimeCardBusiness bustimecard = new TimeCardBusiness();

                tb_financial financial = new tb_financial();
                FinancialBusiness busfinancial = new FinancialBusiness();

                tb_benefits tbbenefits = new tb_benefits();
                BenefitsBusiness busbenefits = new BenefitsBusiness();

                tb_department tbdepartment = new tb_department();
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
                busdepartment.Inserir(tbdepartment);

                MessageBox.Show("Funcionário cadastrado com sucesso");

                Model.EmployeesModel model = new Model.EmployeesModel();
                model.firstName = string.Empty;
                model.lastName = string.Empty;
                model.RG = string.Empty;
                model.CPF = string.Empty;
                model.dependents = 0;
                model.sex = null;
                model.birth = DateTime.Now;
                model.state = null;
                model.CEP = string.Empty;
                model.note = string.Empty;
                model.address = string.Empty;
                model.cellphone = string.Empty;
                model.tellphone = string.Empty;
                model.email = string.Empty;
                model.password = string.Empty;
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
    }
}
