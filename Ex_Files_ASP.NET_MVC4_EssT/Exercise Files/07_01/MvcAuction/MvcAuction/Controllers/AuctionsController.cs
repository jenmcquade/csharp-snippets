using MvcAuction.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcAuction.Controllers
{
    public class AuctionsController : Controller
    {
        //
        // GET: /Auctions/

        public ActionResult Index()
        {
            var db = new AuctionsDataContext();
            var auctions = db.Auctions.ToArray();

            return View(auctions);
        }

        public ActionResult Auction(long id)
        {
            var db = new AuctionsDataContext();
            var auction = db.Auctions.Find(id);

            return View(auction);
        }

        [HttpGet]
        public ActionResult Create()
        {
            var categoryList = new SelectList(new[] { "Automotive", "Electronics", "Games", "Home" });
            ViewBag.CategoryList = categoryList;
            return View();
        }

        [HttpPost]
        public ActionResult Create([Bind(Exclude="CurrentPrice")]Models.Auction auction)
        {
            if (ModelState.IsValid)
            {
                // Save to the database
                var db = new AuctionsDataContext();
                db.Auctions.Add(auction);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
                
            return Create();
        }
    }
}
