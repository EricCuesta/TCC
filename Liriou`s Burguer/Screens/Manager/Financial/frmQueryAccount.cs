using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Liriou_s_Burguer.Screens.Manager.Financial
{
    public partial class frmQueryAccount : Form
    {
        public frmQueryAccount()
        {
            InitializeComponent();
            dgvConsultarConta.AutoGenerateColumns = false;
        }

        private void Consulta()
        {
            Database.Entities.tb_account account = new Database.Entities.tb_account();
            account.nm_account = txtNome.Text.Trim();
            account.nr_identification = mtxtIdentificação.Text.Trim();

            Business.AccountBusiness busaccount = new Business.AccountBusiness();
            List<Database.Entities.tb_account> accountlista = busaccount.Consultar(account);

            dgvConsultarConta.DataSource = accountlista;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Business.AccountBusiness busaccount = new Business.AccountBusiness();
            List<Database.Entities.tb_account> accountlista = busaccount.ConsultarTodos();

            dgvConsultarConta.DataSource = accountlista;
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            this.Consulta();
        }

        private void mtxtIdentificação_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            this.Consulta();
        }

        private void dgvConsultarConta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    Database.Entities.tb_account account = new Database.Entities.tb_account();
                    DataGridViewRow row = this.dgvConsultarConta.Rows[e.RowIndex];
                }
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
