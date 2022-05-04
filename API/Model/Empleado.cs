﻿namespace API.Model
{
    public class Empleado
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Apellido { get; set; }
        public int DepartamentoId { get; set; }
        public virtual Departamento Departamento { get; set; }

    }

}