using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Liriou_s_Burguer.Screens.Employee
{
    public partial class frmUnavailability : Form
    {
        public frmUnavailability()
        {
            InitializeComponent();
            this.Consultar();
        }

        private void dtpIndisponibilidade_ValueChanged(object sender, EventArgs e)
        {
            DateTime data = Convert.ToDateTime(dgvConsultarIndisponibilidade);

            Business.EmployeesBusiness busemployees = new Business.EmployeesBusiness();
            Database.Entities.tb_employees employees = busemployees.ConsultarPorData(data);

            if (employees == null)
            {
                rtxtObservação.Text = string.Empty;
                btnSalvar.Visible = true;
                btnAlterar.Visible = false;
            }
            else
            {
                rtxtObservação.Text = employees.ds_unavailability;
                btnSalvar.Visible = false;
                btnAlterar.Visible = true;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Database.Entities.tb_employees employees = new Database.Entities.tb_employees();
                employees.dt_unavailability = dtpIndisponibilidade.Value;

                Business.EmployeesBusiness busemployees = new Business.EmployeesBusiness();
                busemployees.Inserir(employees);

                MessageBox.Show("Indisponibilidade cadastrado com sucesso");
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

        private void Consultar()
        {
            Database.Entities.tb_employees employees = new Database.Entities.tb_employees();

            Business.EmployeesBusiness busemp = new Business.EmployeesBusiness();
            List<Database.Entities.tb_employees> employeeslista = busemp.Consultar(employees);

            dgvConsultarIndisponibilidade.DataSource = employeeslista;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                Database.Entities.tb_employees employees = new Database.Entities.tb_employees();
                employees.dt_unavailability = Convert.ToDateTime(dtpIndisponibilidade.Value);

                Business.EmployeesBusiness busemployees = new Business.EmployeesBusiness();
                busemployees.Alterar(employees);

                MessageBox.Show("Indisponibilidade alterado com sucesso");
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
