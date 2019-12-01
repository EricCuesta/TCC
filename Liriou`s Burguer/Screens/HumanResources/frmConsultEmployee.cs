using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Liriou_s_Burguer.Database.Entities;
using Liriou_s_Burguer.Business;

namespace Liriou_s_Burguer.Screens.HumanResources
{
    public partial class frmConsultEmployee : Form
    {
        public frmConsultEmployee()
        {
            InitializeComponent();
            dgvFuncionário.AutoGenerateColumns = false;
            this.CarregarCombos();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string ano = mtxtAno.Text;
            string sexo = cboSexo.Text;
            string rg = mtxtRG.Text;
            string dept = cboDepartamento.Text;
            string func = cboCargo.Text;

            EmployeesBusiness EB = new EmployeesBusiness();
            List<tb_employees> list = EB.Consultar(nome, ano, sexo, rg, dept, func);

            dgvFuncionário.DataSource = list;
        }

        liriousdbEntities DB = new liriousdbEntities();
        private void CarregarCombos()
        {
            List<tb_department> listDept = DB.tb_department.ToList();

            foreach (tb_department dept in listDept)
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
