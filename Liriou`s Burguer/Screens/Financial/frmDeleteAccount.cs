using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Liriou_s_Burguer.Screens.Financial
{
    public partial class frmDeleteAccount : Form
    {
        public frmDeleteAccount()
        {
            InitializeComponent();
        }

        private void nudID_ValueChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(nudID.Value);

            Business.AccountBusiness busaccount = new Business.AccountBusiness();
            Database.Entities.tb_account account = busaccount.ConsultarPorID(id);

            if (account == null)
            {
                txtNome.Text = string.Empty;
                mtxtIdentificação.Text = string.Empty;
                nudValor.Value = Convert.ToDecimal("0,00");
                rtxtDescrição.Text = string.Empty;
            }
            else
            {
                txtNome.Text = account.nm_account;
                mtxtIdentificação.Text = account.nr_identification;
                nudValor.Value = Convert.ToDecimal(account.vl_value);
                rtxtDescrição.Text = account.ds_note;
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(nudID.Value);

            Business.AccountBusiness busAccount = new Business.AccountBusiness();
            busAccount.Remover(id);

            MessageBox.Show("Produto deletado com sucesso","Deletado", MessageBoxButtons.OK);
        }
    }
}
