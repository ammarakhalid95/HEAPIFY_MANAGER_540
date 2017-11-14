﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HEAPIFY_Manager_540.Models;

namespace HEAPIFY_Manager_540.Controllers
{
    public class CreateOrderInternalsController : Controller
    {
        private HEAPIFY_Manager_540Context db = new HEAPIFY_Manager_540Context();

        // GET: CreateOrderInternals
        public ActionResult Index()
        {
            var createOrderInternals = db.CreateOrderInternals.Include(c => c.Patient);
            return View(createOrderInternals.ToList());
        }

        // GET: CreateOrderInternals/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CreateOrderInternal createOrderInternal = db.CreateOrderInternals.Find(id);
            if (createOrderInternal == null)
            {
                return HttpNotFound();
            }
            return View(createOrderInternal);
        }

        // GET: CreateOrderInternals/Create
        public ActionResult Create()
        {
            ViewBag.PatientID = new SelectList(db.Patients, "PatientID", "FirstName");
            return View();
        }

        // POST: CreateOrderInternals/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,OrderID,PatientID,OrderingProvider,Notes,Diagnoses,Lab,Type,ResponsibleOrder,Stat")] CreateOrderInternal createOrderInternal)
        {
            if (ModelState.IsValid)
            {
                db.CreateOrderInternals.Add(createOrderInternal);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.PatientID = new SelectList(db.Patients, "PatientID", "FirstName", createOrderInternal.PatientID);
            return View(createOrderInternal);
        }

        // GET: CreateOrderInternals/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CreateOrderInternal createOrderInternal = db.CreateOrderInternals.Find(id);
            if (createOrderInternal == null)
            {
                return HttpNotFound();
            }
            ViewBag.PatientID = new SelectList(db.Patients, "PatientID", "FirstName", createOrderInternal.PatientID);
            return View(createOrderInternal);
        }

        // POST: CreateOrderInternals/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,OrderID,PatientID,OrderingProvider,Notes,Diagnoses,Lab,Type,ResponsibleOrder,Stat")] CreateOrderInternal createOrderInternal)
        {
            if (ModelState.IsValid)
            {
                db.Entry(createOrderInternal).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PatientID = new SelectList(db.Patients, "PatientID", "FirstName", createOrderInternal.PatientID);
            return View(createOrderInternal);
        }

        // GET: CreateOrderInternals/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CreateOrderInternal createOrderInternal = db.CreateOrderInternals.Find(id);
            if (createOrderInternal == null)
            {
                return HttpNotFound();
            }
            return View(createOrderInternal);
        }

        // POST: CreateOrderInternals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CreateOrderInternal createOrderInternal = db.CreateOrderInternals.Find(id);
            db.CreateOrderInternals.Remove(createOrderInternal);
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
