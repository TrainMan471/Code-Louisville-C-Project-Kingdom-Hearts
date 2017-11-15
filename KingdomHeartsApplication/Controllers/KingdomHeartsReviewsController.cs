using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using KingdomHeartsApplication.DAL;
using KingdomHeartsApplication.Models;

namespace KingdomHeartsApplication.Controllers
{
    public class KingdomHeartsReviewsController : Controller
    {
        private DB db = new DB();

        // GET: KingdomHeartsReviews
        public ActionResult Index()
        {
            return View(db.KingdomHeartsReviews.ToList());
        }

        // GET: KingdomHeartsReviews/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KingdomHeartsReview kingdomHeartsReview = db.KingdomHeartsReviews.Find(id);
            if (kingdomHeartsReview == null)
            {
                return HttpNotFound();
            }
            return View(kingdomHeartsReview);
        }

        // GET: KingdomHeartsReviews/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: KingdomHeartsReviews/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Username,HighestDifficulty,FavoriteGame,Rating")] KingdomHeartsReview kingdomHeartsReview)
        {
            if (ModelState.IsValid)
            {
                db.KingdomHeartsReviews.Add(kingdomHeartsReview);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(kingdomHeartsReview);
        }

        // GET: KingdomHeartsReviews/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KingdomHeartsReview kingdomHeartsReview = db.KingdomHeartsReviews.Find(id);
            if (kingdomHeartsReview == null)
            {
                return HttpNotFound();
            }
            return View(kingdomHeartsReview);
        }

        // POST: KingdomHeartsReviews/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Username,HighestDifficulty,FavoriteGame,Rating")] KingdomHeartsReview kingdomHeartsReview)
        {
            if (ModelState.IsValid)
            {
                db.Entry(kingdomHeartsReview).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(kingdomHeartsReview);
        }

        // GET: KingdomHeartsReviews/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KingdomHeartsReview kingdomHeartsReview = db.KingdomHeartsReviews.Find(id);
            if (kingdomHeartsReview == null)
            {
                return HttpNotFound();
            }
            return View(kingdomHeartsReview);
        }

        // POST: KingdomHeartsReviews/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            KingdomHeartsReview kingdomHeartsReview = db.KingdomHeartsReviews.Find(id);
            db.KingdomHeartsReviews.Remove(kingdomHeartsReview);
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
