
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarInsAppMVC.Controllers
{
    public class QuoteController : Controller
    {
        // GET: Quote
        private readonly string connectionString = @"Data Source=DESKTOP-4BDND9O\SQLEXPRESS;Initial Catalog=CarInsApp;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";public ActionResult Index()
        {
            ViewBag.Message = "Fill out the form for a car insurance quote.";
            return View();
        }
        [HttpPost]
        public ActionResult GetQuote(string firstName, string lastName, string emailAddress, string dateOfBirth, string carYear,
                                        string carMake, string carModel, string insType, string presentDUI, string numberSpeedingTickets, string removeable, int Id = 7)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress) ||
                string.IsNullOrEmpty(dateOfBirth) || string.IsNullOrEmpty(carYear) || string.IsNullOrEmpty(carMake) || string.IsNullOrEmpty(carModel) ||
                string.IsNullOrEmpty(insType) || string.IsNullOrEmpty(presentDUI) || string.IsNullOrEmpty(numberSpeedingTickets))
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
                decimal derivedQuote = 50.00M;
                int yearOfBirth = Convert.ToInt32(dateOfBirth);
                int currentAge = DateTime.Now.Year - yearOfBirth;
                if ( currentAge <18 )
                {
                    derivedQuote = derivedQuote + 100.00M;
                }
                else if (currentAge <25 || currentAge > 100)
                {
                    derivedQuote = derivedQuote + 25.00M;
                }

                int convertedCarYear = Convert.ToInt32(carYear);
                if (convertedCarYear <2000 || convertedCarYear >2015)
                {
                    derivedQuote = derivedQuote + 25.00M;
                }

                if (carMake.ToLower() == "porsche" && carModel.ToLower() == "911 carrera")
                {
                    derivedQuote = derivedQuote + 25.00M;
                } 
                if (Convert.ToInt32(numberSpeedingTickets) > 0)
                {
                    derivedQuote = derivedQuote + Convert.ToInt32(numberSpeedingTickets) * 10;
                }
                if (presentDUI == "true")
                {
                    derivedQuote = derivedQuote + (derivedQuote / 4.00M);
                }
                if (insType.ToLower() == "full")
                {
                    derivedQuote = derivedQuote + (derivedQuote / 2.00M);
                }


                string queryString = @"INSERT INTO Quotes (FirstName, LastName, EmailAddress, DateOfBirth, CarYear, CarMake, CarModel, InsType, PresentDUI, NumberSpeedingTickets, DerivedQuote) 
                                        VALUES (@FirstName, @LastName, @EmailAddress, @DateOfBirth, @CarYear, @CarMake, @CarModel, @InsType, @PresentDUI, @NumberSpeedingTickets, @DerivedQuote)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Parameters.Add("@FirstName", SqlDbType.VarChar);
                    command.Parameters.Add("@LastName", SqlDbType.VarChar);
                    command.Parameters.Add("@EmailAddress", SqlDbType.VarChar);
                    command.Parameters.Add("@DateOfBirth", SqlDbType.VarChar);
                    command.Parameters.Add("@CarYear", SqlDbType.VarChar);
                    command.Parameters.Add("@CarMake", SqlDbType.VarChar);
                    command.Parameters.Add("@CarModel", SqlDbType.VarChar);
                    command.Parameters.Add("@InsType", SqlDbType.VarChar);
                    command.Parameters.Add("@PresentDUI", SqlDbType.VarChar);
                    command.Parameters.Add("@NumberSpeedingTickets", SqlDbType.VarChar);
                    command.Parameters.Add("@DerivedQuote", SqlDbType.Decimal);

                    command.Parameters["@FirstName"].Value = firstName;
                    command.Parameters["@LastName"].Value = lastName;
                    command.Parameters["@EmailAddress"].Value = emailAddress;
                    command.Parameters["@DateOfBirth"].Value = dateOfBirth;
                    command.Parameters["@CarYear"].Value = carYear;
                    command.Parameters["@CarMake"].Value = carMake;
                    command.Parameters["@CarModel"].Value = carModel;
                    command.Parameters["@InsType"].Value = insType;
                    command.Parameters["@PresentDUI"].Value = presentDUI;
                    command.Parameters["@NumberSpeedingTickets"].Value = numberSpeedingTickets;
                    command.Parameters["@DerivedQuote"].Value = derivedQuote;


                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                ViewBag.Message = "Your quote has been successfully submitted, we will contact you shortly!";
                return View("Success");            
            }

        }

        public ActionResult Success()
        {
            return View();
        }
        public ActionResult Admin()
        {
            string queryString = @"SELECT Id, FirstName, LastName, EmailAddress, DerivedQuote from Quotes";
            List<Models.Quote> quotes = new List<Models.Quote>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var quote = new Models.Quote();
                    quote.FirstName = reader["FirstName"].ToString();
                    quote.LastName = reader["LastName"].ToString();
                    quote.EmailAddress = reader["EmailAddress"].ToString();
                    quote.DerivedQuote = Convert.ToDecimal(reader["DerivedQuote"]);
                    quotes.Add(quote);
                }
            }
            return View(quotes);
        }
    }

}