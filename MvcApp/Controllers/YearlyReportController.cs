using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using ClassLibDb.Data;
using ClassLibDb.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace MvcApp.Controllers
{
    public class ReportController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ReportController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            // Fetch data from your data source and pass it to the view
            var donations = _context.Donations.Include(d => d.Contact)
                                              .Include(d => d.TransactionType)
                                              .Include(d => d.PaymentMethod)
                                              .ToList();

            return View(donations);
        }



        public IActionResult YearlyReport()
        {
            var yearlyDonations = _context.Donations
                .Include(d => d.Contact)
                .Where(d => d.Date.Year == DateTime.UtcNow.Year)
                .GroupBy(d => new { d.Date.Year, d.Contact.AccountNo })
                .Select(group => new Report
                {
                    Title = $"Yearly Report - {group.Key.Year}",
                    TotalAmount = (decimal)group.Sum(d => d.Amount),
                    Donations = group.ToList(),
                    ContactFullName = group.First().Contact.FullName
                })
                .ToList();

            return View("YearlyReportView", yearlyDonations);
        }
    }
}