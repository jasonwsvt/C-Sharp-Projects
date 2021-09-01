using NewsletterAppMVC.Models;
using NewsletterAppMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsletterAppMVC.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
			using (var db = new NewsletterEntities())
			{
				//var signups = db.SignUps.Where(x => x.Removed == null).ToList();
				var signups = (from c in db.SignUps where c.Removed == null select c).ToList();
				var signupVMs = new List<SignupVM>();
				foreach (var signup in signups)
				{
					var signupVM = new SignupVM
					{
						Id = signup.id,
						FirstName = signup.FirstName,
						LastName = signup.LastName,
						EmailAddress = signup.EmailAddress
					};
					signupVMs.Add(signupVM);
				}

				return View(signupVMs);
			}
		}

		public ActionResult Unsubscribe(int id)
		{
			using (NewsletterEntities db = new NewsletterEntities())
			{
				var signup = db.SignUps.Find(id);
				signup.Removed = DateTime.Now;
				db.SaveChanges();
			}
			return RedirectToAction("Index");
		}
    }
}