using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarInsAppMVC.Models
{
    public class Quote
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string DateOfBirth { get; set; }
        public string CarYear { get; set; }
        public string CarMake { get; set; }
        public string CarModel { get; set; }
        public string InsType { get; set; }
        public string PresentDUI { get; set; }
        public string NumberSpeedingTickets { get; set; }
        public decimal DerivedQuote { get; set; }
    }
}