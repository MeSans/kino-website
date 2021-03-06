﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using KinoSuite;
using KinoSuite.Models;
using System.Globalization;

namespace KinoSuite.Controllers
{
    public class ScreeningsController : Controller
    {
        private KinoContext db = new KinoContext();

        // GET: Screenings
        public async Task<ActionResult> Index()
        {
            var screenings = db.Screenings.Include(s => s.Movie).Include(s => s.Venue);
            return View(await screenings.ToListAsync());
        }

        // GET: Screenings/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Screening screening = await db.Screenings.FindAsync(id);
            if (screening == null)
            {
                return HttpNotFound();
            }
            return View(screening);
        }

        // GET: Screenings/Create
        public ActionResult Create()
        {
            ViewBag.MovieId = new SelectList(db.Movies, "ID", "Title");
            ViewBag.VenueId = new SelectList(db.Venues, "ID", "Name");
            return View();
        }

        // POST: Screenings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ID,MovieId,VenueId,ScreeningStart,ScreeningEnd,BasePrice,IsPremiere,SubtitleLanguage,Language")] Screening screening)
        {
            if (ModelState.IsValid)
            {
                db.Screenings.Add(screening);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.MovieId = new SelectList(db.Movies, "ID", "Title", screening.MovieId);
            ViewBag.VenueId = new SelectList(db.Venues, "ID", "Name", screening.VenueId);
            return View(screening);
        }

        // GET: Screenings/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Screening screening = await db.Screenings.FindAsync(id);
            if (screening == null)
            {
                return HttpNotFound();
            }
            ViewBag.MovieId = new SelectList(db.Movies, "ID", "Title", screening.MovieId);
            ViewBag.VenueId = new SelectList(db.Venues, "ID", "Name", screening.VenueId);
            return View(screening);
        }

        // POST: Screenings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ID,MovieId,VenueId,ScreeningStart,ScreeningEnd,BasePrice,IsPremiere,SubtitleLanguage,Language")] Screening screening)
        {
            if (ModelState.IsValid)
            {
                db.Entry(screening).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.MovieId = new SelectList(db.Movies, "ID", "Title", screening.MovieId);
            ViewBag.VenueId = new SelectList(db.Venues, "ID", "Name", screening.VenueId);
            return View(screening);
        }

        // GET: Screenings/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Screening screening = await db.Screenings.FindAsync(id);
            if (screening == null)
            {
                return HttpNotFound();
            }
            return View(screening);
        }

        // POST: Screenings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Screening screening = await db.Screenings.FindAsync(id);
            db.Screenings.Remove(screening);
            await db.SaveChangesAsync();
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
