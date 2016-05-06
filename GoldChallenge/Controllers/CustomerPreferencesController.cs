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
    public class CustomerPreferencesController : Controller
    {
        private FranchiseContext db = new FranchiseContext();

        // GET: CustomerPreferences
        public ActionResult Index()
        {
            return View(db.CustomerPreferences.ToList());
        }

        // GET: CustomerPreferences/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CustomerPreference customerPreference = db.CustomerPreferences.Find(id);
            if (customerPreference == null)
            {
                return HttpNotFound();
            }
            return View(customerPreference);
        }

        // GET: CustomerPreferences/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomerPreferences/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CustomerID,IdealSituation,BusinessPreference,StaffSizePreference,MultipleLocations,TopThreePerfectBusinessOpportunity1,TopThreePerfectBusinessOpportunity2,TopThreePerfectBusinessOpportunity3,RankTheseSkills1,RankTheseSkills2,RankTheseSkills3,RankTheseSkills4,RankTheseSkills5,TopThreeNonBusinessSkills1,TopThreeNonBusinessSkills2,TopThreeNonBusinessSkills3,WhatIsYourTimeFrame,SalesSkills,SalesSkillsExplanation,ColdCallingPhone,ColdCallingInPerson,DirectVsAdvertising,WhiteVsBlueColar,EstablishedVsNewConcept,SmallVsLargeFranchiseSystem,CompetitiveVsOnlyGameInTown,PrestigeOrNotImportant,BusinessToBusinessVsBusinessToConsumer,HoursPreferenceMonFri,HoursPreferenceNoNights,HoursPreferenceNoSaturdays,HoursPreferenceNoSundays,HoursPreferenceNoPreference,AnyMoreInformation")] CustomerPreference customerPreference)
        {
            if (ModelState.IsValid)
            {
                db.CustomerPreferences.Add(customerPreference);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(customerPreference);
        }

        // GET: CustomerPreferences/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CustomerPreference customerPreference = db.CustomerPreferences.Find(id);
            if (customerPreference == null)
            {
                return HttpNotFound();
            }
            return View(customerPreference);
        }

        // POST: CustomerPreferences/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CustomerID,IdealSituation,BusinessPreference,StaffSizePreference,MultipleLocations,TopThreePerfectBusinessOpportunity1,TopThreePerfectBusinessOpportunity2,TopThreePerfectBusinessOpportunity3,RankTheseSkills1,RankTheseSkills2,RankTheseSkills3,RankTheseSkills4,RankTheseSkills5,TopThreeNonBusinessSkills1,TopThreeNonBusinessSkills2,TopThreeNonBusinessSkills3,WhatIsYourTimeFrame,SalesSkills,SalesSkillsExplanation,ColdCallingPhone,ColdCallingInPerson,DirectVsAdvertising,WhiteVsBlueColar,EstablishedVsNewConcept,SmallVsLargeFranchiseSystem,CompetitiveVsOnlyGameInTown,PrestigeOrNotImportant,BusinessToBusinessVsBusinessToConsumer,HoursPreferenceMonFri,HoursPreferenceNoNights,HoursPreferenceNoSaturdays,HoursPreferenceNoSundays,HoursPreferenceNoPreference,AnyMoreInformation")] CustomerPreference customerPreference)
        {
            if (ModelState.IsValid)
            {
                db.Entry(customerPreference).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(customerPreference);
        }

        // GET: CustomerPreferences/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CustomerPreference customerPreference = db.CustomerPreferences.Find(id);
            if (customerPreference == null)
            {
                return HttpNotFound();
            }
            return View(customerPreference);
        }

        // POST: CustomerPreferences/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CustomerPreference customerPreference = db.CustomerPreferences.Find(id);
            db.CustomerPreferences.Remove(customerPreference);
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
