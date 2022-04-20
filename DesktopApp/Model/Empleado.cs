using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace DesktopApp.Model
{
    public class Empleado
    {
        public int EmpleadoId { get; set; } // PK

        [Required]
        public string Rut { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }

        public DateTime FechaNacimiento { get; set; }

    }
}
