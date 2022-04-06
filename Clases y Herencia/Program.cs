using Clases_y_Herencia;

List<Empleado> listaEmpleados = new List<Empleado>();
 
Vendedor Vendedor = new Vendedor()
{
    Rut = "11.111.111-1",
    Nombre = "Vendedor 1",
    Apellidos = "Vendedor Vendedor",
    nCredencial = "34323212123"
};
JefeDepartamento Jefe = new JefeDepartamento()
{
    Rut = "11.111.111-1",
    Nombre = "Vendedor 1",
    Apellidos = "Vendedor Vendedor"
};

listaEmpleados.Add(Jefe);
listaEmpleados.Add(Vendedor);

foreach (var E in listaEmpleados)
{
    //Console.WriteLine(E.GetType());
    if (E.GetType().Equals(Vendedor.GetType()))
    {
        Vendedor V = (Vendedor)E;
        Console.WriteLine(V.nCredencial);
    }
}
/*


Console.WriteLine(Vendedor.ToString());
Console.WriteLine(Vendedor.FirmarContrato());
Console.WriteLine(Vendedor.MarcarIngreso());
Console.WriteLine(Vendedor);

//Console.WriteLine($"La hora es {Hora.Horas}");*/
