using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LarreaPaul_ExamenP1.Data;
using LarreaPaul_ExamenP1.Models;

namespace LarreaPaul_ExamenP1.Controllers
{
    public class PLarreasController : Controller
    {
        private readonly LarreaPaul_ExamenP1Context _context;

        public PLarreasController(LarreaPaul_ExamenP1Context context)
        {
            _context = context;
        }

        // GET: PLarreas
        public async Task<IActionResult> Index()
        {
            return View(await _context.PLarrea.ToListAsync());
        }

        // GET: PLarreas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pLarrea = await _context.PLarrea
                .FirstOrDefaultAsync(m => m.idNombre == id);
            if (pLarrea == null)
            {
                return NotFound();
            }

            return View(pLarrea);
        }

        // GET: PLarreas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PLarreas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idNombre,correo,celular,iq,casado,FechaCumple")] PLarrea pLarrea)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pLarrea);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pLarrea);
        }

        // GET: PLarreas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pLarrea = await _context.PLarrea.FindAsync(id);
            if (pLarrea == null)
            {
                return NotFound();
            }
            return View(pLarrea);
        }

        // POST: PLarreas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("idNombre,correo,celular,iq,casado,FechaCumple")] PLarrea pLarrea)
        {
            if (id != pLarrea.idNombre)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pLarrea);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PLarreaExists(pLarrea.idNombre))
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
            return View(pLarrea);
        }

        // GET: PLarreas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pLarrea = await _context.PLarrea
                .FirstOrDefaultAsync(m => m.idNombre == id);
            if (pLarrea == null)
            {
                return NotFound();
            }

            return View(pLarrea);
        }

        // POST: PLarreas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pLarrea = await _context.PLarrea.FindAsync(id);
            if (pLarrea != null)
            {
                _context.PLarrea.Remove(pLarrea);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PLarreaExists(int id)
        {
            return _context.PLarrea.Any(e => e.idNombre == id);
        }
    }
}
