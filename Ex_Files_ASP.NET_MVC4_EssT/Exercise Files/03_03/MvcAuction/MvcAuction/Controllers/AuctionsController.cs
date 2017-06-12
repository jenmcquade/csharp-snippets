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
            var message = (string)TempData["SuccessMessage"];
            return View();
        }

        public ActionResult TempDataExample()
        {
            TempData["SuccessMessage"] = "The action succeeded!";

            return RedirectToAction("Index");
        }

        public ActionResult Auction()
        {
            var auction = new MvcAuction.Models.Auction()
            {
                Title = "Example Auction",
                Description = "This is an example Auction",
                StartTime = DateTime.Now,
                EndTime = DateTime.Now.AddDays(7),
                StartPrice = 1.00m,
                CurrentPrice = null,
            };

            return View(auction);
        }
    }
}
