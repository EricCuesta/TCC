﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Liriou_s_Burguer.Screens.Manager.HumanResources
{
    public partial class frmRegisterEmployee : Form
    {
        public frmRegisterEmployee()
        {
            InitializeComponent();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            try
            {
                Model.EmployeesModel model = new Model.EmployeesModel();
                model.Nome = txtNome.Text;
                model.LastName = txtSobrenome.Text;
                model.Sex = cboSexo.Text;
                model.Birth = dtpNascimento.MinDate;
                model.CPF = mtxtCPF.Text;
                model.RG = mtxtRG.Text;
                model.State = cboEstado.Text;
                model.CEP = mtxtCEP.Text;
                model.Note = txtComplemento.Text;
                model.Address = txtEndereço.Text;
                model.Cellphone = mtxtCelular.Text;
                model.Tellphone = mtxtTelefone.Text;
                model.Email = txtEmail.Text;
                model.Password = txtSenha.Text;

                Business.EmployeesBusiness EB = new Business.EmployeesBusiness();
                string r = EB.VerificarCadastro(model);

                if (r == "true")
                {
                    this.Hide();
                    frmRegisterEmployee1 tela = new frmRegisterEmployee1();
                    tela.Show();
                }
                else
                {
                    MessageBox.Show(r);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro. Tente mais tarde.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void mtxtCEP_TextChanged(object sender, EventArgs e)
        {
            if (mtxtCEP.Text.Length == 9)
            {
                string CEP = mtxtCEP.Text;
                CorreioApi.CorreioApi api = new CorreioApi.CorreioApi();
                txtEndereço.Text = api.Buscar(CEP);
            }
        }
    }
}
