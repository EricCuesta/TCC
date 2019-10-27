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
    public partial class frmConsultEmployee : Form
    {
        public frmConsultEmployee()
        {
            InitializeComponent();
            this.CarregarCombo();
            this.CarregarComboCargo();
        }
        private void CarregarCombo()
        {
            Business.DepartmentBusiness b = new Business.DepartmentBusiness();
            List<Database.Entities.tb_department> list = b.Consultar();

            cboDepartamento.DisplayMember = nameof(Database.Entities.tb_department.nm_department);
            cboDepartamento.DataSource = list;
        }

        private void CarregarComboCargo()
        {
            Business.FunctionBusiness b = new Business.FunctionBusiness();
            List<Database.Entities.tb_function> list = b.Consultar();

            cboCargo.DisplayMember = nameof(Database.Entities.tb_function.nm_function);
            cboCargo.DataSource = list;
        }

        private void CarregarGenero()
        {
            Business.EmployeesBusiness b = new Business.EmployeesBusiness();
            List<Database.Entities.tb_employees> list = b.Consultar();

            cboGênero.DisplayMember = nameof(Database.Entities.tb_employees.ds_sex);
            cboGênero.DataSource = list;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Database.EmployeesDatabase DB = new Database.EmployeesDatabase();
                Database.DepartmentDatabase tbdepartment = new Database.DepartmentDatabase();
                List<Database.Entities.tb_employees> listageral = DB.Consultar();
                dgvConsultarEmpregado.DataSource = listageral;

                string nome = txtNome.Text.Trim();
                string rg = mtxtRG.Text.Trim();
                string ano = mtxtAno.Text;


                if (nome != string.Empty)
                {
                    List<Database.Entities.tb_employees> list = DB.ConsultarFuncionario(nome);

                    dgvConsultarEmpregado.DataSource = list;
                }

                if (rg != string.Empty)
                {
                    List<Database.Entities.tb_employees> list = DB.ConsultarFuncionarioRG(rg);

                    dgvConsultarEmpregado.DataSource = list;
                } 
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro. Tente mais tarde.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            string nome = txtNome.Text;

            if (nome != string.Empty)
            {
                txtNome.Enabled = true;
                mtxtAno.Enabled = true;
                cboGênero.Enabled = true;

                mtxtRG.Enabled = false;
                cboDepartamento.Enabled = false;
                cboCargo.Enabled = false;
            }
            else
            {
                mtxtRG.Enabled = true;
                txtNome.Enabled = true;
                cboDepartamento.Enabled = true;
                cboCargo.Enabled = true;
                mtxtAno.Enabled = true;
                cboGênero.Enabled = true;
            }
        }

        private void txtRG_TextChanged(object sender, EventArgs e)
        {
            string rg = mtxtRG.Text;

            if (rg != string.Empty)
            {
                mtxtRG.Enabled = true;

                txtNome.Enabled = false;
                cboDepartamento.Enabled = false;
                cboCargo.Enabled = false;
                mtxtAno.Enabled = false;
                cboGênero.Enabled = false;
            }
            else
            {
                mtxtRG.Enabled = true;
                txtNome.Enabled = true;
                cboDepartamento.Enabled = true;
                cboCargo.Enabled = true;
                mtxtAno.Enabled = true;
                cboGênero.Enabled = true;
            }
        }

        private void mtxtAno_TextChanged(object sender, EventArgs e)
        {
            string ano = mtxtAno.Text;

            if (ano != string.Empty)
            {
                txtNome.Enabled = true;
                mtxtAno.Enabled = true;
                cboGênero.Enabled = true;

                mtxtRG.Enabled = false;
                cboDepartamento.Enabled = false;
                cboCargo.Enabled = false;
            }
            else
            {
                mtxtRG.Enabled = true;
                txtNome.Enabled = true;
                cboDepartamento.Enabled = true;
                cboCargo.Enabled = true;
                mtxtAno.Enabled = true;
                cboGênero.Enabled = true;
            }
        }
    }
}
