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
using Liriou_s_Burguer.Database.Entities;
using Liriou_s_Burguer.Business;

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
                tb_employees tbemployees = new tb_employees();
                EmployeesBusiness busemployee = new EmployeesBusiness();

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

                tbemployees.dt_hiring = dtpContratação.Value.ToLongDateString();
                tbemployees.dt_resignation = dtpDemissão.Value.ToLongDateString();
                financial.vl_grossSalary = nudSalárioBruto.Value;
                tbbenefits.bt_food = Convert.ToBoolean(chkValeAlimentação.Checked);
                tbbenefits.bt_meal = Convert.ToBoolean(chkValeRefeição.Checked);
                tbbenefits.bt_lifeSafe = Convert.ToBoolean(chkSeguroDeVida.Checked);
                tbdepartment.nm_department = cboDepartamento.Text;
                tbfunction.nm_function = cboCargo.Text;
                tbbenefits.bt_transport = Convert.ToBoolean(chkValeTransporte.Checked);
                tbbenefits.bt_planHealth = Convert.ToBoolean(chkPlanoDeSáude.Checked);
                tbbenefits.bt_planDental = Convert.ToBoolean(chkPlanoDental.Checked);

                busemployee.Inserir1(tbemployees);
                busdiscounts.Inserir(tbdiscounts);
                busfunction.Inserir(tbfunction);
                bustimecard.Inserir(tbtimecard);
                busfinancial.Inserir(financial);
                busbenefits.Inserir(tbbenefits);
                busdepartment.Inserir(tbdepartment);

                MessageBox.Show("Funcionário cadastrado com sucesso");

                Model.EmployeesModel.firstName = string.Empty;
                Model.EmployeesModel.lastName = string.Empty;
                Model.EmployeesModel.RG = string.Empty;
                Model.EmployeesModel.CPF = string.Empty;
                Model.EmployeesModel.dependents = 0;
                Model.EmployeesModel.birth = Convert.ToString(DateTime.Now);
                Model.EmployeesModel.CEP = string.Empty;
                Model.EmployeesModel.note = string.Empty;
                Model.EmployeesModel.address = string.Empty;
                Model.EmployeesModel.email = string.Empty;
                Model.EmployeesModel.cellphone = string.Empty;
                Model.EmployeesModel.tellphone = string.Empty;
                Model.EmployeesModel.password = string.Empty;
                Model.EmployeesModel.manager = Convert.ToBoolean(string.Empty);
                Model.EmployeesModel.employeer = Convert.ToBoolean(string.Empty);
                Model.EmployeesModel.RH = Convert.ToBoolean(string.Empty);
                Model.EmployeesModel.financial = Convert.ToBoolean(string.Empty);
                Model.EmployeesModel.stock = Convert.ToBoolean(string.Empty);
                Model.EmployeesModel.CRM = Convert.ToBoolean(string.Empty);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception)
            {
                MessageBox.Show("ocorreu um erro!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void imgVoltar_Click(object sender, EventArgs e)
        {
            frmRegisterEmployee registerEmployee = new frmRegisterEmployee();
            registerEmployee.txtNome.Text = Model.EmployeesModel.firstName;
            registerEmployee.txtSobrenome.Text = Model.EmployeesModel.lastName;
            registerEmployee.mtxtRG.Text = Model.EmployeesModel.RG;
            registerEmployee.mtxtCPF.Text = Model.EmployeesModel.CPF;
            registerEmployee.nudDependentes.Value = Model.EmployeesModel.dependents;
            registerEmployee.cboSexo.Text = Model.EmployeesModel.sex;
            registerEmployee.dtpNascimento.Value = Convert.ToDateTime(Model.EmployeesModel.birth);
            registerEmployee.cboEstado.Text = Model.EmployeesModel.state;
            registerEmployee.mtxtCEP.Text = Model.EmployeesModel.CEP;
            registerEmployee.txtEndereço.Text = Model.EmployeesModel.address;
            registerEmployee.txtComplemento.Text = Model.EmployeesModel.note;
            registerEmployee.mtxtCelular.Text = Model.EmployeesModel.cellphone;
            registerEmployee.mtxtTelefone.Text = Model.EmployeesModel.tellphone;
            registerEmployee.txtEmail.Text = Model.EmployeesModel.email;
            registerEmployee.txtSenha.Text = Model.EmployeesModel.password;
            registerEmployee.rdbGerente.Checked = Model.EmployeesModel.manager;
            registerEmployee.rdbFuncionário.Checked = Model.EmployeesModel.employeer;
            registerEmployee.chkRH.Checked = Model.EmployeesModel.RH;
            registerEmployee.chkFornecedor.Checked = Model.EmployeesModel.Provider;
            registerEmployee.chkFinanceiro.Checked = Model.EmployeesModel.financial;
            registerEmployee.chkEstoque.Checked = Model.EmployeesModel.stock;
            registerEmployee.chkCRM.Checked = Model.EmployeesModel.CRM;
            registerEmployee.ShowDialog();
            this.Hide();
        }
    }
}
