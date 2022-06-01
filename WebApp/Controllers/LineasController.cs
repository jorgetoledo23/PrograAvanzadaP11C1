using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class LineasController : Controller
    {
        private readonly AppDbContext _context;

        public LineasController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index() // Views - Marcas - Index
        {
            var Lineas = _context.tblLineas.ToList();
            return View(Lineas);
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(Linea L)
        {
            if (L == null) return View();

            if (ModelState.IsValid)
            {
                _context.Add(L);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(L);
        }

        [HttpGet]
        public IActionResult Edit(int IdLinea)
        {
            var Linea = _context.tblLineas.FirstOrDefault(m => m.Id == IdLinea);
            if (Linea == null) return NotFound();
            else
            {
                return View(Linea);
            }
        }


        [HttpPost]
        public async Task<IActionResult> Edit(Linea Linea)
        {
            if (ModelState.IsValid)
            {
                _context.Update(Linea);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(Linea);
        }


        [HttpGet]
        public IActionResult Delete(int IdLinea)
        {
            var Linea = _context.tblLineas.FirstOrDefault(m => m.Id == IdLinea);
            if (Linea == null) return NotFound();
            else
            {
                return View(Linea);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Linea Linea)
        {
            _context.Remove(Linea);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }



    }
}

