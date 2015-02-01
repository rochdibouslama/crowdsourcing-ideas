using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Crowdsourcing.Domain.Entity;
using Crowdsourcing.Data;

namespace Crowdsourcing.web.Controllers
{
    public class EnterprisesManagersController : Controller
    {
        private CrowdsourcingContext db = new CrowdsourcingContext();

        // GET: /EnterprisesManagers/
        public ActionResult Index()
        {
            return View(db.EnterprisesManagers.ToList());
        }

        // GET: /EnterprisesManagers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EnterpriseManager enterprisemanager = db.EnterprisesManagers.Find(id);
            if (enterprisemanager == null)
            {
                return HttpNotFound();
            }
            return View(enterprisemanager);
        }

        // GET: /EnterprisesManagers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /EnterprisesManagers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="EnterpriseManagerId,Name,PhoneNumber,Age,BirthDate,Password,subscriptionDate,Email,Pseudo,Username,Location")] EnterpriseManager enterprisemanager)
        {
            if (ModelState.IsValid)
            {
                db.EnterprisesManagers.Add(enterprisemanager);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(enterprisemanager);
        }

        // GET: /EnterprisesManagers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EnterpriseManager enterprisemanager = db.EnterprisesManagers.Find(id);
            if (enterprisemanager == null)
            {
                return HttpNotFound();
            }
            return View(enterprisemanager);
        }

        // POST: /EnterprisesManagers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="EnterpriseManagerId,Name,PhoneNumber,Age,BirthDate,Password,subscriptionDate,Email,Pseudo,Username,Location")] EnterpriseManager enterprisemanager)
        {
            if (ModelState.IsValid)
            {
                db.Entry(enterprisemanager).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(enterprisemanager);
        }

        // GET: /EnterprisesManagers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EnterpriseManager enterprisemanager = db.EnterprisesManagers.Find(id);
            if (enterprisemanager == null)
            {
                return HttpNotFound();
            }
            return View(enterprisemanager);
        }

        // POST: /EnterprisesManagers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EnterpriseManager enterprisemanager = db.EnterprisesManagers.Find(id);
            db.EnterprisesManagers.Remove(enterprisemanager);
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
