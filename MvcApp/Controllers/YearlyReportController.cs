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

public IActionResult YearlyReport(){

    var yearlyDonations = _context.Donations
        .GroupBy(d => d.Date.Year)
        .Select(group => new Report
        {
            Title = $"Yearly Report - {group.Key}",
            TotalAmount = (decimal)group.Sum(d => d.Amount),
            Year = group.Key
        })
        .OrderByDescending(r => r.Year)
        .ToList();

    return View(yearlyDonations);

}



        
public IActionResult YearToDateReport()
{
    // Group donations by year and calculate total amount for each year
    // var yearlyDonations = _context.Donations
    //     .Where(d => d.Date.Year == DateTime.UtcNow.Year)
    //     .GroupBy(d => d.Date.Year)
    //     .Select(group => new Report
    //     {
    //         Title = $"Yearly Report - {group.Key}",
    //         TotalAmount = (decimal)group.Sum(d => d.Amount),
    //         Year = group.Key
    //     })
    //     .OrderByDescending(r => r.Year)
    //     .ToList();

    // Year-To-Date Donation Report (from January 1 to now)
    var yearToDateDonations = _context.Donations
        .Include(d => d.Contact)
        .Where(d => d.Date.Year == DateTime.UtcNow.Year && d.Date <= DateTime.UtcNow)
        .GroupBy(d => d.Contact.AccountNo)
        .Select(group => new Report
        {
            Title = $"Year-To-Date Report - {DateTime.UtcNow.Year}",
            TotalAmount = (decimal)group.Sum(d => d.Amount),
            Donations = group.ToList(),
            ContactFullName = group.First().Contact.FullName,
            DonationDate = group.First().Date
        })
        .ToList();

    // var combinedReports = yearlyDonations.Concat(yearToDateDonations).ToList();

    return View(yearToDateDonations);
}
}




    }
