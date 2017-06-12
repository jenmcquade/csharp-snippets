using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using MvcAuction.Models;

namespace MvcAuction.Api
{
    public class AuctionsController : ApiController
    {
        private AuctionsDataContext db = new AuctionsDataContext();


        public AuctionsController()
        {
            db.Configuration.ProxyCreationEnabled = false;
        }

        // GET api/Auctions
        public IEnumerable<Auction> GetAuctions()
        {
            return db.Auctions.AsEnumerable();
        }

        // GET api/Auctions/5
        public Auction GetAuction(long id)
        {
            Auction auction = db.Auctions.Find(id);
            if (auction == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }

            return auction;
        }

        // PUT api/Auctions/5
        public HttpResponseMessage PutAuction(long id, Auction auction)
        {
            if (ModelState.IsValid && id == auction.Id)
            {
                db.Entry(auction).State = EntityState.Modified;

                try
                {
                    db.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound);
                }

                return Request.CreateResponse(HttpStatusCode.OK);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }

        // POST api/Auctions
        public HttpResponseMessage PostAuction(Auction auction)
        {
            if (ModelState.IsValid)
            {
                db.Auctions.Add(auction);
                db.SaveChanges();

                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, auction);
                response.Headers.Location = new Uri(Url.Link("DefaultApi", new { id = auction.Id }));
                return response;
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }

        // DELETE api/Auctions/5
        public HttpResponseMessage DeleteAuction(long id)
        {
            Auction auction = db.Auctions.Find(id);
            if (auction == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            db.Auctions.Remove(auction);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            return Request.CreateResponse(HttpStatusCode.OK, auction);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}