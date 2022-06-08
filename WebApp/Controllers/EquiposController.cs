using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class EquiposController : Controller
    {

        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _environment;
        public EquiposController(AppDbContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }
        public IActionResult Index()
        {
            var Equipos = _context.tblEquipos
                .Include(e => e.Marca)
                .Include(e => e.Linea)
                .Include(e => e.Categoria)
                .ToList();

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
        public async Task<IActionResult> CrearEquipo(Equipo E)
        {
            if (ModelState.IsValid)
            {
                if (E.ImagenFile == null) E.ImagenUrl = "no-disponible.png";
                else
                {
                    string wwwRootPath = _environment.WebRootPath;
                    string fileName = Path.GetFileNameWithoutExtension(E.ImagenFile.FileName);
                    string extension = Path.GetExtension(E.ImagenFile.FileName);
                    E.ImagenUrl = fileName + DateTime.Now.ToString("ddMMyyyyHHmmss") + extension; //foto08062022131545.png 

                    string path = Path.Combine(wwwRootPath + "/img/" + E.ImagenUrl);

                    using (var fileStream = new FileStream(path, FileMode.Create))
                    {
                        await E.ImagenFile.CopyToAsync(fileStream);
                    }
                }
                _context.Add(E);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(E);
            }
        }


    }
}
