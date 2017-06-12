using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcAuction.Models;

namespace MobileWebsite.Controllers
{
    public class AuctionsController : Controller
    {
        private AuctionsDataContext db = new AuctionsDataContext();

        //
        // GET: /Auctions/

        public ActionResult Index()
        {
            return View(db.Auctions.ToList());
        }

        //
        // GET: /Auctions/Details/5

        public ActionResult Details(long id = 0)
        {
            Auction auction = db.Auctions.Find(id);
            if (auction == null)
            {
                return HttpNotFound();
            }
            return View(auction);
        }

        //
        // GET: /Auctions/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Auctions/Create

        [HttpPost]
        public ActionResult Create(Auction auction)
        {
            if (ModelState.IsValid)
            {
                db.Auctions.Add(auction);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(auction);
        }

        //
        // GET: /Auctions/Edit/5

        public ActionResult Edit(long id = 0)
        {
            Auction auction = db.Auctions.Find(id);
            if (auction == null)
            {
                return HttpNotFound();
            }
            return View(auction);
        }

        //
        // POST: /Auctions/Edit/5

        [HttpPost]
        public ActionResult Edit(Auction auction)
        {
            if (ModelState.IsValid)
            {
                db.Entry(auction).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(auction);
        }

        //
        // GET: /Auctions/Delete/5

        public ActionResult Delete(long id = 0)
        {
            Auction auction = db.Auctions.Find(id);
            if (auction == null)
            {
                return HttpNotFound();
            }
            return View(auction);
        }

        //
        // POST: /Auctions/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(long id)
        {
            Auction auction = db.Auctions.Find(id);
            db.Auctions.Remove(auction);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}