using API.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartamentoController : ControllerBase
    {
        private readonly AppDbContext _context;
        public DepartamentoController(AppDbContext context)
        {
            _context = context;
        }

        private static List<Departamento> listaDepartamentos = new List<Departamento> {
            new Departamento {
                Id = 1,
                CompanyNo = "Inacap",
                Descripcion = "Recursos Humanos"
            }
        };

        [HttpGet]
        [Route("GetAllDepartments")]
        public ActionResult<List<Departamento>> GetAllDepartments()
        {
            return Ok(_context.Departamentos.ToList());
        }

        [HttpGet]
        [Route("GetDepartmentById")]
        public ActionResult GetDepartmentById(int Id)
        {
            var Dpto = _context.Departamentos.FirstOrDefault(d => d.Id == Id);
            //var Dpto2 = _context.Departamentos.Where(d => d.Id == Id).FirstOrDefault();

            if (Dpto == null) return BadRequest();
            return Ok(Dpto);
        }



        [HttpPost]
        [Route("AddDepartment")]
        public ActionResult AddDepartment(DepartamentoDTO D)
        {
            Departamento Dpto = new Departamento()
            {
                Id = D.Id,
                CompanyNo = D.CompanyNo,
                Descripcion = D.Descripcion
            };
            _context.Add(Dpto);
            _context.SaveChanges();
            return Ok();
        }

        [HttpPut]
        [Route("UptDepartment")]
        public ActionResult UptDepartment(DepartamentoDTO D)
        {
            var Dpto = _context.Departamentos.FirstOrDefault(dpto => dpto.Id == D.Id);
            if (Dpto == null) BadRequest();
            else
            {
                Dpto.CompanyNo = D.CompanyNo;
                Dpto.Descripcion = D.Descripcion;
            }
            _context.Update(Dpto);
            _context.SaveChanges();
            return Ok();
        }


        [HttpDelete]
        [Route("DelDepartment")]
        public ActionResult DelDepartment(DepartamentoDTO D)
        {
            var Dpto = _context
                .Departamentos.FirstOrDefault(dept => dept.Id == D.Id);
            if (Dpto == null) return BadRequest();
            else
            {
                _context.Remove(Dpto);
                _context.SaveChanges();
                return Ok();
            }
        }










    }

}
