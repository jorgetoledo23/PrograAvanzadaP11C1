using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesktopApp.Model;

namespace DesktopApp
{
    public partial class frmAgregarEmpleado : Form
    {
        public frmAgregarEmpleado()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Empleado E = new Empleado()
            {
                Rut = txtRut.Text,
                Nombre = txtNombre.Text,
                Apellido = txtApellidos.Text,
                Correo = txtCorreo.Text,
                Telefono = txtTelefono.Text,
                FechaNacimiento = Convert.ToDateTime(dateTimePicker1.Value.ToString("d"))
            };

            using (var context = new AppDbContext())
            {
                context.Update(E);
                context.Add(E);
                context.SaveChanges();
                MessageBox.Show("Empleado Agregado!","Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
