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
    public partial class frmRegisterAccount : Form
    {
        public frmRegisterAccount()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Database.Entities.tb_account account = new Database.Entities.tb_account();
                account.nm_account = txtNome.Text.Trim();
                account.nr_identification = mtxtIdentificação.Text.Trim();
                account.ds_note = rtxtDescrição.Text;
                account.vl_value = nudValor.Value;

                Business.AccountBusiness busaccount = new Business.AccountBusiness();
                busaccount.Inserir(account);

                MessageBox.Show("Conta cadastrado com sucesso","OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
