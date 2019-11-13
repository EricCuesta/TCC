using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Liriou_s_Burguer.Screens.Manager.CRM
{
    public partial class frmEmailSending : Form
    {
        public frmEmailSending()
        {
            InitializeComponent();
        }

        private void btnAnexar_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrir = new OpenFileDialog();
            abrir.Multiselect = true;

            if (abrir.ShowDialog() == DialogResult.OK)
            {
                foreach (var arquivo in abrir.FileNames)
                {
                    listAnexo.Items.Add(arquivo);
                }
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();

                foreach (string arquivo in listAnexo.Items)
                {
                    msg.Attachments.Add(new System.Net.Mail.Attachment(arquivo));
                }

                msg.To.Add(txtPara.Text);
                msg.Subject = txtAssunto.Text;
                msg.SubjectEncoding = System.Text.Encoding.UTF8;
                msg.Bcc.Add(txtBcc.Text);

                msg.Body = rtxtConteúdo.Text;
                msg.BodyEncoding = System.Text.Encoding.UTF8;
                msg.IsBodyHtml = true;
                msg.From = new System.Net.Mail.MailAddress("eric.vitor006@gmail.com");


                System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient();

                client.Credentials = new System.Net.NetworkCredential("eric.vitor006@gmail.com", "5924Capivara");
                client.Port = 587;
                client.EnableSsl = true;

                client.Host = "smtp.gmail.com";

                client.Send(msg);
                MessageBox.Show("E-mail enviado com sucesso","Enviado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Falha no envio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
