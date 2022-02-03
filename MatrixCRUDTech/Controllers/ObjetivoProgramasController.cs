using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MatrixCRUDTech.Models;

namespace MatrixCRUDTech.Controllers
{
    public class ObjetivoProgramasController : Controller
    {
        private readonly Contexto _context;

        public ObjetivoProgramasController(Contexto context)
        {
            _context = context;
        }

        // GET: ObjetivoProgramas
        public async Task<IActionResult> Index()
        {
            var contexto = _context.ObjetivoProgramas.Include(o => o.Programa);
            return View(await contexto.ToListAsync());
        }

        // GET: ObjetivoProgramas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var objetivoPrograma = await _context.ObjetivoProgramas
                .Include(o => o.Programa)
                .FirstOrDefaultAsync(m => m.IdObjetivo == id);
            if (objetivoPrograma == null)
            {
                return NotFound();
            }

            return View(objetivoPrograma);
        }

        // GET: ObjetivoProgramas/Create
        public IActionResult Create()
        {
            ViewData["ProgramaId"] = new SelectList(_context.Programa, "Codigo", "Codigo");
            return View();
        }

        // POST: ObjetivoProgramas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdObjetivo,Descricao,ProgramaId")] ObjetivoPrograma objetivoPrograma)
        {
            if (ModelState.IsValid)
            {
                _context.Add(objetivoPrograma);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProgramaId"] = new SelectList(_context.Programa, "Codigo", "Codigo", objetivoPrograma.ProgramaId);
            return View(objetivoPrograma);
        }

        // GET: ObjetivoProgramas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var objetivoPrograma = await _context.ObjetivoProgramas.FindAsync(id);
            if (objetivoPrograma == null)
            {
                return NotFound();
            }
            ViewData["ProgramaId"] = new SelectList(_context.Programa, "Codigo", "Codigo", objetivoPrograma.ProgramaId);
            return View(objetivoPrograma);
        }

        // POST: ObjetivoProgramas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdObjetivo,Descricao,ProgramaId")] ObjetivoPrograma objetivoPrograma)
        {
            if (id != objetivoPrograma.IdObjetivo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(objetivoPrograma);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ObjetivoProgramaExists(objetivoPrograma.IdObjetivo))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProgramaId"] = new SelectList(_context.Programa, "Codigo", "Codigo", objetivoPrograma.ProgramaId);
            return View(objetivoPrograma);
        }

        // GET: ObjetivoProgramas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var objetivoPrograma = await _context.ObjetivoProgramas
                .Include(o => o.Programa)
                .FirstOrDefaultAsync(m => m.IdObjetivo == id);
            if (objetivoPrograma == null)
            {
                return NotFound();
            }

            return View(objetivoPrograma);
        }

        // POST: ObjetivoProgramas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var objetivoPrograma = await _context.ObjetivoProgramas.FindAsync(id);
            _context.ObjetivoProgramas.Remove(objetivoPrograma);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ObjetivoProgramaExists(int id)
        {
            return _context.ObjetivoProgramas.Any(e => e.IdObjetivo == id);
        }
    }
}
