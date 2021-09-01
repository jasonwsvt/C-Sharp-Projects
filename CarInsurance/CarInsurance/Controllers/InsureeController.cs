using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;
using Newtonsoft.Json.Linq;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private decimal CalculateQuote(Insuree insuree)
		{
            DateTime today = DateTime.Now;                          //Determine today's date.
            TimeSpan age = today.Subtract(insuree.DateOfBirth);     //Determine age by subtracting DateOfBirth from today.
            int years = (int)(age.TotalDays / 365.255);             //Determine years of age by dividing age in days by 365.255.
            
            decimal quote = 50;                                     //Start with a base of $50 / month.
            if (years <= 18) quote += 100;                          //If the user is 18 and under, add $100 to the monthly total.
            if (years >= 19 && years < 25) quote += 50;             //If the user is between 19 and 25, add $50 to the monthly total.
            if (years > 25) quote += 25;                            //If the user is over 25, add $25 to the monthly total.
            if (insuree.CarYear < 2000) quote += 25;                //If the car's year is before 2000, add $25 to the monthly total.
            if (insuree.CarYear > 2015) quote += 25;                //If the car's year is after 2015, add $25 to the monthly total.
            if (insuree.CarMake == "Porsche")                       //If the car's Make is a Porsche, 
            {
                quote += 25;                                        //add $25 to the price.
                if (insuree.CarModel == "911 Carrera") quote += 25; //If its model is a 911 Carrera, add an additional $25 to the price.
            }
            quote += 10 * insuree.SpeedingTickets;                  //Add $10 to the monthly total for every speeding ticket the user has.
            if (insuree.DUI) quote *= 1.25m;                        //If the user has ever had a DUI, add 25% to the total.
            if (insuree.CoverageType) quote *= 1.5m;                //If it's full coverage, add 50% to the total.

            return Math.Floor(quote * 100) / 100;                   //Remove any fraction of a cent.
        }

        private readonly InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                insuree.Quote = CalculateQuote(insuree);
                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                insuree.Quote = CalculateQuote(insuree);
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
