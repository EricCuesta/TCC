using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Liriou_s_Burguer.Screens.HumanResources
{
    public partial class frmDismissEmployee : Form
    {
        public frmDismissEmployee()
        {
            InitializeComponent();
        }

        private void nudID_ValueChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(nudID.Value);

            Business.EmployeesBusiness busemployees = new Business.EmployeesBusiness();
            Database.Entities.tb_employees employees = busemployees.ConsultarPorID(id);

            if (employees == null)
            {
                txtNome.Text = string.Empty;
                txtSobrenome.Text = string.Empty;
                mtxtRG.Text = string.Empty;
                mtxtCPF.Text = string.Empty;
                nudDependentes.Value = 0;
                cboSexo.Text = null;
                dtpNascimento.Value = new DateTime(0000, 00, 00);
                cboEstado.Text = null;
                mtxtCEP.Text = string.Empty;
                txtComplemento.Text = string.Empty;
                txtEndereço.Text = string.Empty;
                mtxtCelular.Text = string.Empty;
                mtxtTelefone.Text = string.Empty;
                txtEmail.Text = string.Empty;
                txtSenha.Text = string.Empty;
                rdbGerente.Checked = Convert.ToBoolean(string.Empty);
                rdbFuncionário.Checked = Convert.ToBoolean(string.Empty);
                chkRH.Checked = Convert.ToBoolean(string.Empty);
                chkFinanceiro.Checked = Convert.ToBoolean(string.Empty);
                chkEstoque.Checked = Convert.ToBoolean(string.Empty);
                chkCRM.Checked = Convert.ToBoolean(string.Empty);
            }
        }

        private void btnDemitir_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(nudID.Value);

            Business.EmployeesBusiness busemployees = new Business.EmployeesBusiness();
            busemployees.Remover(id);

            MessageBox.Show("Cliente deletado com sucesso");
        }
    }
}
