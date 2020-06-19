using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Wedding_Planner.Models;

namespace Wedding_Planner.Controllers
{
    public class WeddingController : Controller
    {
        private Wedding_PlannerContext db;

        private int? uid
        {
            get
            {
                return HttpContext.Session.GetInt32("UserId");
            }
        }

        private bool isLoggedIn
        {
            get
            {
                return uid != null;
            }
        }
        public WeddingController(Wedding_PlannerContext context)
        {
        db = context;
        }

        [HttpGet("dashboard")]
        public IActionResult Dashboard()
        {
            if (!isLoggedIn)
            {
                return RedirectToAction("Index", "Home");
            }

            User userInDb = db.Users.FirstOrDefault(user => user.UserId == uid);

            List<Wedding> allweddings = db.Weddings
                .Include(wedding => wedding.Creator)
                .Include(wedding => wedding.RSVP)
                .ThenInclude(wedding => wedding.User)
                .ToList();
            
            return View("Dashboard", allweddings);
        }

        [HttpGet("new_wedding")]
        public IActionResult NewWedding()
        {
            if (!isLoggedIn)
            {
                return RedirectToAction("Index", "Home");
            }

            return View("NewWedding");
        }

        [HttpPost("new_wedding/create")]
        public IActionResult CreateNewWedding(Wedding new_wedding)
        {
            User userinsesh = db.Users.FirstOrDefault(user => user.UserId == HttpContext.Session.GetInt32("UserId"));

            if (!isLoggedIn)
            {
                return RedirectToAction("Index", "Home");
            }
            if (ModelState.IsValid)
            {
                new_wedding.Creator = userinsesh;
                db.Add(new_wedding);
                db.SaveChanges();
                return RedirectToAction("Dashboard", new_wedding);
            }
            return View("NewWedding");
        }

        [HttpGet("wedding/{weddingId}")]
        public IActionResult Details(int weddingId)
        {
            if (!isLoggedIn)
            {
                return RedirectToAction("Index", "Home");
            }

            Wedding selectedWedding = db.Weddings
                .Include(wedding => wedding.Creator)
                .Include(wedding => wedding.RSVP)
                .ThenInclude(wedding => wedding.User)
                .FirstOrDefault(wedding => wedding.WeddingId == weddingId);

            if (selectedWedding == null)
            {
                return RedirectToAction("Dashboard");
            }

            return View("OneWedding", selectedWedding);
        }

        [HttpGet("wedding/{weddingId}/rsvp")]
        public IActionResult RSVP(int weddingId)
        {
            if (!isLoggedIn)
            {
                return RedirectToAction("Index", "Home");
            }

            RSVP rsvp = db.RSVPs.FirstOrDefault(vp => vp.WeddingId == weddingId && vp.UserId == uid);

            if (rsvp != null)
            {
                db.RSVPs.Remove(rsvp);
            }
            else
            {
                RSVP newRsvp = new RSVP()
                {
                    UserId = (int)uid,
                    WeddingId = weddingId
                };

                db.RSVPs.Add(newRsvp);
            }

            db.SaveChanges();
            return RedirectToAction("Dashboard");
        }

        [HttpGet("wedding/{weddingId}/delete")]
        public IActionResult Delete(int weddingId)
        {
            if (!isLoggedIn)
            {
                return RedirectToAction("Index", "Home");
            }

            Wedding selectedWedding = db.Weddings.FirstOrDefault(wedding => wedding.WeddingId == weddingId);

            if (selectedWedding == null || selectedWedding.UserId != uid)
            {
                return RedirectToAction("Dashboard");
            }

            db.Weddings.Remove(selectedWedding);
            db.SaveChanges();
            return RedirectToAction("Dashboard");
        }
    }
}