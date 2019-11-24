using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Liriou_s_Burguer.Screens.HumanResources
{
    public partial class frmEmployeeTimeCard : Form
    {
        public frmEmployeeTimeCard()
        {
            InitializeComponent();
        }

        private void btnBaterPonto_Click(object sender, EventArgs e)
        {
            Database.Entities.tb_points points = new Database.Entities.tb_points();

            if (lblInício.Text == "00:00:00")
            {
                lblInício.Text = DateTime.Now.ToString("HH:mm:ss");
                MessageBox.Show("Início do Espediente batido às " + lblInício.Text);
            }
            else if (lblInício.Text != "00:00:00" && lblInícioDoIntervalo.Text == "00:00:00")
            {
                lblInícioDoIntervalo.Text = DateTime.Now.ToString("HH:mm:ss");
                MessageBox.Show("Início do Intervalo batido às " + lblInícioDoIntervalo.Text);
            }
            else if (lblInícioDoIntervalo.Text != "00:00:00" && lblTérminoDoIntervalo.Text == "00:00:00")
            {
                lblTérminoDoIntervalo.Text = DateTime.Now.ToString("HH:mm:ss");
                MessageBox.Show("Término do Intervalo batido às " + lblTérminoDoIntervalo.Text);
            }
            else if (lblTérminoDoIntervalo.Text != "00:00:00" && lblTérmino.Text == "00:00:00")
            {
                lblTérmino.Text = DateTime.Now.ToString("HH:mm:ss");
                MessageBox.Show("Término do Espediente batido às " + lblTérmino.Text);

                points.dt_points = DateTime.Now.ToString("dd/MM/yyyy");
                points.hr_input = lblInício.Text;
                points.hr_intInput = lblInícioDoIntervalo.Text;
                points.hr_intOutput = lblTérminoDoIntervalo.Text;
                points.hr_output = lblTérmino.Text;

                Business.PointsBusiness buspoints = new Business.PointsBusiness();
                buspoints.Inserir(points);

                MessageBox.Show("Informações do Cartão de ponto salvas no sistema");
            }
        }
    }
}
