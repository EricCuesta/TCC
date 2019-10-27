using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Liriou_s_Burguer.Screens.Manager
{
    public partial class frmLiriousBurguer : Form
    {
        public frmLiriousBurguer()
        {
            InitializeComponent();
            CustomizeDesign();
        }

        private void imgMenu_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 40)
                MenuVertical.Width = 230;
            else
                MenuVertical.Width = 40;
        }

        private void CustomizeDesign()
        {
            panelSubMenuRecursosHumanos.Visible = false;
            panelSubMenuFinanceiro.Visible = false;
            panelSubMenuEstoque.Visible = false;
            panelSubMenuSuprimentos.Visible = false;
        }

        private void HideSubMenu()
        {
            if (panelSubMenuRecursosHumanos.Visible == true)
                panelSubMenuRecursosHumanos.Visible = false;
            if (panelSubMenuFinanceiro.Visible == true)
                panelSubMenuFinanceiro.Visible = false;
            if (panelSubMenuEstoque.Visible == true)
                panelSubMenuEstoque.Visible = false;
            if (panelSubMenuSuprimentos.Visible == true)
                panelSubMenuSuprimentos.Visible = false;
        }

        private void ShowSubMenu(Panel SubMenu)
        {
            if (SubMenu.Visible == true)
            {
                HideSubMenu();
                SubMenu.Visible = false;
            }
            else
            {
                HideSubMenu();
                SubMenu.Visible = true;
            }
        }

        private void btnRecursosHumanos_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSubMenuRecursosHumanos);
        }

        private void btnFinanceiro_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSubMenuFinanceiro);
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSubMenuEstoque);
        }

        private void btnSuprimentos_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSubMenuSuprimentos);
        }

        private Form activeForm = null;
        private void openContedor(Form Contedor)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = Contedor;
            Contedor.TopLevel = false;
            Contedor.FormBorderStyle = FormBorderStyle.None;
            Contedor.Dock = DockStyle.Fill;
            panelContedor.Controls.Add(Contedor);
            panelContedor.Tag = Contedor;
            Contedor.BringToFront();
            Contedor.Show();
        }

        private void btnCadastrarFuncionário_Click(object sender, EventArgs e)
        {
            openContedor(new HumanResources.frmRegisterEmployee());
            HideSubMenu();
        }

        private void btnConsultarFuncionário_Click(object sender, EventArgs e)
        {
            openContedor(new HumanResources.frmConsultEmployee());
            HideSubMenu();
        }

        private void btnAlterarFuncionário_Click(object sender, EventArgs e)
        {
            openContedor(new HumanResources.frmChangeEmployee());
            HideSubMenu();
        }

        private void btnDemitirFuncionário_Click(object sender, EventArgs e)
        {
            openContedor(new HumanResources.frmDismissEmployee());
            HideSubMenu();
        }

        private void btnFolhaDePagamento_Click(object sender, EventArgs e)
        {
            openContedor(new HumanResources.frmPayroll());
            HideSubMenu();
        }

        private void btnConsultarCartãoDePonto_Click(object sender, EventArgs e)
        {
            openContedor(new HumanResources.frmConsultTimeCard());
            HideSubMenu();
        }

        private void imgFechar_MouseEnter(object sender, EventArgs e)
        {
            imgFechar.Image = Properties.Resources.Fechar01;
            imgFechar.Image = Properties.Resources.Fechar02;
        }

        private void imgFechar_MouseLeave(object sender, EventArgs e)
        {
            imgFechar.Image = Properties.Resources.Fechar02;
            imgFechar.Image = Properties.Resources.Fechar01;
        }

        private void imgMinimizar_MouseEnter(object sender, EventArgs e)
        {
            imgMinimizar.Image = Properties.Resources.Minimizar01;
            imgMinimizar.Image = Properties.Resources.Minimizar02;
        }

        private void imgMinimizar_MouseLeave(object sender, EventArgs e)
        {
            imgMinimizar.Image = Properties.Resources.Minimizar02;
            imgMinimizar.Image = Properties.Resources.Minimizar01;
        }

        private void imgFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void imgMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            openContedor(new Financial.Client.frmRegisterCustomer());
            HideSubMenu();
        }

        private void btnConsultarCliente_Click(object sender, EventArgs e)
        {
            openContedor(new Financial.Client.frmConsultCustomer());
            HideSubMenu();
        }

        private void btnAlterarCliente_Click(object sender, EventArgs e)
        {
            openContedor(new Financial.Client.frmChangeCustomer());
            HideSubMenu();
        }

        private void btnDeletarCliente_Click(object sender, EventArgs e)
        {
            openContedor(new Financial.Client.frmDeleteClient());
            HideSubMenu();
        }

        private void btnCadastrarFornecedor_Click(object sender, EventArgs e)
        {
            openContedor(new Financial.Provider.frmRegisterSupplier());
            HideSubMenu();
        }

        private void btnConsultarFornecedor_Click(object sender, EventArgs e)
        {
            openContedor(new Financial.Provider.frmConsultSupplier());
            HideSubMenu();
        }

        private void btnAlterarFornecedor_Click(object sender, EventArgs e)
        {
            openContedor(new Financial.Provider.frmChangeProvider());
            HideSubMenu();
        }

        private void btnDeletarFornecedor_Click(object sender, EventArgs e)
        {
            openContedor(new Financial.Provider.frmDeleteSupplier());
            HideSubMenu();
        }

        private void btnCadastrarProdutos_Click(object sender, EventArgs e)
        {
            openContedor(new Stock.Products.frmRegisterProducts());
            HideSubMenu();
        }

        private void btnConsultarProdutos_Click(object sender, EventArgs e)
        {
            openContedor(new Stock.Products.frmBrowseProducts());
            HideSubMenu();
        }

        private void btnAlterarProdutos_Click(object sender, EventArgs e)
        {
            openContedor(new Stock.Products.frmChangeProducts());
            HideSubMenu();
        }

        private void btnDeletarProdutos_Click(object sender, EventArgs e)
        {
            openContedor(new Stock.Products.frmDeleteProducts());
            HideSubMenu();
        }

        private void btnCadastrarEstoque_Click(object sender, EventArgs e)
        {
            openContedor(new Stock.frmRegisterStock());
            HideSubMenu();
        }

        private void btnAlterarEstoque_Click(object sender, EventArgs e)
        {
            openContedor(new Stock.frmChangeInventory());
            HideSubMenu();
        }

        private void btnDeletarEstoque_Click(object sender, EventArgs e)
        {
            openContedor(new Stock.frmDeleteInventory());
            HideSubMenu();
        }

        private void btnCadastrarSuprimentos_Click(object sender, EventArgs e)
        {
            openContedor(new Supplies.frmRegisterSupplies());
            HideSubMenu();
        }

        private void btnConsultarSuprimentos_Click(object sender, EventArgs e)
        {
            openContedor(new Supplies.frmConsultSupplies());
            HideSubMenu();
        }

        private void btnAlterarSuprimentos_Click(object sender, EventArgs e)
        {
            openContedor(new Supplies.frmChangeSupplies());
            HideSubMenu();
        }

        private void btnDeletarSuprimentos_Click(object sender, EventArgs e)
        {
            openContedor(new Supplies.frmDeleteSupplies());
            HideSubMenu();
        }
    }
}
