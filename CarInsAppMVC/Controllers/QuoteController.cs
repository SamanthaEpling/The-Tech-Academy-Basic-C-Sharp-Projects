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
        public ActionResult Index()
        {
            ViewBag.Message = "Fill out the form for a car insurance quote.";
            return View();
        }
        [HttpPost]
        public ActionResult GetQuote(int Id, string firstName, string lastName, string emailAddress, string dateOfBirth, string carYear,
                                        string carMake, string carModel, string insType, string presentDUI, string numberSpeedingTickets, string removeable )
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress) ||
                string.IsNullOrEmpty(dateOfBirth) || string.IsNullOrEmpty(carYear) || string.IsNullOrEmpty(carMake) || string.IsNullOrEmpty(carModel) ||
                string.IsNullOrEmpty(insType) || string.IsNullOrEmpty(presentDUI) || string.IsNullOrEmpty(numberSpeedingTickets))
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
                string connectionString = @"Data Source=DESKTOP-4BDND9O\SQLEXPRESS;Initial Catalog=CarInsApp;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

                string queryString = @"INSERT INTO Quotes (Id, FirstName, LastName, EmailAddress, DateOfBirth, CarYear, CarMake, CarModel, InsType, PresentDUI, NumberSpeedingTickets) 
                                        VALUES (@Id, @FirstName, @LastName, @EmailAddress, @DateOfBirth, @CarYear, @CarMake, @CarModel, @InsType, @PresentDUI, @NumberSpeedingTickets)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Parameters.Add("@Id", SqlDbType.Int);
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

                    command.Parameters["@Id"].Value = Id;
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


                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                return View("Success");            
            }

        }

        public ActionResult Success()
        {
            ViewBag.Message = "Your quote has been successfully submitted, we will contact you shortly!";
            return View();
        }

    }

}