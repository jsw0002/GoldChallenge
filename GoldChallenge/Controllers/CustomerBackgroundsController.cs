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
            // Let's get all states that we need for a DropDownList
            var timeLooking = GetAllTimeLooking();

            var model = new CustomerBackground();

            // Create a list of SelectListItems so these can be rendered on the page
            model.LengthOfTimeLookingDropDown = GetSelectListItems(timeLooking);

            return View(model);
        }

        // POST: CustomerBackgrounds/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CustomerID,AreThereAnyOtherDecisionMakers,IsMarried,SpouseName,CurrentOccupation,ProfessionalBackground1,ProfessionalBackground2,ProfessionalBackground3,ProfessionalBackground4,ProfessionalBackground5,AreYouAVet,HaveYouOwnedABusinessBefore,CreditScore,CashInvestment,InvestmentSource,NetWorth,DesiredMarket,WhyAreYouLookingAtBusinesses,LengthOfTimeLooking,SpokenWithAnyoneElse")] CustomerBackground customerBackground)
        {
            var timeLooking = GetAllTimeLooking();

            customerBackground.LengthOfTimeLookingDropDown = GetSelectListItems(timeLooking);

            if (ModelState.IsValid)
            {
                Session["CustomerBackground"] = customerBackground;
                db.CustomerBackgrounds.Add(customerBackground);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View("Create", customerBackground);
        }

        // GET: CustomerBackgrounds/Edit/5
        public ActionResult Edit(int? id)
        {
            var timeLooking = GetAllTimeLooking();

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CustomerBackground customerBackground = db.CustomerBackgrounds.Find(id);
            customerBackground.LengthOfTimeLookingDropDown = GetSelectListItems(timeLooking);

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
            var timeLooking = GetAllTimeLooking();
            customerBackground.LengthOfTimeLookingDropDown = GetSelectListItems(timeLooking);

            if (ModelState.IsValid)
            {
                Session["CustomerBackground"] = customerBackground;
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

        // Just return a list of states - in a real-world application this would call
        // into data access layer to retrieve states from a database.
        private IEnumerable<string> GetAllTimeLooking()
        {
            return new List<string>
            {
                "0-3 Months",
                "3-6 Months",
                "6-12 Months",
                "1 Year +"
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
