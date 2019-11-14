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
using Liriou_s_Burguer.Model;

namespace Liriou_s_Burguer.Screens.Manager.HumanResources
{
    public partial class frmRegisterEmployee1 : Form
    {
        public frmRegisterEmployee1()
        {
            InitializeComponent();
            CarregarCombos();
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
                tb_employees emp = new tb_employees();
                tb_deptfunction defu = new tb_deptfunction();
                tb_timecard ticd = new tb_timecard();
                tb_financial fin = new tb_financial();
                tb_benefits ben = new tb_benefits();
                tb_bankaccount bank = new tb_bankaccount();
                tb_discounts dis = new tb_discounts();

                EmployeesBusiness empB = new EmployeesBusiness();
                DeptFunctionBusiness defuB = new DeptFunctionBusiness();
                TimeCardBusiness ticdB = new TimeCardBusiness();
                FinancialBusiness finB = new FinancialBusiness();
                BenefitsBusiness benB = new BenefitsBusiness();
                BankAccountBusiness bankB = new BankAccountBusiness();
                DiscountsBusiness disB = new DiscountsBusiness();

                emp.dt_hiring = dtpContratação.Value.ToShortDateString();
                emp.dt_resignation = "01/01/9999";
                defu.nm_department = cboDepartamento.Text;
                defu.nm_function = cboCargo.Text;
                fin.vl_grossSalary = nudSalárioBruto.Value;
                fin.dt_fromDate = DateTime.Now.ToShortDateString();
                fin.dt_toDate = "01/01/9999";
                fin.ds_typeSalary = cboTipoDeSalário.Text;
                ben.bt_transport = chkValeTransporte.Checked;
                ben.bt_food = chkValeAlimentação.Checked;
                ben.bt_meal = chkValeRefeição.Checked;
                ben.bt_lifeSafe = chkSeguroDeVida.Checked;
                ben.bt_planHealth = chkPlanoDeSáude.Checked;
                ben.bt_planDental = chkPlanoDental.Checked;
                ben.vl_transport = nudTarifa.Value;
                ben.vl_food = nudValeAlimentação.Value;
                ben.vl_meal = nudValeRefeição.Value;
                ben.vl_lifeSafe = nudSeguroDeVida.Value;
                ben.vl_planHealth = nudPlanoDeSáude.Value;
                ben.vl_planDental = nudPlanoDental.Value;
                bank.nm_bank = txtNomeDoBanco.Text;
                bank.nr_agency = Convert.ToInt32(mtxtAgência.Text);
                bank.nr_account = mtxtConta.Text;
                bank.ds_typePerson = cboTipoDePessoa.Text;
                dis.vl_foodPension = nudPensãoAlimentícia.Value;
                ticd.hr_fixedInput = mtxtEntrada.Text;
                ticd.hr_fixedOutput = mtxtSaída.Text;
                ticd.hr_fixedIntInput = mtxtInícioInt.Text;
                ticd.hr_fixedIntOutput = mtxtFinalInt.Text;

                empB.Inserir1(emp);
                defuB.Inserir(defu);
                ticdB.Inserir(ticd);
                finB.Inserir(fin);
                benB.Inserir(ben);
                bankB.Inserir(bank);
                disB.Inserir(dis);

                MessageBox.Show("Funcionário cadastrado com sucesso");

                this.Zerar();
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
            frmRegisterEmployee emp = new frmRegisterEmployee();
            emp.txtNome.Text = EmployeesModel.firstName;
            emp.txtSobrenome.Text = EmployeesModel.lastName;
            emp.mtxtRG.Text = EmployeesModel.RG;
            emp.mtxtCPF.Text = EmployeesModel.CPF;
            emp.nudDependentes.Value = EmployeesModel.dependents;
            emp.dtpNascimento.Value = Convert.ToDateTime(EmployeesModel.birth);
            emp.cboEstado.Text = EmployeesModel.state;
            emp.mtxtCEP.Text = EmployeesModel.CEP;
            emp.txtEndereço.Text = EmployeesModel.address;
            emp.txtComplemento.Text = EmployeesModel.note;
            emp.mtxtCelular.Text = EmployeesModel.cellphone;
            emp.mtxtTelefone.Text = EmployeesModel.tellphone;
            emp.txtEmail.Text = EmployeesModel.email;
            emp.txtSenha.Text = EmployeesModel.password;
            emp.rdbGerente.Checked = EmployeesModel.manager;
            emp.rdbFuncionário.Checked = EmployeesModel.employeer;
            emp.chkFornecedor.Checked = EmployeesModel.Provider;
            emp.chkRH.Checked = EmployeesModel.RH;
            emp.chkFinanceiro.Checked = EmployeesModel.financial;
            emp.chkEstoque.Checked = EmployeesModel.stock;
            emp.chkCRM.Checked = EmployeesModel.CRM;
            if (EmployeesModel.sex == "M")
            {
                emp.cboSexo.Text = "Masculino";
            }
            else
            {
                emp.cboSexo.Text = "Feminino";
            }

            frmMenu.Current.openContedor(emp);
        }

        private void Zerar()
        {
            EmployeesModel.firstName = string.Empty;
            EmployeesModel.lastName = string.Empty;
            EmployeesModel.RG = string.Empty;
            EmployeesModel.CPF = string.Empty;
            EmployeesModel.dependents = 0;
            EmployeesModel.sex = string.Empty;
            EmployeesModel.birth = "01/01/2000";
            EmployeesModel.state = string.Empty;
            EmployeesModel.CEP = string.Empty;
            EmployeesModel.address = string.Empty;
            EmployeesModel.note = string.Empty;
            EmployeesModel.cellphone = string.Empty;
            EmployeesModel.tellphone = string.Empty;
            EmployeesModel.email = string.Empty;
            EmployeesModel.password = string.Empty;
            EmployeesModel.employeer = false;
            EmployeesModel.manager = false;
            EmployeesModel.CRM = false;
            EmployeesModel.Provider = false;
            EmployeesModel.stock = false;
            EmployeesModel.RH = false;
            EmployeesModel.financial = false;
        }

        private void chkValeRefeição_CheckedChanged(object sender, EventArgs e)
        {
            if (chkValeRefeição.Checked == true)
            {
                chkValeRefeição.Text = "VR";
                nudValeRefeição.Visible = true;
            }
            else
            {
                chkValeRefeição.Text = "Vale Refeição";
                nudValeRefeição.Visible = false;
            }
        }

        private void chkValeAlimentação_CheckedChanged(object sender, EventArgs e)
        {
            if (chkValeAlimentação.Checked == true)
            {
                chkValeAlimentação.Text = "VA";
                nudValeAlimentação.Visible = true;
            }
            else
            {
                chkValeAlimentação.Text = "Vale Alimentação";
                nudValeAlimentação.Visible = false;
            }
        }

        private void chkSeguroDeVida_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSeguroDeVida.Checked == true)
            {
                chkSeguroDeVida.Text = "SV";
                nudSeguroDeVida.Visible = true;
            }
            else
            {
                chkSeguroDeVida.Text = "Seguro de Vida";
                nudSeguroDeVida.Visible = false;
            }
        }

        private void chkValeTransporte_CheckedChanged(object sender, EventArgs e)
        {
            if (chkValeTransporte.Checked == true)
            {
                chkValeTransporte.Text = "VT";
                nudTarifa.Visible = true;
            }
            else
            {
                chkValeTransporte.Text = "Vale Transporte";
                nudTarifa.Visible = false;
            }
        }

        private void chkPlanoDeSáude_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPlanoDeSáude.Checked == true)
            {
                chkPlanoDeSáude.Text = "PS";
                nudPlanoDeSáude.Visible = true;
            }
            else
            {
                chkPlanoDeSáude.Text = "Plano de Saúde";
                nudPlanoDeSáude.Visible = false;
            }
        }

        private void chkPlanoDental_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPlanoDental.Checked == true)
            {
                chkPlanoDental.Text = "PD";
                nudPlanoDental.Visible = true;
            }
            else
            {
                chkPlanoDental.Text = "Plano Odontológico";
                nudPlanoDental.Visible = false;
            }
        }

        private void CarregarCombos()
        {
            liriousdbEntities DB = new liriousdbEntities();
            List<tb_department> listDept = DB.tb_department.ToList();
            List<tb_function> listFunc = DB.tb_function.ToList();

            foreach (tb_department dept in listDept)
            {
                cboDepartamento.Items.Add(dept.nm_department);
            }
            foreach (tb_function func in listFunc)
            {
                cboCargo.Items.Add(func.nm_function);
            }
        }
    }
}
