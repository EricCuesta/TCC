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
    public partial class frmManagerMenu : Form
    {
        public frmManagerMenu()
        {
            InitializeComponent();
            panelContedor.Visible = false;
            CustomizeDesign();
        }

        public void LoadScreen(Database.Entities.tb_employees employees)
        {
            toolStripStatusUsuário.Text = employees.nm_firstName + " entrou  às " + DateTime.Now;
            if (employees.bt_admin == false)
            {
                if(employees.bt_rh == false)
                {
                    btnRecursosHumanos.Visible = false;
                }

                if (employees.bt_provider == false)
                {
                    btnFornecedor.Visible = false;
                }

                if (employees.bt_financial == false)
                {
                    btnFinanceiro.Visible = false;
                }

                if(employees.bt_stock == false)
                {
                    btnEstoque.Visible = false;
                }

                if(employees.bt_crm == false)
                {
                    btnCRM.Visible = false;
                }
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void panelTítulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void CustomizeDesign()
        {
            panelSubMenuRecursosHumanos.Visible = false;
            panelSubMenuFinanceiro.Visible = false;
            panelSubMenuFornecedor.Visible = false;
            panelSubMenuEstoque.Visible = false;
            panelSubMenuCRM.Visible = false;
        }

        private void HideSubMenu()
        {
            if (panelSubMenuRecursosHumanos.Visible == true)
                panelSubMenuRecursosHumanos.Visible = false;
            if (panelSubMenuFinanceiro.Visible == true)
                panelSubMenuFinanceiro.Visible = false;
            if (panelSubMenuFornecedor.Visible == true)
                panelSubMenuFornecedor.Visible = false;
            if (panelSubMenuEstoque.Visible == true)
                panelSubMenuEstoque.Visible = false;
            if (panelSubMenuCRM.Visible == true)
                panelSubMenuCRM.Visible = false;
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

        private void btnFornecedor_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSubMenuFornecedor);
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSubMenuEstoque);
        }

        private void btnCRM_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSubMenuCRM);
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
            panelContedor.Visible = true;
            Contedor.Show();
        }

        private void imgFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void imgMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void btnFluxoDeCaixa_Click(object sender, EventArgs e)
        {
            openContedor(new Financial.frmCashflow());
            HideSubMenu();
        }

        private void btnCartãoDePonto_Click(object sender, EventArgs e)
        {
            openContedor(new Employee.frmEmployeeTimeCard());
            HideSubMenu();
        }

        private void btnCadastrarConta_Click(object sender, EventArgs e)
        {
            openContedor(new Financial.frmRegisterAccount());
            HideSubMenu();
        }

        private void btnConsultarConta_Click(object sender, EventArgs e)
        {
            openContedor(new Financial.frmQueryAccount());
            HideSubMenu();
        }

        private void btnAlterarConta_Click(object sender, EventArgs e)
        {
            openContedor(new Financial.frmChangeAccount());
            HideSubMenu();
        }

        private void btnDeletarConta_Click(object sender, EventArgs e)
        {
            openContedor(new Financial.frmDeleteAccount());
            HideSubMenu();
        }

        private void btnCadastrarFornecedor_Click(object sender, EventArgs e)
        {
            openContedor(new Provider.frmRegisterSupplier());
            HideSubMenu();
        }

        private void btnConsultarFornecedor_Click(object sender, EventArgs e)
        {
            openContedor(new Provider.frmConsultSupplier());
            HideSubMenu();
        }

        private void btnAlterarFornecedor_Click(object sender, EventArgs e)
        {
            openContedor(new Provider.frmChangeProvider());
            HideSubMenu();
        }

        private void btnDeletarFornecedor_Click(object sender, EventArgs e)
        {
            openContedor(new Provider.frmDeleteSupplier());
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

        private void btnCadastrarSuprimentos_Click(object sender, EventArgs e)
        {
            openContedor(new Stock.Supplies.frmRegisterSupplies());
            HideSubMenu();
        }

        private void btnConsultarSuprimentos_Click(object sender, EventArgs e)
        {
            openContedor(new Stock.Supplies.frmConsultSupplies());
            HideSubMenu();
        }

        private void btnAlterarSuprimentos_Click(object sender, EventArgs e)
        {
            openContedor(new Stock.Supplies.frmChangeSupplies());
            HideSubMenu();
        }

        private void btnDeletarSuprimentos_Click(object sender, EventArgs e)
        {
            openContedor(new Stock.Supplies.frmDeleteSupplies());
            HideSubMenu();
        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            openContedor(new CRM.frmRegisterCustomer());
            HideSubMenu();
        }

        private void btnConsultarCliente_Click(object sender, EventArgs e)
        {
            openContedor(new CRM.frmConsultCustomer());
            HideSubMenu();
        }

        private void btnAlterarCliente_Click(object sender, EventArgs e)
        {
            openContedor(new CRM.frmChangeCustomer());
            HideSubMenu();
        }

        private void btnDeletarCliente_Click(object sender, EventArgs e)
        {
            openContedor(new CRM.frmDeleteClient());
            HideSubMenu();
        }

        private void imgLogotipo_Click(object sender, EventArgs e)
        {
            panelContedor.Visible = false;
        }
    }
}
