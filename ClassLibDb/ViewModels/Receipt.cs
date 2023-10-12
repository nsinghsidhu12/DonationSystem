using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ClassLibDb.Models;

namespace ClassLibDb.ViewModels
{
    public class Receipt
    {
        public Contact? Contact { get; set; }
        public List<Donation>? Donations { get; set; }

        public string? DateIssued { get; set; }
        public string? Year { get; set; }
        
        [DataType(DataType.Currency)]
        public double? Total { get; set; }
    }
}