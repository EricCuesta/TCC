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
    public partial class frmRegisterEmployee : Form
    {
        public frmRegisterEmployee()
        {
            InitializeComponent();
        }

        private void mtxtCEP_TextChanged(object sender, EventArgs e)
        {
            if (mtxtCEP.Text.Length == 9)
            {
                string CEP = mtxtCEP.Text;
                CorreioApi.CorreioApi api = new CorreioApi.CorreioApi();
                txtEndereço.Text = api.Buscar(CEP);
            }
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            try
            {
                Model.EmployeesModel model = new Model.EmployeesModel();
                model.firstName = txtNome.Text.Trim();
                model.lastName = txtSobrenome.Text.Trim();
                model.RG = mtxtRG.Text.Trim();
                model.CPF = mtxtCPF.Text.Trim();
                model.dependents = Convert.ToInt32(nudDependentes.Value);
                model.sex = cboSexo.Text;
                model.birth = dtpNascimento.MinDate;
                model.state = cboEstado.Text;
                model.CEP = mtxtCEP.Text.Trim();
                model.note = txtComplemento.Text.Trim();
                model.address = txtEndereço.Text.Trim();
                model.cellphone = mtxtCelular.Text.Trim();
                model.tellphone = mtxtTelefone.Text.Trim();
                model.email = txtEmail.Text.Trim();
                model.password = txtSenha.Text.Trim();

                Business.EmployeesBusiness db = new Business.EmployeesBusiness();
                db.VerificarCadastro(model);

                Hide();
                frmRegisterEmployee1 tela = new frmRegisterEmployee1();
                tela.Show();
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
