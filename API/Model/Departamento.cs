namespace API.Model
{
    public class Departamento
    {
        public int Id { get; set; }
        public string CompanyNo { get; set; }
        public string Descripcion { get; set; }
        public virtual List<Empleado> Empleados { get; set; }
    }
}
