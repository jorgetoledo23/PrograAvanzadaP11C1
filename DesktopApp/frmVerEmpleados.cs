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
    public partial class frmVerEmpleados : Form
    {
        public frmVerEmpleados()
        {
            InitializeComponent();

            //Cargar Los Datos

            using (var context = new AppDbContext())
            {
                var Empleados = context.Empleados.ToList();
                LlenarLista(Empleados);
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            using (var context = new AppDbContext())
            {
                var Empleados = context.Empleados
                    .Where(emp => emp.Rut.Contains(textBox1.Text) 
                    || emp.Nombre.Contains(textBox1.Text) 
                    || emp.Apellido.Contains(textBox1.Text) 
                    || emp.Correo.Contains(textBox1.Text))
                    .ToList();
                LlenarLista(Empleados);
            }
            
        }


        private void LlenarLista(List<Empleado> lista)
        {
            foreach (var Empleado in lista)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = Empleado.EmpleadoId.ToString();
                listViewItem.SubItems.Add(Empleado.Rut);
                listViewItem.SubItems.Add(Empleado.Nombre);
                listViewItem.SubItems.Add(Empleado.Apellido);
                listViewItem.SubItems.Add(Empleado.Correo);
                listViewItem.SubItems.Add(Empleado.Telefono);
                listViewItem.SubItems.Add(Empleado.FechaNacimiento.ToString("d"));
                listView1.Items.Add(listViewItem);
            }
        }
    }
}
