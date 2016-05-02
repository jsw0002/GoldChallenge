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
    public class FranchiseContactsController : Controller
    {
        private FranchiseContext db = new FranchiseContext();

        // GET: FranchiseContacts
        public ActionResult Index()
        {
            return View(db.FranchiseContacts.ToList());
        }

        // GET: FranchiseContacts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FranchiseContact franchiseContact = db.FranchiseContacts.Find(id);
            if (franchiseContact == null)
            {
                return HttpNotFound();
            }
            return View(franchiseContact);
        }

        // GET: FranchiseContacts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FranchiseContacts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,ContactFor,LastName,FirstName,Email,Address,City,State,ZipCode,Phone")] FranchiseContact franchiseContact)
        {
            if (ModelState.IsValid)
            {
                db.FranchiseContacts.Add(franchiseContact);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(franchiseContact);
        }

        // GET: FranchiseContacts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FranchiseContact franchiseContact = db.FranchiseContacts.Find(id);
            if (franchiseContact == null)
            {
                return HttpNotFound();
            }
            return View(franchiseContact);
        }

        // POST: FranchiseContacts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,ContactFor,LastName,FirstName,Email,Address,City,State,ZipCode,Phone")] FranchiseContact franchiseContact)
        {
            if (ModelState.IsValid)
            {
                db.Entry(franchiseContact).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(franchiseContact);
        }

        // GET: FranchiseContacts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FranchiseContact franchiseContact = db.FranchiseContacts.Find(id);
            if (franchiseContact == null)
            {
                return HttpNotFound();
            }
            return View(franchiseContact);
        }

        // POST: FranchiseContacts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FranchiseContact franchiseContact = db.FranchiseContacts.Find(id);
            db.FranchiseContacts.Remove(franchiseContact);
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
