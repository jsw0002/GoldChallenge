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
    public class NetWorthCalculatorsController : Controller
    {
        private FranchiseContext db = new FranchiseContext();

        // GET: NetWorthCalculators
        public ActionResult Index()
        {
            return View(db.NetWorthCalculators.ToList());
        }

        // GET: NetWorthCalculators/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NetWorthCalculator netWorthCalculator = db.NetWorthCalculators.Find(id);
            if (netWorthCalculator == null)
            {
                return HttpNotFound();
            }
            return View(netWorthCalculator);
        }

        // GET: NetWorthCalculators/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NetWorthCalculators/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CustomerID,CashInCheckingAndSavings,StocksBondsMutualFunds,Ira401kOtherRetirementPlans,RealEstateHome,RealEstateOther,BusinessValue,AppraisedCollectibles,MoneyOwedToYou,OtherAssets,MortgageHome,MortgageOther,ChargeAccountsCreditCards,AutomobileLoans,OtherLiabilities,TotalAssets,TotalLiabilities,TaMinusTl")] NetWorthCalculator netWorthCalculator)
        {
            if (ModelState.IsValid)
            {
                db.NetWorthCalculators.Add(netWorthCalculator);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(netWorthCalculator);
        }

        // GET: NetWorthCalculators/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NetWorthCalculator netWorthCalculator = db.NetWorthCalculators.Find(id);
            if (netWorthCalculator == null)
            {
                return HttpNotFound();
            }
            return View(netWorthCalculator);
        }

        // POST: NetWorthCalculators/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CustomerID,CashInCheckingAndSavings,StocksBondsMutualFunds,Ira401kOtherRetirementPlans,RealEstateHome,RealEstateOther,BusinessValue,AppraisedCollectibles,MoneyOwedToYou,OtherAssets,MortgageHome,MortgageOther,ChargeAccountsCreditCards,AutomobileLoans,OtherLiabilities,TotalAssets,TotalLiabilities,TaMinusTl")] NetWorthCalculator netWorthCalculator)
        {
            if (ModelState.IsValid)
            {
                db.Entry(netWorthCalculator).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(netWorthCalculator);
        }

        // GET: NetWorthCalculators/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NetWorthCalculator netWorthCalculator = db.NetWorthCalculators.Find(id);
            if (netWorthCalculator == null)
            {
                return HttpNotFound();
            }
            return View(netWorthCalculator);
        }

        // POST: NetWorthCalculators/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NetWorthCalculator netWorthCalculator = db.NetWorthCalculators.Find(id);
            db.NetWorthCalculators.Remove(netWorthCalculator);
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
