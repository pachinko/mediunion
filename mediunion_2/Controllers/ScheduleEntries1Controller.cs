using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using mediunion_2.Models;

namespace mediunion_2.Controllers
{
    public class ScheduleEntries1Controller : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: ScheduleEntries1
        public ActionResult Index()
        {
            return View(db.ScheduleEntries.ToList());
        }

        // GET: ScheduleEntries1/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ScheduleEntry scheduleEntry = db.ScheduleEntries.Find(id);
            if (scheduleEntry == null)
            {
                return HttpNotFound();
            }
            return View(scheduleEntry);
        }

        // GET: ScheduleEntries1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ScheduleEntries1/Create
        // 若要免於過量張貼攻擊，請啟用想要繫結的特定屬性，如需
        // 詳細資訊，請參閱 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EntryId,DateAndTime,AgentName,FacilityName,CustomerName,CallNotes,GeneralFee,TransportationFee,Remarks")] ScheduleEntry scheduleEntry)
        {
            if (ModelState.IsValid)
            {
                db.ScheduleEntries.Add(scheduleEntry);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(scheduleEntry);
        }

        // GET: ScheduleEntries1/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ScheduleEntry scheduleEntry = db.ScheduleEntries.Find(id);
            if (scheduleEntry == null)
            {
                return HttpNotFound();
            }
            return View(scheduleEntry);
        }

        // POST: ScheduleEntries1/Edit/5
        // 若要免於過量張貼攻擊，請啟用想要繫結的特定屬性，如需
        // 詳細資訊，請參閱 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EntryId,DateAndTime,AgentName,FacilityName,CustomerName,CallNotes,GeneralFee,TransportationFee,Remarks")] ScheduleEntry scheduleEntry)
        {
            if (ModelState.IsValid)
            {
                db.Entry(scheduleEntry).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(scheduleEntry);
        }

        // GET: ScheduleEntries1/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ScheduleEntry scheduleEntry = db.ScheduleEntries.Find(id);
            if (scheduleEntry == null)
            {
                return HttpNotFound();
            }
            return View(scheduleEntry);
        }

        // POST: ScheduleEntries1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ScheduleEntry scheduleEntry = db.ScheduleEntries.Find(id);
            db.ScheduleEntries.Remove(scheduleEntry);
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
