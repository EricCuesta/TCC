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

namespace Liriou_s_Burguer.Screens.HumanResources
{
    public partial class frmRegisterEmployee1 : Form
    {
        public frmRegisterEmployee1()
        {
            InitializeComponent();
            CarregarCombos();
        }

        tb_employees employees;

        public void CarregarFuncionario(tb_employees employees)
        {
            this.employees = employees;

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                tb_employees emp = this.ReadEmployees();
                tb_deptfunction defu = this.ReadDeptFunction();
                tb_timecard ticd = this.ReadTimeCard();
                tb_financial fin = this.ReadFinancial();
                tb_benefits ben = this.ReadBenefits();
                tb_bankaccount bank = this.ReadBankAccount();
                tb_discounts dis = this.ReadDiscounts();

                EmployeesBusiness EB = new EmployeesBusiness();
                string res = EB.InsertEmployee(emp, defu, ticd, fin, ben, bank, dis);

                MessageBox.Show(res, "liriou's Burguer", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocorreu um Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            emp.cboSexo.Text = EmployeesModel.sex;
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

            frmMenu.Current.openContedor(emp);
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

        private tb_employees ReadEmployees()
        {
            tb_employees emp = new tb_employees();
            emp.nm_firstName = EmployeesModel.firstName;
            emp.nm_lastName = EmployeesModel.lastName;
            emp.nr_rg = EmployeesModel.RG.Contains(",") ? EmployeesModel.RG.Replace(",", ".") : EmployeesModel.RG;
            emp.nr_cpf = EmployeesModel.CPF;
            emp.nr_dependents = EmployeesModel.dependents;
            emp.ds_sex = EmployeesModel.sex;
            emp.dt_birth = EmployeesModel.birth;
            emp.ds_state = EmployeesModel.state;
            emp.nr_cep = EmployeesModel.CEP;
            emp.ds_address = EmployeesModel.address;
            emp.ds_note = EmployeesModel.note;
            emp.nr_cellphone = EmployeesModel.cellphone;
            emp.nr_tellphone = EmployeesModel.tellphone;
            emp.ds_email = EmployeesModel.email;
            emp.pw_password = EmployeesModel.password;
            emp.bt_manager = EmployeesModel.manager;
            emp.bt_employee = EmployeesModel.employeer;
            emp.bt_rh = EmployeesModel.RH;
            emp.bt_provider = EmployeesModel.Provider;
            emp.bt_financial = EmployeesModel.financial;
            emp.bt_stock = EmployeesModel.stock;
            emp.bt_crm = EmployeesModel.CRM;
            emp.dt_hiring = dtpContratação.Value.ToShortDateString();
            emp.dt_resignation = "01/01/9998";

            return emp;
        }

        private tb_deptfunction ReadDeptFunction()
        {
            tb_deptfunction defu = new tb_deptfunction();
            defu.nm_department = cboDepartamento.Text;
            defu.nm_function = cboCargo.Text;

            return defu;
        }

        private tb_timecard ReadTimeCard()
        {
            tb_timecard ticd = new tb_timecard();
            ticd.hr_fixedInput = mtxtEntrada.Text;
            ticd.hr_fixedOutput = mtxtSaída.Text;
            ticd.hr_fixedIntInput = mtxtInícioInt.Text;
            ticd.hr_fixedIntOutput = mtxtFinalInt.Text;

            return ticd;
        }

        private tb_financial ReadFinancial()
        {
            tb_financial fin = new tb_financial();
            fin.vl_grossSalary = nudSalárioBruto.Value;
            fin.dt_fromDate = DateTime.Now.ToShortDateString();
            fin.dt_toDate = "01/01/9998";
            fin.ds_typeSalary = cboTipoDeSalário.Text;
            fin.dt_fromDate = DateTime.Now.ToString("dd/MM/yyyy");
            fin.dt_toDate = "01/01/9998";

            return fin;
        }

        private tb_benefits ReadBenefits()
        {
            tb_benefits ben = new tb_benefits();
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

            return ben;
        }

        private tb_bankaccount ReadBankAccount()
        {
            tb_bankaccount bank = new tb_bankaccount();
            bank.nm_bank = txtNomeDoBanco.Text;
            bank.nr_agency = mtxtAgência.Text == "" ? 0 : Convert.ToInt32(mtxtAgência.Text);
            bank.nr_account = mtxtConta.Text;
            bank.ds_typePerson = cboTipoDePessoa.Text;

            return bank;
        }

        private tb_discounts ReadDiscounts()
        {
            tb_discounts dis = new tb_discounts();
            dis.vl_foodPension = nudPensãoAlimentícia.Value;

            return dis;
        }

        liriousdbEntities DB = new liriousdbEntities();
        private void CarregarCombos()
        {
            List<tb_department> list = DB.tb_department.ToList();
            foreach (tb_department dept in list)
            {
                cboDepartamento.Items.Add(dept.nm_department);
            }
        }

        private void cboDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboCargo.Items.Clear();

            List<tb_function> list = DB.tb_function.Where(t => t.tb_department.nm_department == cboDepartamento.Text).ToList();
            foreach (tb_function func in list)
            {
                cboCargo.Items.Add(func.nm_function);
            }
        }
    }
}
