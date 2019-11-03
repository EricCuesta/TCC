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
    public partial class frmEmployeeTimeCard : Form
    {
        public frmEmployeeTimeCard()
        {
            InitializeComponent();
        }

        private void DataHora_Tick(object sender, EventArgs e)
        {
            lblHorárioData.Text = DateTime.Now.ToString("dd/MM/yyyy    hh:mm:ss");
        }

        private void btnBaterPonto_Click(object sender, EventArgs e)
        {
            Database.Entities.tb_points points = new Database.Entities.tb_points();

            if (lblInício.Text == "_ _ / _ _ / _ _ _ _ 00:00")
            {
                lblInício.Text = DateTime.Now.ToString("dd/MM/yyyy    hh:mm:ss");
                MessageBox.Show("Início do Espediente batido às " + lblInício.Text);
            }
            else if (lblInício.Text != "_ _ / _ _ / _ _ _ _ 00:00" && lblInícioDoIntervalo.Text == "_ _ / _ _ / _ _ _ _ 00:00")
            {
                lblInícioDoIntervalo.Text = DateTime.Now.ToString("dd/MM/yyyy    hh:mm:ss");
                MessageBox.Show("Início do Intervalo batido às " + lblInícioDoIntervalo.Text);
            }
            else if (lblInícioDoIntervalo.Text != "_ _ / _ _ / _ _ _ _ 00:00" && lblTérminoDoIntervalo.Text == "_ _ / _ _ / _ _ _ _ 00:00")
            {
                lblTérminoDoIntervalo.Text = DateTime.Now.ToString("dd/MM/yyyy    hh:mm:ss");
                MessageBox.Show("Término do Intervalo batido às " + lblTérminoDoIntervalo.Text);
            }
            else if (lblTérminoDoIntervalo.Text != "_ _ / _ _ / _ _ _ _ 00:00" && lblTérmino.Text == "_ _ / _ _ / _ _ _ _ 00:00")
            {
                lblTérmino.Text = DateTime.Now.ToString("dd/MM/yyyy    hh:mm:ss");
                MessageBox.Show("Término do Espediente batido às " + lblTérmino.Text);

                string substituir = lblTérmino.Text.Replace("yyyy-MM-ss", "");
                points.hr_output = substituir.Trim();

                string substituir1 = lblInícioDoIntervalo.Text.Replace("yyyy-MM-ss", "");
                points.hr_intInput = substituir1.Trim();

                string substituir2 = lblInício.Text.Replace("yyyy-MM-ss", "");
                points.hr_input = substituir2.Trim();

                string substituir3 = lblTérminoDoIntervalo.Text.Replace("yyyy-MM-ss", "");
                points.hr_intOutput = substituir3.Trim();

                string substituir4 = lblTérminoDoIntervalo.Text.Replace("hh:mm:ss", "");
                points.hr_intOutput = substituir4.Trim();

                Business.PointsBusiness buspoints = new Business.PointsBusiness();
                buspoints.Inserir(points);

                MessageBox.Show("Informações do Cartão de ponto salvas no sistema");
            }
        }
    }
}
