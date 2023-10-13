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
using ClassLibDb.ViewModels;

namespace MvcApp.Controllers
{

    public class ContactController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ContactController(ApplicationDbContext context)
        {
            _context = context;
        }


        // GET: Contact
        [Authorize(Roles = "Admin, Finance")]
        public async Task<IActionResult> Index()
        {
            return _context.Contacts != null ?
                        View(await _context.Contacts.ToListAsync()) :
                        Problem("Entity set 'ApplicationDbContext.Contacts'  is null.");
        }


        // GET: Contact/Details/5
        [Authorize(Roles = "Admin, Finance")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Contacts == null)
            {
                return NotFound();
            }

            var contact = await _context.Contacts
                .FirstOrDefaultAsync(m => m.AccountNo == id);
            if (contact == null)
            {
                return NotFound();
            }

            return View(contact);
        }


        // GET: Contact/Create
        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Contact/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FirstName,LastName,Email,Street,City,PostalCode,Country")] Contact contact)
        {
            if (ModelState.IsValid)
            {
                var dateTimeUtc = DateTime.UtcNow;
                contact.Created = dateTimeUtc;
                contact.Modified = dateTimeUtc;
                contact.CreatedBy = User.Identity!.Name;
                contact.ModifiedBy = User.Identity!.Name;
                _context.Add(contact);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(contact);
        }

        // GET: Contact/Edit/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Contacts == null)
            {
                return NotFound();
            }

            var contact = await _context.Contacts.FindAsync(id);
            if (contact == null)
            {
                return NotFound();
            }

            return View(contact);
        }

        // POST: Contact/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AccountNo,FirstName,LastName,Email,Street,City,PostalCode,Country")] Contact contact)
        {
            if (id != contact.AccountNo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var prevContact = _context.Contacts
                        .Where(c => c.AccountNo == id)
                        .Select(c => new { c.Created, c.CreatedBy, c.ModifiedBy })
                        .FirstOrDefault();

                    contact.Created = prevContact!.Created;
                    contact.CreatedBy = prevContact.CreatedBy;
                    contact.Modified = DateTime.UtcNow;
                    contact.ModifiedBy = User.Identity!.Name;
                    _context.Update(contact);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContactExists(contact.AccountNo))
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
            return View(contact);
        }

        // GET: Contact/Delete/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Contacts == null)
            {
                return NotFound();
            }

            var contact = await _context.Contacts
                .FirstOrDefaultAsync(m => m.AccountNo == id);
            if (contact == null)
            {
                return NotFound();
            }

            return View(contact);
        }

        // POST: Contact/Delete/5
        [Authorize(Roles = "Admin")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Contacts == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Contacts'  is null.");
            }
            var contact = await _context.Contacts.FindAsync(id);
            if (contact != null)
            {
                _context.Contacts.Remove(contact);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // GET: Contact/Receipt/5
        [Authorize(Roles = "Admin, Finance")]
        public async Task<IActionResult> Receipt(int? id)
        {
            if (id == null || _context.Contacts == null)
            {
                return NotFound();
            }

            var contact = await _context.Contacts.FindAsync(id);

            if (contact == null)
            {
                return NotFound();
            }

            var startDate = new DateTime(DateTime.UtcNow.Year, 1, 1);
            var endDate = new DateTime(DateTime.UtcNow.Year, 12, 31);
            var donations = await _context.Donations.Include(d => d.PaymentMethod)
                .Where(d => d.Date >= startDate && d.Date <= endDate && (d.AccountNo == id)).ToListAsync();

            if (donations == null)
            {
                return NotFound();
            }

            var dateTimeUtc = DateTime.UtcNow;
            var receipt = new Receipt
            {
                Contact = contact,
                Donations = donations,
                DateIssued = dateTimeUtc.ToShortDateString(),
                Year = dateTimeUtc.Year.ToString(),
                Total = donations.Sum(d => d.Amount)
            };

            return View(receipt);
        }

        private bool ContactExists(int id)
        {
            return (_context.Contacts?.Any(e => e.AccountNo == id)).GetValueOrDefault();
        }
    }
}
