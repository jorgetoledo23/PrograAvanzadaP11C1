using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class EquiposController : Controller
    {

        private readonly AppDbContext _context;
        public EquiposController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var Equipos = _context.tblEquipos.ToList();
            return View(Equipos);
        }

        public IActionResult CrearEquipo()
        {
            ViewData["Marcas"] = new SelectList(_context.tblMarcas.ToList(), "Id", "Name");
            ViewData["Lineas"] = new SelectList(_context.tblLineas.ToList(), "Id", "Name");
            ViewData["Categorias"] = new SelectList(_context.tblCategorias.ToList(), "Id", "Name");
            return View();
        }

        [HttpPost]
        public IActionResult CrearEquipo(Equipo E)
        {
            return View();
        }


    }
}
