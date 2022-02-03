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
    public class IndicadorProgramasController : Controller
    {
        private readonly Contexto _context;

        public IndicadorProgramasController(Contexto context)
        {
            _context = context;
        }

        // GET: IndicadorProgramas
        public async Task<IActionResult> Index()
        {
            var contexto = _context.IndicadorProgramas.Include(i => i.ObjPrograma);
            return View(await contexto.ToListAsync());
        }

        // GET: IndicadorProgramas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var indicadorPrograma = await _context.IndicadorProgramas
                .Include(i => i.ObjPrograma)
                .FirstOrDefaultAsync(m => m.IdIndicador == id);
            if (indicadorPrograma == null)
            {
                return NotFound();
            }

            return View(indicadorPrograma);
        }

        // GET: IndicadorProgramas/Create
        public IActionResult Create()
        {
            ViewData["ProgramaID"] = new SelectList(_context.Programa, "Codigo", "Codigo");
            return View();
        }

        // POST: IndicadorProgramas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdIndicador,Descricao,ProgramaID,UndMedida,IndiceApuracao,IndiceDesejado,Data")] IndicadorPrograma indicadorPrograma)
        {
            if (ModelState.IsValid)
            {
                _context.Add(indicadorPrograma);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProgramaID"] = new SelectList(_context.Programa, "Codigo", "Codigo", indicadorPrograma.ProgramaID);
            return View(indicadorPrograma);
        }

        // GET: IndicadorProgramas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var indicadorPrograma = await _context.IndicadorProgramas.FindAsync(id);
            if (indicadorPrograma == null)
            {
                return NotFound();
            }
            ViewData["ProgramaID"] = new SelectList(_context.Programa, "Codigo", "Codigo", indicadorPrograma.ProgramaID);
            return View(indicadorPrograma);
        }

        // POST: IndicadorProgramas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdIndicador,Descricao,ProgramaID,UndMedida,IndiceApuracao,IndiceDesejado,Data")] IndicadorPrograma indicadorPrograma)
        {
            if (id != indicadorPrograma.IdIndicador)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(indicadorPrograma);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!IndicadorProgramaExists(indicadorPrograma.IdIndicador))
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
            ViewData["ProgramaID"] = new SelectList(_context.Programa, "Codigo", "Codigo", indicadorPrograma.ProgramaID);
            return View(indicadorPrograma);
        }

        // GET: IndicadorProgramas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var indicadorPrograma = await _context.IndicadorProgramas
                .Include(i => i.ObjPrograma)
                .FirstOrDefaultAsync(m => m.IdIndicador == id);
            if (indicadorPrograma == null)
            {
                return NotFound();
            }

            return View(indicadorPrograma);
        }

        // POST: IndicadorProgramas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var indicadorPrograma = await _context.IndicadorProgramas.FindAsync(id);
            _context.IndicadorProgramas.Remove(indicadorPrograma);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool IndicadorProgramaExists(int id)
        {
            return _context.IndicadorProgramas.Any(e => e.IdIndicador == id);
        }
    }
}
