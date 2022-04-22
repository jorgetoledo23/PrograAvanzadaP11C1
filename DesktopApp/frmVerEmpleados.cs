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
        private int EmpleadoId;
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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEdit.Enabled = true;
            button1.Enabled = true;
            //identificar el ID del empleado
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                EmpleadoId = Convert.ToInt32(item.Text);
                //MessageBox.Show(IdEmpleado);
            }

            



        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmEditEmpleado frmEdit = new frmEditEmpleado(EmpleadoId);
            frmEdit.ShowDialog();
            listView1.Items.Clear();
            using (var context = new AppDbContext())
            {
                var Empleados = context.Empleados.ToList();
                LlenarLista(Empleados);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de Eliminar al Empleado?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                //Eliminar
                using (var context = new AppDbContext())
                {
                    var Emp = context.Empleados.Where(emp => emp.EmpleadoId == EmpleadoId).First();
                    context.Remove(Emp);                  
                    context.SaveChanges();
                    listView1.Items.Clear();
                    var Empleados = context.Empleados.ToList();
                    LlenarLista(Empleados);
                }

            }
        }
    }
}
