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

        private void menuInício_Click(object sender, EventArgs e)
        {
            frmLiriousBurguer managerMenu = new frmLiriousBurguer();
            managerMenu.Show();
            Hide();
        }

        private void cadastrarFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegisterEmployee registerEmployee = new frmRegisterEmployee();
            registerEmployee.Show();
            Hide();
        }

        private void alterarFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangeEmployee changeEmployee = new frmChangeEmployee();
            changeEmployee.Show();
            Hide();
        }

        private void demitirFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDismissEmployee dismissEmployee = new frmDismissEmployee();
            dismissEmployee.Show();
            Hide();
        }

        private void folhaDePagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPayroll payroll = new frmPayroll();
            payroll.Show();
            Hide();
        }

        private void consultarCartãoDePontoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultTimeCard consultTimeCard = new frmConsultTimeCard();
            consultTimeCard.Show();
            Hide();
        }

        private void imgMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void imgFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void imgFechar_MouseEnter(object sender, EventArgs e)
        {
            imgFechar.Image = Properties.Resources.Fechar;
            imgFechar.Image = Properties.Resources.Fechar02;
        }

        private void imgFechar_MouseLeave(object sender, EventArgs e)
        {
            imgFechar.Image = Properties.Resources.Fechar02;
            imgFechar.Image = Properties.Resources.Fechar;
        }

        private void imgMinimizar_MouseEnter(object sender, EventArgs e)
        {
            imgMinimizar.Image = Properties.Resources.Minimizar;
            imgMinimizar.Image = Properties.Resources.Minimizar02;
        }

        private void imgMinimizar_MouseLeave(object sender, EventArgs e)
        {
            imgMinimizar.Image = Properties.Resources.Minimizar02;
            imgMinimizar.Image = Properties.Resources.Minimizar;
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
                dgvConsultar.DataSource = listageral;

                string nome = txtNome.Text.Trim();
                string rg = txtRG.Text.Trim();
                string ano = mtxtAno.Text;


                if (nome != string.Empty)
                {
                    List<Database.Entities.tb_employees> list = DB.ConsultarFuncionario(nome);

                    dgvConsultar.DataSource = list;
                }

                if (rg != string.Empty)
                {
                    List<Database.Entities.tb_employees> list = DB.ConsultarFuncionarioRG(rg);

                    dgvConsultar.DataSource = list;
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

                txtRG.Enabled = false;
                cboDepartamento.Enabled = false;
                cboCargo.Enabled = false;
            }
            else
            {
                txtRG.Enabled = true;
                txtNome.Enabled = true;
                cboDepartamento.Enabled = true;
                cboCargo.Enabled = true;
                mtxtAno.Enabled = true;
                cboGênero.Enabled = true;
            }
        }

        private void txtRG_TextChanged(object sender, EventArgs e)
        {
            string rg = txtRG.Text;

            if (rg != string.Empty)
            {
                txtRG.Enabled = true;

                txtNome.Enabled = false;
                cboDepartamento.Enabled = false;
                cboCargo.Enabled = false;
                mtxtAno.Enabled = false;
                cboGênero.Enabled = false;
            }
            else
            {
                txtRG.Enabled = true;
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

                txtRG.Enabled = false;
                cboDepartamento.Enabled = false;
                cboCargo.Enabled = false;
            }
            else
            {
                txtRG.Enabled = true;
                txtNome.Enabled = true;
                cboDepartamento.Enabled = true;
                cboCargo.Enabled = true;
                mtxtAno.Enabled = true;
                cboGênero.Enabled = true;
            }
        }
    }
}
