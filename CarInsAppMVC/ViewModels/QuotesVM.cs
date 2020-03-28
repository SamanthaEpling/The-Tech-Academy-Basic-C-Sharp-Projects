using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarInsAppMVC.ViewModels
{
    public class QuotesVM
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public decimal DerivedQuote { get; set; }
    }
}