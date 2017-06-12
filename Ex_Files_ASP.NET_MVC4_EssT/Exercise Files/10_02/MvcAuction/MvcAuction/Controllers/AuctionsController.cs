using MvcAuction.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace MvcAuction.Controllers
{
    public class AuctionsController : Controller
    {
        //
        // GET: /Auctions/

        [AllowAnonymous]
        [OutputCache(Duration = 1)]
        public ActionResult Index()
        {
            var db = new AuctionsDataContext();
            var auctions = db.Auctions.ToArray();

            return View(auctions);
        }

        [OutputCache(Duration = 10)]
        public ActionResult Auction(long id)
        {
            var db = new AuctionsDataContext();
            var auction = db.Auctions.Find(id);

            return View(auction);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Bid(Bid bid)
        {
            var db = new AuctionsDataContext();
            var auction = db.Auctions.Find(bid.AuctionId);

            if (auction == null)
            {
                ModelState.AddModelError("AuctionId", "Auction not found!");
            }
            else if (auction.CurrentPrice >= bid.Amount)
            {
                ModelState.AddModelError("Amount", "Bid amount must exceed current bid");
            }
            else
            {
                bid.Username = User.Identity.Name;
                auction.Bids.Add(bid);
                auction.CurrentPrice = bid.Amount;
                db.SaveChanges();
            }

            if(!Request.IsAjaxRequest())
                return RedirectToAction("Auction", new { id = bid.AuctionId });

            return Json(new {
                CurrentPrice = bid.Amount.ToString("C"),
                BidCount = auction.BidCount
            });
        }


        [HttpGet]
        public ActionResult Create()
        {
            var categoryList = new SelectList(new[] { "Automotive", "Electronics", "Games", "Home" });
            ViewBag.CategoryList = categoryList;
            return View();
        }

        [HttpPost]
        [Authorize]
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
