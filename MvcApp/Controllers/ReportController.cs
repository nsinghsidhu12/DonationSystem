using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using ClassLibDb.Data; // Adjust the namespace based on your project structure
using ClassLibDb.Models;
using Microsoft.EntityFrameworkCore;

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


    public IActionResult YearToDateReport()
    {
        // Get year-to-date donations
		var yearToDateDonations = _context.Donations
			.Include(d => d.Contact)
			.Include(d => d.TransactionType)
			.Include(d => d.PaymentMethod)
        	.Where(d => d.Date.Year == DateTime.Now.Year && d.Date == DateTime.Now)
			.ToList();


        // Perform aggregation (e.g., sum of amounts)
        decimal yearToDateTotal = yearToDateDonations.Sum(d => (decimal)d.Amount);

        // Create a view model to hold the aggregated data
        var viewModel = new ReportViewModel
    {
        Title = $"Year-to-Date Report ({DateTime.Now.ToShortDateString()})",
        TotalAmount = yearToDateTotal,
        Donations = yearToDateDonations
    };


        return View("ReportView", viewModel);
    }

public IActionResult YearlyReport()
{
    // Group donations by year and company, and calculate total amount for each company
    var yearlyDonations = _context.Donations
        .Include(d => d.Contact)
        .Include(d => d.TransactionType)
        .Include(d => d.PaymentMethod)
        .Where(d => d.Date.Year == DateTime.Now.Year)
        .GroupBy(d => new { d.Date.Year, d.Contact.AccountNo })  // Change here
        .Select(group => new ReportViewModel
        {
            Title = $"Yearly Report - {group.Key.Year} (Company ID: {group.Key.AccountNo})",
            TotalAmount = (decimal)group.Sum(d => d.Amount),  // Explicit cast to decimal
            Donations = group.ToList()
        })
        .ToList();

    return View("YearlyReport", yearlyDonations);
}



}