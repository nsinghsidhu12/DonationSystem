using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ClassLibDb.Data;
using ClassLibDb.Models;
using Microsoft.AspNetCore.Authorization;

namespace MvcApp.Controllers
{
    public class TransactionTypeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TransactionTypeController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: TransactionType
        [Authorize(Roles = "Admin, Finance")]
        public async Task<IActionResult> Index()
        {
            return _context.TransactionTypes != null ?
                        View(await _context.TransactionTypes.ToListAsync()) :
                        Problem("Entity set 'ApplicationDbContext.TransactionTypes'  is null.");
        }

        // GET: TransactionType/Details/5
        [Authorize(Roles = "Admin, Finance")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.TransactionTypes == null)
            {
                return NotFound();
            }

            var transactionType = await _context.TransactionTypes
                .FirstOrDefaultAsync(m => m.TransactionTypeId == id);
            if (transactionType == null)
            {
                return NotFound();
            }

            return View(transactionType);
        }

        // GET: TransactionType/Create
        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: TransactionType/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Create([Bind("Name,Description")] TransactionType transactionType)
        {
            if (ModelState.IsValid)
            {
                var dateTimeUtc = DateTime.UtcNow;
                transactionType.Created = dateTimeUtc;
                transactionType.Modified = dateTimeUtc;
                transactionType.CreatedBy = User.Identity!.Name;
                transactionType.ModifiedBy = User.Identity!.Name;
                _context.Add(transactionType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(transactionType);
        }

        // GET: TransactionType/Edit/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.TransactionTypes == null)
            {
                return NotFound();
            }

            var transactionType = await _context.TransactionTypes.FindAsync(id);
            if (transactionType == null)
            {
                return NotFound();
            }
            
            return View(transactionType);
        }

        // POST: TransactionType/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TransactionTypeId,Name,Description")] TransactionType transactionType)
        {
            if (id != transactionType.TransactionTypeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var prevTransactionType = _context.TransactionTypes
                        .Where(t => t.TransactionTypeId == id)
                        .Select(t => new { t.Created, t.CreatedBy, t.ModifiedBy })
                        .FirstOrDefault();

                    transactionType.Created = prevTransactionType!.Created;
                    transactionType.CreatedBy = prevTransactionType.CreatedBy;
                    transactionType.Modified = DateTime.UtcNow;
                    transactionType.ModifiedBy = User.Identity!.Name;
                    _context.Update(transactionType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TransactionTypeExists(transactionType.TransactionTypeId))
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
            return View(transactionType);
        }

        // GET: TransactionType/Delete/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.TransactionTypes == null)
            {
                return NotFound();
            }

            var transactionType = await _context.TransactionTypes
                .FirstOrDefaultAsync(m => m.TransactionTypeId == id);
            if (transactionType == null)
            {
                return NotFound();
            }

            return View(transactionType);
        }

        // POST: TransactionType/Delete/5
        [Authorize(Roles = "Admin")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.TransactionTypes == null)
            {
                return Problem("Entity set 'ApplicationDbContext.TransactionTypes'  is null.");
            }
            var transactionType = await _context.TransactionTypes.FindAsync(id);
            if (transactionType != null)
            {
                _context.TransactionTypes.Remove(transactionType);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TransactionTypeExists(int id)
        {
            return (_context.TransactionTypes?.Any(e => e.TransactionTypeId == id)).GetValueOrDefault();
        }
    }
}
