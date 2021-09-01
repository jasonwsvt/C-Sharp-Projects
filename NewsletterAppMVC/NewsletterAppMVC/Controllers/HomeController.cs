using NewsletterAppMVC.Models;
using NewsletterAppMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsletterAppMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignUp(string firstName, string lastName, string emailAddress)
		{
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress))
			{
                return View("~/Views/Shared/Error.cshtml");
			}
            else
			{
				using (var db = new NewsletterEntities())
				{
					var signup = new SignUp
					{
						FirstName = firstName,
						LastName = lastName,
						EmailAddress = emailAddress
					};

					db.SignUps.Add(signup);
					db.SaveChanges();
				}
				return View("Success");
			}
		}
    }
}