using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MyRepository;

namespace MyTicketingSystem.Controllers
{
    public class CustomerController : Controller
    {
        private MyTicketingEntities db = new MyTicketingEntities();

        // GET: Customer
        public ActionResult Index()
        {
            var customer = db.Customer.Include(c => c.CustomerType).Include(c => c.Gender).Include(c => c.MaritalStatusType).Include(c => c.PreferredContactType).Include(c => c.SchoolLevel).Include(c => c.School).Include(c => c.PeopleTitleType);
            return View(customer.ToList());
        }

        // GET: Customer/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = db.Customer.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        // GET: Customer/Create
        public ActionResult Create()
        {
            ViewBag.CustomerTypeId = new SelectList(db.CustomerType, "Id", "Code");
            ViewBag.GenderId = new SelectList(db.Gender, "Id", "Code");
            ViewBag.MaritalStatusId = new SelectList(db.MaritalStatusType, "Id", "Code");
            ViewBag.PreferredContactTypeId = new SelectList(db.PreferredContactType, "Id", "Code");
            ViewBag.SchoolLevelId = new SelectList(db.SchoolLevel, "Id", "Code");
            ViewBag.SchoolId = new SelectList(db.School, "Id", "Code");
            ViewBag.TitleId = new SelectList(db.PeopleTitleType, "Id", "Code");
            return View();
        }

        // POST: Customer/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,CustomerTypeId,TitleId,FirstName,LastName,GenderId,BirthDate,NationalityCode,MaritalStatusId,PreferredContactTypeId,SchoolLevelId,SchoolId,Photo,Bdx_Modibus,Vcub,Bdx_NewsletterEnterprise,Bdx_Newsletter1,Bdx_Newsletter2,Bdx_Newsletter3,AllowPhotoCapture,LastActivityDate,InsDate,InsOperId,ModDate,ModOperId,IsDeleted,RV")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                db.Customer.Add(customer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CustomerTypeId = new SelectList(db.CustomerType, "Id", "Code", customer.CustomerTypeId);
            ViewBag.GenderId = new SelectList(db.Gender, "Id", "Code", customer.GenderId);
            ViewBag.MaritalStatusId = new SelectList(db.MaritalStatusType, "Id", "Code", customer.MaritalStatusId);
            ViewBag.PreferredContactTypeId = new SelectList(db.PreferredContactType, "Id", "Code", customer.PreferredContactTypeId);
            ViewBag.SchoolLevelId = new SelectList(db.SchoolLevel, "Id", "Code", customer.SchoolLevelId);
            ViewBag.SchoolId = new SelectList(db.School, "Id", "Code", customer.SchoolId);
            ViewBag.TitleId = new SelectList(db.PeopleTitleType, "Id", "Code", customer.TitleId);
            return View(customer);
        }

        // GET: Customer/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = db.Customer.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            ViewBag.CustomerTypeId = new SelectList(db.CustomerType, "Id", "Code", customer.CustomerTypeId);
            ViewBag.GenderId = new SelectList(db.Gender, "Id", "Code", customer.GenderId);
            ViewBag.MaritalStatusId = new SelectList(db.MaritalStatusType, "Id", "Code", customer.MaritalStatusId);
            ViewBag.PreferredContactTypeId = new SelectList(db.PreferredContactType, "Id", "Code", customer.PreferredContactTypeId);
            ViewBag.SchoolLevelId = new SelectList(db.SchoolLevel, "Id", "Code", customer.SchoolLevelId);
            ViewBag.SchoolId = new SelectList(db.School, "Id", "Code", customer.SchoolId);
            ViewBag.TitleId = new SelectList(db.PeopleTitleType, "Id", "Code", customer.TitleId);
            return View(customer);
        }

        // POST: Customer/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,CustomerTypeId,TitleId,FirstName,LastName,GenderId,BirthDate,NationalityCode,MaritalStatusId,PreferredContactTypeId,SchoolLevelId,SchoolId,Photo,Bdx_Modibus,Vcub,Bdx_NewsletterEnterprise,Bdx_Newsletter1,Bdx_Newsletter2,Bdx_Newsletter3,AllowPhotoCapture,LastActivityDate,InsDate,InsOperId,ModDate,ModOperId,IsDeleted,RV")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(customer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CustomerTypeId = new SelectList(db.CustomerType, "Id", "Code", customer.CustomerTypeId);
            ViewBag.GenderId = new SelectList(db.Gender, "Id", "Code", customer.GenderId);
            ViewBag.MaritalStatusId = new SelectList(db.MaritalStatusType, "Id", "Code", customer.MaritalStatusId);
            ViewBag.PreferredContactTypeId = new SelectList(db.PreferredContactType, "Id", "Code", customer.PreferredContactTypeId);
            ViewBag.SchoolLevelId = new SelectList(db.SchoolLevel, "Id", "Code", customer.SchoolLevelId);
            ViewBag.SchoolId = new SelectList(db.School, "Id", "Code", customer.SchoolId);
            ViewBag.TitleId = new SelectList(db.PeopleTitleType, "Id", "Code", customer.TitleId);
            return View(customer);
        }

        // GET: Customer/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = db.Customer.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        // POST: Customer/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Customer customer = db.Customer.Find(id);
            db.Customer.Remove(customer);
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
