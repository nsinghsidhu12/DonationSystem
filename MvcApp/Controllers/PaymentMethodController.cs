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
    public class PaymentMethodController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PaymentMethodController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: PaymentMethod
        [Authorize(Roles = "Admin, Finance")]
        public async Task<IActionResult> Index()
        {
              return _context.PaymentMethods != null ? 
                          View(await _context.PaymentMethods.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.PaymentMethods'  is null.");
        }

        // GET: PaymentMethod/Details/5
        [Authorize(Roles = "Admin, Finance")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.PaymentMethods == null)
            {
                return NotFound();
            }

            var paymentMethod = await _context.PaymentMethods
                .FirstOrDefaultAsync(m => m.PaymentMethodId == id);
            if (paymentMethod == null)
            {
                return NotFound();
            }

            return View(paymentMethod);
        }

        // GET: PaymentMethod/Create
        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: PaymentMethod/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name")] PaymentMethod paymentMethod)
        {
            if (ModelState.IsValid)
            {
                var dateTimeUtc = DateTime.UtcNow;
                paymentMethod.Created = dateTimeUtc;
                paymentMethod.Modified = dateTimeUtc;
                paymentMethod.CreatedBy = User.Identity!.Name;
                paymentMethod.ModifiedBy = User.Identity!.Name;
                _context.Add(paymentMethod);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(paymentMethod);
        }

        // GET: PaymentMethod/Edit/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.PaymentMethods == null)
            {
                return NotFound();
            }

            var paymentMethod = await _context.PaymentMethods.FindAsync(id);
            if (paymentMethod == null)
            {
                return NotFound();
            }
            return View(paymentMethod);
        }

        // POST: PaymentMethod/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PaymentMethodId,Name")] PaymentMethod paymentMethod)
        {
            if (id != paymentMethod.PaymentMethodId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var prevPaymentMethod = _context.PaymentMethods
                        .Where(p => p.PaymentMethodId == id)
                        .Select(p => new { p.Created, p.CreatedBy, p.ModifiedBy })
                        .FirstOrDefault();

                    paymentMethod.Created = prevPaymentMethod!.Created;
                    paymentMethod.CreatedBy = prevPaymentMethod.CreatedBy;
                    paymentMethod.Modified = DateTime.UtcNow;
                    paymentMethod.ModifiedBy = User.Identity!.Name;
                    _context.Update(paymentMethod);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PaymentMethodExists(paymentMethod.PaymentMethodId))
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
            return View(paymentMethod);
        }

        // GET: PaymentMethod/Delete/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.PaymentMethods == null)
            {
                return NotFound();
            }

            var paymentMethod = await _context.PaymentMethods
                .FirstOrDefaultAsync(m => m.PaymentMethodId == id);
            if (paymentMethod == null)
            {
                return NotFound();
            }

            return View(paymentMethod);
        }

        // POST: PaymentMethod/Delete/5
        [Authorize(Roles = "Admin")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.PaymentMethods == null)
            {
                return Problem("Entity set 'ApplicationDbContext.PaymentMethods'  is null.");
            }
            var paymentMethod = await _context.PaymentMethods.FindAsync(id);
            if (paymentMethod != null)
            {
                _context.PaymentMethods.Remove(paymentMethod);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PaymentMethodExists(int id)
        {
          return (_context.PaymentMethods?.Any(e => e.PaymentMethodId == id)).GetValueOrDefault();
        }
    }
}
