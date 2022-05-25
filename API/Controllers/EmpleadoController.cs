using API.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles ="Free")]
    public class EmpleadoController : ControllerBase
    {
        private readonly AppDbContext _context;
        public EmpleadoController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("GetAllEmpleados")]
        [AllowAnonymous]
        public ActionResult<List<Empleado>> GetAllEmpleados()
        {
            var Empleados = _context.Empleados.ToList();
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

        [HttpPut]
        [Route("UptEmpleado")]
        public ActionResult UptEmpleado(EmpleadoDTO EmpDTO)
        {
            var Emp = _context.Empleados.FirstOrDefault(e => e.Id == EmpDTO.Id);
            if (Emp == null) return BadRequest();

            Emp.Name = EmpDTO.Name;
            Emp.Apellido = EmpDTO.Apellido;
            Emp.DepartamentoId = EmpDTO.DepartamentoId;

            _context.Empleados.Update(Emp);
            _context.SaveChanges();
            return Ok();
        }

        [HttpDelete]
        [Route("DelEmpleado")]
        public ActionResult DelEmpleado(int id)
        {
            var Emp = _context.Empleados.FirstOrDefault(e => e.Id == id);
            if (Emp == null) return BadRequest();
            _context.Remove(Emp);
            _context.SaveChanges();
            return Ok();
        }

        [HttpGet]
        [Route("GetEmpleadosByDept")]
        public async Task<ActionResult> GetEmpleadosByDept(int id)
        {
            var empleados = await _context.Empleados.Where(e => e.DepartamentoId == id).ToListAsync();
            return Ok(empleados);
        }

        [HttpGet]
        [Route("GetEmpleadosByDeptName")]
        public async Task<ActionResult> GetEmpleadosByDept(string Departamento)
        {
            var empleados2 = await _context.Empleados.Where(e => e.Departamento.Descripcion == Departamento).ToListAsync();
            //var empleados = await _context.Empleados.Where(e => e.DepartamentoId == id).ToListAsync();
            return Ok(empleados2);
        }














    }
}
