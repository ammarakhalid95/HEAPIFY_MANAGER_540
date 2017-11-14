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
    public class PatientAllergiesController : Controller
    {
        private HEAPIFY_Manager_540Context db = new HEAPIFY_Manager_540Context();

        // GET: PatientAllergies
        public ActionResult Index()
        {
            var patientAllergies = db.PatientAllergies.Include(p => p.Patient);
            return View(patientAllergies.ToList());
        }

        // GET: PatientAllergies/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PatientAllergy patientAllergy = db.PatientAllergies.Find(id);
            if (patientAllergy == null)
            {
                return HttpNotFound();
            }
            return View(patientAllergy);
        }

        // GET: PatientAllergies/Create
        public ActionResult Create()
        {
            ViewBag.PatientID = new SelectList(db.Patients, "PatientID", "FirstName");
            return View();
        }

        // POST: PatientAllergies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PatientAllergyID,PatientID,AllergiesID")] PatientAllergy patientAllergy)
        {
            if (ModelState.IsValid)
            {
                db.PatientAllergies.Add(patientAllergy);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.PatientID = new SelectList(db.Patients, "PatientID", "FirstName", patientAllergy.PatientID);
            return View(patientAllergy);
        }

        // GET: PatientAllergies/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PatientAllergy patientAllergy = db.PatientAllergies.Find(id);
            if (patientAllergy == null)
            {
                return HttpNotFound();
            }
            ViewBag.PatientID = new SelectList(db.Patients, "PatientID", "FirstName", patientAllergy.PatientID);
            return View(patientAllergy);
        }

        // POST: PatientAllergies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PatientAllergyID,PatientID,AllergiesID")] PatientAllergy patientAllergy)
        {
            if (ModelState.IsValid)
            {
                db.Entry(patientAllergy).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PatientID = new SelectList(db.Patients, "PatientID", "FirstName", patientAllergy.PatientID);
            return View(patientAllergy);
        }

        // GET: PatientAllergies/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PatientAllergy patientAllergy = db.PatientAllergies.Find(id);
            if (patientAllergy == null)
            {
                return HttpNotFound();
            }
            return View(patientAllergy);
        }

        // POST: PatientAllergies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PatientAllergy patientAllergy = db.PatientAllergies.Find(id);
            db.PatientAllergies.Remove(patientAllergy);
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
