using API.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadoController : ControllerBase
    {
        private readonly AppDbContext _context;
        public EmpleadoController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("GetAllEmpleados")]
        public ActionResult<List<Empleado>> GetAllEmpleados()
        {
            var Empleados = _context.Empleados.Include(x => x.Departamento).ToList();
            return Ok(Empleados);
        }

        [HttpPost]
        [Route("AddEmpleado")]
        public ActionResult AddEmpleado(EmpleadoDTO E)
        {
            Empleado Emp = new Empleado()
            {
                Apellido = E.Apellido,
                Name = E.Name,
                DepartamentoId = E.DepartamentoId
            };
            _context.Empleados.Add(Emp);    
            _context.SaveChanges();
            return Ok();
        }


    }
}
