using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NathBucks.Models;

namespace NathBucks.Controllers
{
    public class CardapiosController : Controller
    {
        private readonly AppDbContext _context;

        public CardapiosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Cardapios
        public async Task<IActionResult> Index()
        {
              return _context.Cardapio != null ? 
                          View(await _context.Cardapio.ToListAsync()) :
                          Problem("Entity set 'AppDbContext.Cardapio'  is null.");
        }

        // GET: Cardapios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Cardapio == null)
            {
                return NotFound();
            }

            var cardapio = await _context.Cardapio
                .FirstOrDefaultAsync(m => m.IdCardapio == id);
            if (cardapio == null)
            {
                return NotFound();
            }

            return View(cardapio);
        }

        // GET: Cardapios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Cardapios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdCardapio,TipoDrink,TamanhoDrink,DescricaoDrink,PrecoDrink")] Cardapio cardapio)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cardapio);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cardapio);
        }

        // GET: Cardapios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Cardapio == null)
            {
                return NotFound();
            }

            var cardapio = await _context.Cardapio.FindAsync(id);
            if (cardapio == null)
            {
                return NotFound();
            }
            return View(cardapio);
        }

        // POST: Cardapios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdCardapio,TipoDrink,TamanhoDrink,DescricaoDrink,PrecoDrink")] Cardapio cardapio)
        {
            if (id != cardapio.IdCardapio)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cardapio);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CardapioExists(cardapio.IdCardapio))
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
            return View(cardapio);
        }

        // GET: Cardapios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Cardapio == null)
            {
                return NotFound();
            }

            var cardapio = await _context.Cardapio
                .FirstOrDefaultAsync(m => m.IdCardapio == id);
            if (cardapio == null)
            {
                return NotFound();
            }

            return View(cardapio);
        }

        // POST: Cardapios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Cardapio == null)
            {
                return Problem("Entity set 'AppDbContext.Cardapio'  is null.");
            }
            var cardapio = await _context.Cardapio.FindAsync(id);
            if (cardapio != null)
            {
                _context.Cardapio.Remove(cardapio);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CardapioExists(int id)
        {
          return (_context.Cardapio?.Any(e => e.IdCardapio == id)).GetValueOrDefault();
        }
    }
}
