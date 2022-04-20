namespace DesktopApp
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void MenuItemVerEmpleados_Click(object sender, EventArgs e)
        {
            frmVerEmpleados frmVer = new frmVerEmpleados();
            frmVer.ShowDialog();
        }

        private void MenuItemAgregarEmpleado_Click(object sender, EventArgs e)
        {
            frmAgregarEmpleado frmAdd = new frmAgregarEmpleado();
            frmAdd.ShowDialog();
        }
    }
}