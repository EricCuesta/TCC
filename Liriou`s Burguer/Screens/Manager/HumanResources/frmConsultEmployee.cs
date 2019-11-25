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

namespace Liriou_s_Burguer.Screens.Manager.HumanResources
{
    public partial class frmConsultEmployee : Form
    {
        public frmConsultEmployee()
        {
            InitializeComponent();
            dgvFuncionário.AutoGenerateColumns = false;
            this.CarregarCombos();
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
    }
}
