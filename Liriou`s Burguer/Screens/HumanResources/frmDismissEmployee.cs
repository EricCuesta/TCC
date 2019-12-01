using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Liriou_s_Burguer.Business;
using Liriou_s_Burguer.Database.Entities;

namespace Liriou_s_Burguer.Screens.HumanResources
{
    public partial class frmDismissEmployee : Form
    {
        public frmDismissEmployee()
        {
            InitializeComponent();
        }

        EmployeesBusiness EB = new EmployeesBusiness();
        private void btnDemitir_Click(object sender, EventArgs e)
        {
            int idEmp = Convert.ToInt32(nudID.Value);

            string res = EB.DeleteEmployee(idEmp);

            MessageBox.Show(res, "liriou's Burguer", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void nudID_Leave(object sender, EventArgs e)
        {
            try
            {
                tb_employees emp = EB.ConsultarPorID(Convert.ToInt32(nudID.Value));
                if (emp != null)
                {
                    txtNome.Text = emp.nm_firstName;
                    txtSobrenome.Text = emp.nm_lastName;
                    mtxtRG.Text = emp.nr_rg;
                    mtxtCPF.Text = emp.nr_cpf;
                    nudDependentes.Value = emp.nr_dependents;
                    cboSexo.Text = emp.ds_sex == "M" ? "Masculino" : "Feminino";
                    dtpNascimento.Value = Convert.ToDateTime(emp.dt_birth);
                    cboEstado.Text = emp.ds_state;
                    mtxtCEP.Text = emp.nr_cep;
                    txtEndereço.Text = emp.ds_address;
                    txtComplemento.Text = emp.ds_note;
                    mtxtCelular.Text = emp.nr_cellphone;
                    mtxtTelefone.Text = emp.nr_tellphone;
                    txtEmail.Text = emp.ds_email;
                    txtSenha.Text = emp.pw_password;
                    rdbFuncionário.Checked = Convert.ToBoolean(emp.bt_employee);
                    rdbGerente.Checked = Convert.ToBoolean(emp.bt_manager);
                    chkCRM.Checked = Convert.ToBoolean(emp.bt_crm);
                    chkFornecedor.Checked = Convert.ToBoolean(emp.bt_provider);
                    chkEstoque.Checked = Convert.ToBoolean(emp.bt_stock);
                    chkRH.Checked = Convert.ToBoolean(emp.bt_rh);
                    chkFinanceiro.Checked = Convert.ToBoolean(emp.bt_financial);
                }
                else
                {
                    this.EmptyControls();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocorreu um erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EmptyControls()
        {
            txtNome.Text = string.Empty;
            txtSobrenome.Text = string.Empty;
            mtxtRG.Text = string.Empty;
            mtxtCPF.Text = string.Empty;
            nudDependentes.Value = 0;
            dtpNascimento.Value = DateTime.Today;
            cboSexo.Text = "Empty";
            cboEstado.Text = "Empty";
            mtxtCEP.Text = string.Empty;
            txtEndereço.Text = string.Empty;
            txtComplemento.Text = string.Empty;
            mtxtCelular.Text = string.Empty;
            mtxtTelefone.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtSenha.Text = string.Empty;
            rdbFuncionário.Checked = false;
            rdbGerente.Checked = false;
            chkCRM.Checked = false;
            chkFornecedor.Checked = false;
            chkEstoque.Checked = false;
            chkRH.Checked = false;
            chkFinanceiro.Checked = false;
        }

        private void rdbFuncionário_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbFuncionário.Checked == true)
            {
                panelAcesso.Visible = true;
            }
        }

        private void rdbGerente_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbGerente.Checked == true)
            {
                panelAcesso.Visible = false;
            }
        }
    }
}
