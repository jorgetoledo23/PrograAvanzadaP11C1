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


        [HttpPost]
        [Route("AddDepartment")]
        public ActionResult AddDepartment(Departamento D)
        {
            _context.Add(D);
            _context.SaveChanges();
            return Ok();
        }

    }
}
