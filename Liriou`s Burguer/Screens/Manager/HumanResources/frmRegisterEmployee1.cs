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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Database.Entities.tb_employees tbemployees = new Database.Entities.tb_employees();
                Business.EmployeesBusiness busemployee = new Business.EmployeesBusiness();

                Database.Entities.tb_department tbdepartment = new Database.Entities.tb_department();
                Business.DepartmentBusiness busdepartment = new Business.DepartmentBusiness();

                Database.Entities.tb_function tbfunction = new Database.Entities.tb_function();
                Business.FunctionBusiness busfunction = new Business.FunctionBusiness();

                Database.Entities.tb_timecard tbtimecard = new Database.Entities.tb_timecard();
                Business.TimeCardBusiness bustimecard = new Business.TimeCardBusiness();

                Database.Entities.tb_financial tbfinancial = new Database.Entities.tb_financial();
                Business.FinancialBusiness busfinancial = new Business.FinancialBusiness();

                Database.Entities.tb_benefits tbbenefits = new Database.Entities.tb_benefits();
                Business.BenefitsBusiness busbenefits = new Business.BenefitsBusiness();

                Database.Entities.tb_bankaccount tbbank = new Database.Entities.tb_bankaccount();
                Business.BankAccountBusiness busbank = new Business.BankAccountBusiness();

                tbemployees.dt_hiring = dtpContratação.Value.ToShortDateString();
                tbemployees.dt_resignation = dtpDemissão.Value.ToShortDateString();
                tbdepartment.nm_department = cboDepartamento.Text;
                tbfunction.nm_function = cboCargo.Text;
                tbtimecard.hr_fixedInput = mtxtInício.Text;
                tbtimecard.hr_fixedIntInput = mtxtInícioIntervalo.Text;
                tbtimecard.hr_fixedIntOutput = mtxtTérminoIntervalo.Text;
                tbtimecard.hr_fixedOutput = mtxtTérminoIntervalo.Text;
                tbfinancial.vl_grossSalary = nudSalárioBruto.Value;
                tbbenefits.bt_food = Convert.ToBoolean(chkValeAlimentação.Checked);
                tbbenefits.bt_meal = Convert.ToBoolean(chkValeRefeição.Checked);
                tbbenefits.bt_lifeSafe = Convert.ToBoolean(chkSeguroDeVida.Checked);
                tbbenefits.bt_transport = Convert.ToBoolean(chkValeTransporte.Checked);
                tbbenefits.bt_planHealth = Convert.ToBoolean(chkPlanoDeSáude.Checked);
                tbbenefits.bt_planDental = Convert.ToBoolean(chkPlanoDental.Checked);
                tbbank.nm_bank = txtNomeDoBanco.Text;
                tbbank.nr_account = mtxtCódigoDoBanco.Text;
                tbbank.nr_agency = Convert.ToInt32(mtxtAgênciaDoBanco.Text);
                tbbank.ds_typePerson = cboTipoDePessoa.Text;

                busemployee.Inserir1(tbemployees);
                busdepartment.Inserir(tbdepartment);
                busfunction.Inserir(tbfunction);
                bustimecard.Inserir(tbtimecard);
                busfinancial.Inserir(tbfinancial);
                busbenefits.Inserir(tbbenefits);
                busbank.Inserir(tbbank);

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
            registerEmployee.chkFinanceiro.Checked = Model.EmployeesModel.financial;
            registerEmployee.chkEstoque.Checked = Model.EmployeesModel.stock;
            registerEmployee.chkCRM.Checked = Model.EmployeesModel.CRM;
            frmMenu.Current.openContedor(registerEmployee);
        }
    }
}
