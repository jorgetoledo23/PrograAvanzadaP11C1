namespace Clases_y_Herencia
{
    //HERENCIA
    public class Vendedor : Empleado
    {
        public string nCredencial { get; set; }


        public override string ToString()
        {
            return base.ToString() + $" N° Credencial: {nCredencial}";
        }

        public override string MarcarIngreso()
        {
            return base.MarcarIngreso();
        }

        public override string InfoEmpleado()
        {
            return nCredencial;
        }
    }
}
