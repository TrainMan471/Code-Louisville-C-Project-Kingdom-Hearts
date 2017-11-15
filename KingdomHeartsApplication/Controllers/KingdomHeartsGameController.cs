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
    public class KingdomHeartsGameController : Controller
    {
        private DB db = new DB();

        // GET: KingdomHeartsGame
        public ActionResult Index()
        {
            return View(db.KingdomHeartsGames.ToList());
        }

        // GET: KingdomHeartsGame/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KingdomHeartsGame kingdomHeartsGame = db.KingdomHeartsGames.Find(id);
            if (kingdomHeartsGame == null)
            {
                return HttpNotFound();
            }
            return View(kingdomHeartsGame);
        }

        // GET: KingdomHeartsGame/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: KingdomHeartsGame/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Title,Description,PlayableCharacter,ReleaseDate")] KingdomHeartsGame kingdomHeartsGame)
        {
            if (ModelState.IsValid)
            {
                db.KingdomHeartsGames.Add(kingdomHeartsGame);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(kingdomHeartsGame);
        }

        // GET: KingdomHeartsGame/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KingdomHeartsGame kingdomHeartsGame = db.KingdomHeartsGames.Find(id);
            if (kingdomHeartsGame == null)
            {
                return HttpNotFound();
            }
            return View(kingdomHeartsGame);
        }

        // POST: KingdomHeartsGame/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Title,Description,PlayableCharacter,ReleaseDate")] KingdomHeartsGame kingdomHeartsGame)
        {
            if (ModelState.IsValid)
            {
                db.Entry(kingdomHeartsGame).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(kingdomHeartsGame);
        }

        // GET: KingdomHeartsGame/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KingdomHeartsGame kingdomHeartsGame = db.KingdomHeartsGames.Find(id);
            if (kingdomHeartsGame == null)
            {
                return HttpNotFound();
            }
            return View(kingdomHeartsGame);
        }

        // POST: KingdomHeartsGame/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            KingdomHeartsGame kingdomHeartsGame = db.KingdomHeartsGames.Find(id);
            db.KingdomHeartsGames.Remove(kingdomHeartsGame);
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
