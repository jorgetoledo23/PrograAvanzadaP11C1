namespace DesktopApp
{
    partial class frmMenuPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemVerEmpleados = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemAgregarEmpleado = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEditarEmpleado = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemArchivarEmpleado = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 28);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.gestionEmpleadosToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 28);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // gestionEmpleadosToolStripMenuItem
            // 
            this.gestionEmpleadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemVerEmpleados,
            this.MenuItemAgregarEmpleado,
            this.MenuItemEditarEmpleado,
            this.MenuItemArchivarEmpleado});
            this.gestionEmpleadosToolStripMenuItem.Name = "gestionEmpleadosToolStripMenuItem";
            this.gestionEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.gestionEmpleadosToolStripMenuItem.Text = "Gestion Empleados";
            // 
            // MenuItemVerEmpleados
            // 
            this.MenuItemVerEmpleados.Name = "MenuItemVerEmpleados";
            this.MenuItemVerEmpleados.Size = new System.Drawing.Size(224, 26);
            this.MenuItemVerEmpleados.Text = "Ver Empleados";
            this.MenuItemVerEmpleados.Click += new System.EventHandler(this.MenuItemVerEmpleados_Click);
            // 
            // MenuItemAgregarEmpleado
            // 
            this.MenuItemAgregarEmpleado.Name = "MenuItemAgregarEmpleado";
            this.MenuItemAgregarEmpleado.Size = new System.Drawing.Size(224, 26);
            this.MenuItemAgregarEmpleado.Text = "Agregar Empleado";
            // 
            // MenuItemEditarEmpleado
            // 
            this.MenuItemEditarEmpleado.Name = "MenuItemEditarEmpleado";
            this.MenuItemEditarEmpleado.Size = new System.Drawing.Size(224, 26);
            this.MenuItemEditarEmpleado.Text = "Editar Empleado";
            // 
            // MenuItemArchivarEmpleado
            // 
            this.MenuItemArchivarEmpleado.Name = "MenuItemArchivarEmpleado";
            this.MenuItemArchivarEmpleado.Size = new System.Drawing.Size(224, 26);
            this.MenuItemArchivarEmpleado.Text = "Archivar Empleados";
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenuPrincipal";
            this.Text = "Menu Principal";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem gestionEmpleadosToolStripMenuItem;
        private ToolStripMenuItem MenuItemVerEmpleados;
        private ToolStripMenuItem MenuItemAgregarEmpleado;
        private ToolStripMenuItem MenuItemEditarEmpleado;
        private ToolStripMenuItem MenuItemArchivarEmpleado;
    }
}