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
            // Let's get all states that we need for a DropDownList
            var states = GetAllStates();

            var model = new FranchiseContact();

            // Create a list of SelectListItems so these can be rendered on the page
            model.States = GetSelectListItems(states);

            return View(model);
        }

        // POST: FranchiseContacts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,ContactFor,LastName,FirstName,Email,Address,City,State,ZipCode,Phone")] FranchiseContact franchiseContact)
        {
            // Get all states again
            var states = GetAllStates();

            // Set these states on the model. We need to do this because
            // only the selected value from the DropDownList is posted back, not the whole
            // list of states
            franchiseContact.States = GetSelectListItems(states);

            if (ModelState.IsValid)
            {
                Session["FranchiseContact"] = franchiseContact;
                db.FranchiseContacts.Add(franchiseContact);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View("Create", franchiseContact);
        }

        // GET: FranchiseContacts/Edit/5
        public ActionResult Edit(int? id)
        {
            var states = GetAllStates();

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FranchiseContact franchiseContact = db.FranchiseContacts.Find(id);
            franchiseContact.States = GetSelectListItems(states);

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
            var states = GetAllStates();
            franchiseContact.States = GetSelectListItems(states);

            if (ModelState.IsValid)
            {
                Session["FranchiseContact"] = franchiseContact;
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

        // Just return a list of states - in a real-world application this would call
        // into data access layer to retrieve states from a database.
        private IEnumerable<string> GetAllStates()
        {
            return new List<string>
            {
                "AL",
                "AK",
                "AZ",
                "AR",
                "CA",
                "CO",
                "CT",
                "DE",
                "DC",
                "FL",
                "GA",
                "HI",
                "ID",
                "IL",
                "IN",
                "IA",
                "KS",
                "KY",
                "LA",
                "ME",
                "MD",
                "MA",
                "MI",
                "MN",
                "MS",
                "MO",
                "MT",
                "NE",
                "NV",
                "NH",
                "NJ",
                "NM",
                "NY",
                "NC",
                "ND",
                "OH",
                "OK",
                "OR",
                "PA",
                "RI",
                "SC",
                "SD",
                "TN",
                "TX",
                "UT",
                "VT",
                "VA",
                "WA",
                "WV",
                "WI",
                "WY"
            };
        }

        // This is one of the most important parts in the whole example.
        // This function takes a list of strings and returns a list of SelectListItem objects.
        // These objects are going to be used later in the SignUp.html template to render the
        // DropDownList.
        private IEnumerable<SelectListItem> GetSelectListItems(IEnumerable<string> elements)
        {
            // Create an empty list to hold result of the operation
            var selectList = new List<SelectListItem>();

            // For each string in the 'elements' variable, create a new SelectListItem object
            // that has both its Value and Text properties set to a particular value.
            // This will result in MVC rendering each item as:
            //     <option value="State Name">State Name</option>
            foreach (var element in elements)
            {
                selectList.Add(new SelectListItem
                {
                    Value = element,
                    Text = element
                });
            }

            return selectList;
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
