namespace Clases_y_Herencia
{
    public abstract class Empleado
    {
        public string Rut { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }
        public string Departamento { get; set; }

        public override string ToString()
        {
            return $"Rut: {Rut}, Nombre: {Nombre}, " +
                $"Apellido: {Apellidos}";
        }

        //Metodo Normal que tendra la misma implementacion en todas las clases Hijas
        public string FirmarContrato()
        {
            //Firma Contrato
            return $"Empleado: {Rut} Firma su contrato el dia {DateTime.Now}";
        }

        //Virtual => Que el metodo puede ser Override (Sobreescrito) (Opcional)
        public virtual string MarcarIngreso()
        {
            //Marcar con Crendecial en Entrada
            return $"Empleado: {Rut }, Marca ingreso el dia {DateTime.Now} ";
        }

        //
        public abstract string InfoEmpleado();

    }
}
