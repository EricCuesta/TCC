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
            dgvConsultarEmpregado.AutoGenerateColumns = false;
        }

        private void Consulta()
        {
            Database.Entities.tb_employees employees = new Database.Entities.tb_employees();
            Database.Entities.tb_department department = new Database.Entities.tb_department();
            Database.Entities.tb_function function = new Database.Entities.tb_function();
            employees.nm_firstName = txtNome.Text;
            employees.nr_rg = mtxtRG.Text;
            employees.ds_sex = cboSexo.Text;
            department.nm_department = cboDepartamento.Text;
            function.nm_function = cboCargo.Text;
            
            Business.EmployeesBusiness busemployees = new Business.EmployeesBusiness();
            List<Database.Entities.tb_employees> employeeslista = busemployees.Consultar(employees);

            Business.DepartmentBusiness busdepartments = new Business.DepartmentBusiness();
            List<Database.Entities.tb_department> departmentslist = busdepartments.Consultar(department);

            Business.FunctionBusiness busfunction = new Business.FunctionBusiness();
            List<Database.Entities.tb_function> functionlist = busfunction.Consultar(function);

            dgvConsultarEmpregado.DataSource = employeeslista;
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            if (txtNome.Text != string.Empty)
            {
                txtNome.Enabled = true;
                mtxtAno.Enabled = true;
                cboSexo.Enabled = true;

                mtxtRG.Enabled = false;
                cboDepartamento.Enabled = false;
                cboCargo.Enabled = false;

                this.Consulta();
            }
            else
            {
                mtxtRG.Enabled = true;
                txtNome.Enabled = true;
                cboDepartamento.Enabled = true;
                cboCargo.Enabled = true;
                mtxtAno.Enabled = true;
                cboSexo.Enabled = true;
            }
        }

        private void cboSexo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSexo.Text != null)
            {
                mtxtRG.Enabled = true;

                txtNome.Enabled = false;
                cboDepartamento.Enabled = false;
                cboCargo.Enabled = false;
                mtxtAno.Enabled = false;
                cboSexo.Enabled = false;

                this.Consulta();
            }
            else
            {
                mtxtRG.Enabled = true;
                txtNome.Enabled = true;
                cboDepartamento.Enabled = true;
                cboCargo.Enabled = true;
                mtxtAno.Enabled = true;
                cboSexo.Enabled = true;
            }
        }

        private void mtxtAno_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (mtxtAno.Text != string.Empty)
            {
                txtNome.Enabled = true;
                mtxtAno.Enabled = true;
                cboSexo.Enabled = true;

                mtxtRG.Enabled = false;
                cboDepartamento.Enabled = false;
                cboCargo.Enabled = false;

                this.Consulta();
            }
            else
            {
                mtxtRG.Enabled = true;
                txtNome.Enabled = true;
                cboDepartamento.Enabled = true;
                cboCargo.Enabled = true;
                mtxtAno.Enabled = true;
                cboSexo.Enabled = true;
            }
        }

        private void btnConsulatar_Click(object sender, EventArgs e)
        {
            Business.EmployeesBusiness busemployees = new Business.EmployeesBusiness();
            List<Database.Entities.tb_employees> employeeslista = busemployees.ConsultarTodos();

            dgvConsultarEmpregado.DataSource = employeeslista;
        }

        private void cboDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Consulta();
        }

        private void cboCargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Consulta();
        }
    }
}
