using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GoldChallenge.DAL;
using GoldChallenge.Models;

namespace GoldChallenge.Controllers
{
    public class CustomerBackgroundsController : Controller
    {
        private FranchiseContext db = new FranchiseContext();

        // GET: CustomerBackgrounds
        public ActionResult Index()
        {
            return View(db.CustomerBackgrounds.ToList());
        }

        // GET: CustomerBackgrounds/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CustomerBackground customerBackground = db.CustomerBackgrounds.Find(id);
            if (customerBackground == null)
            {
                return HttpNotFound();
            }
            return View(customerBackground);
        }

        // GET: CustomerBackgrounds/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomerBackgrounds/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CustomerID,AreThereAnyOtherDecisionMakers,IsMarried,SpouseName,CurrentOccupation,ProfessionalBackground1,ProfessionalBackground2,ProfessionalBackground3,ProfessionalBackground4,ProfessionalBackground5,AreYouAVet,HaveYouOwnedABusinessBefore,CreditScore,CashInvestment,InvestmentSource,NetWorth,DesiredMarket,WhyAreYouLookingAtBusinesses,LengthOfTimeLooking,SpokenWithAnyoneElse")] CustomerBackground customerBackground)
        {
            if (ModelState.IsValid)
            {
                db.CustomerBackgrounds.Add(customerBackground);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(customerBackground);
        }

        // GET: CustomerBackgrounds/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CustomerBackground customerBackground = db.CustomerBackgrounds.Find(id);
            if (customerBackground == null)
            {
                return HttpNotFound();
            }
            return View(customerBackground);
        }

        // POST: CustomerBackgrounds/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CustomerID,AreThereAnyOtherDecisionMakers,IsMarried,SpouseName,CurrentOccupation,ProfessionalBackground1,ProfessionalBackground2,ProfessionalBackground3,ProfessionalBackground4,ProfessionalBackground5,AreYouAVet,HaveYouOwnedABusinessBefore,CreditScore,CashInvestment,InvestmentSource,NetWorth,DesiredMarket,WhyAreYouLookingAtBusinesses,LengthOfTimeLooking,SpokenWithAnyoneElse")] CustomerBackground customerBackground)
        {
            if (ModelState.IsValid)
            {
                db.Entry(customerBackground).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(customerBackground);
        }

        // GET: CustomerBackgrounds/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CustomerBackground customerBackground = db.CustomerBackgrounds.Find(id);
            if (customerBackground == null)
            {
                return HttpNotFound();
            }
            return View(customerBackground);
        }

        // POST: CustomerBackgrounds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CustomerBackground customerBackground = db.CustomerBackgrounds.Find(id);
            db.CustomerBackgrounds.Remove(customerBackground);
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
