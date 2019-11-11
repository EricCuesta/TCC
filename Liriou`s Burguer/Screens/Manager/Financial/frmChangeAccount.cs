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
    public partial class frmChangeAccount : Form
    {
        public frmChangeAccount()
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

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                Database.Entities.tb_account account = new Database.Entities.tb_account();
                account.id_account = Convert.ToInt32(nudID.Value);
                account.nm_account = txtNome.Text.Trim();
                account.nr_identification = mtxtIdentificação.Text.Trim();
                account.vl_value = Convert.ToDecimal(nudValor.Value);
                account.ds_note = rtxtDescrição.Text.Trim();

                Business.AccountBusiness busaccount = new Business.AccountBusiness();
                busaccount.Alterar(account);

                MessageBox.Show("Produto alterado com sucesso");
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
