using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        public void CarregarFuncionario(Database.Entities.tb_employees employees)
        {
            this.employees = employees;
          
        }

        private void imgMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Database.Entities.tb_employees tbemployees = new Database.Entities.tb_employees();
                Business.EmployeesBusiness busemployees = new Business.EmployeesBusiness();

                Database.Entities.tb_discounts tbdiscounts = new Database.Entities.tb_discounts();
                Business.DiscountsBusiness busdiscounts = new Business.DiscountsBusiness();

                Database.Entities.tb_function tbfunction = new Database.Entities.tb_function();
                Business.FunctionBusiness busfunction = new Business.FunctionBusiness();

                Database.Entities.tb_timecard tbtimecard = new Database.Entities.tb_timecard();
                Business.TimeCardBusiness bustimecard = new Business.TimeCardBusiness();

                Database.Entities.tb_financial financial = new Database.Entities.tb_financial();
                Business.FinancialBusiness busfinancial = new Business.FinancialBusiness();

                Database.Entities.tb_benefits tbbenefits = new Database.Entities.tb_benefits();
                Business.BenefitsBusiness busbenefits = new Business.BenefitsBusiness();

                Database.Entities.tb_department tbdepartment = new Database.Entities.tb_department();
                Business.DepartmentBusiness busdepartment = new Business.DepartmentBusiness();

                tbemployees.dt_hiring = dtpContratação.Value;
                tbemployees.dt_resignation = dtpDemissão.Value;
                financial.vl_grossSalary = nudSalárioBruto.Value;
                tbbenefits.bt_food = Convert.ToString(chkValeAlimentação.Checked);
                tbbenefits.bt_meal = Convert.ToString(chkValeRefeição.Checked);
                tbbenefits.bt_lifeSafe = Convert.ToString(chkSeguroDeVida.Checked);
                tbdepartment.nm_department = cboDepartamento.Text;
                tbfunction.nm_function = cboCargo.Text;
                tbbenefits.bt_transport = Convert.ToString(chkValeTransporte.Checked);
                tbbenefits.bt_planHealth = Convert.ToString(chkPlanoDeSáude.Checked);
                tbbenefits.bt_planDental = Convert.ToString(chkPlanoDental.Checked);

                busemployees.Inserir(tbemployees);
                busdiscounts.Inserir(tbdiscounts);
                busfunction.Inserir(tbfunction);
                bustimecard.Inserir(tbtimecard);
                busfinancial.Inserir(financial);
                busbenefits.Inserir(tbbenefits);
                busdepartment.Inserir(tbdepartment);

                MessageBox.Show("Funcionário cadastrado com sucesso");

                Hide();
                frmRegisterEmployee1 tela = new frmRegisterEmployee1();
                tela.Show();

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

        private void imgVoltar_Click(object sender, EventArgs e)
        {
            frmRegisterEmployee registerEmployee = new frmRegisterEmployee();
            Model.EmployeesModel model = new Model.EmployeesModel();
            registerEmployee.txtNome.Text = model.firstName;
            registerEmployee.txtSobrenome.Text = model.lastName;
            registerEmployee.mtxtRG.Text = model.RG;
            registerEmployee.mtxtCPF.Text = model.CPF;
            registerEmployee.nudDependentes.Value = model.dependents;
            registerEmployee.cboSexo.Text = model.sex;
            registerEmployee.cboEstado.Text = model.state;
            registerEmployee.mtxtCEP.Text = model.CEP;
            registerEmployee.txtEndereço.Text = model.note;
            registerEmployee.txtComplemento.Text = model.address;
            registerEmployee.mtxtCelular.Text = model.cellphone;
            registerEmployee.mtxtTelefone.Text = model.tellphone;
            registerEmployee.txtEmail.Text = model.email;
            registerEmployee.txtSenha.Text = model.password;
            registerEmployee.ShowDialog();
        }
    }
}
