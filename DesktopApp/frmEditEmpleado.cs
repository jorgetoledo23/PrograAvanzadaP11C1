using DesktopApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp
{
    public partial class frmEditEmpleado : Form
    {
        private int _EmpleadoId;
        private Empleado? Empleado;
        public frmEditEmpleado(int EmpleadoId)
        {
            InitializeComponent();
            _EmpleadoId = EmpleadoId;
            LlenarDatos();
        }


        private void LlenarDatos()
        {
            using (var context = new AppDbContext())
            {
                Empleado = context.Empleados
                    .Where(x => x.EmpleadoId == _EmpleadoId).FirstOrDefault();

                txtRut.Text = Empleado.Rut;
                txtNombre.Text = Empleado.Nombre;
                txtApellidos.Text = Empleado.Apellido;
                txtCorreo.Text = Empleado.Correo;
                txtTelefono.Text = Empleado.Telefono;
                dateTimePicker1.Value = Empleado.FechaNacimiento;
               
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Empleado.Rut = txtRut.Text;
            Empleado.Nombre = txtNombre.Text;
            Empleado.Apellido = txtApellidos.Text;
            Empleado.Correo = txtCorreo.Text;
            Empleado.Telefono = txtTelefono.Text;
            Empleado.FechaNacimiento = dateTimePicker1.Value;

            using (var context = new AppDbContext())
            {
                context.Update(Empleado);
                context.SaveChanges();
            }

            this.Close();
        }
    }
}
