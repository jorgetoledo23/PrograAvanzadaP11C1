namespace API.Model
{
    public class Departamento
    {
        public int Id { get; set; }
        public string CompanyNo { get; set; }
        public string Descripcion { get; set; }
        public List<Empleado> Empleados { get; set; }
    }
}
