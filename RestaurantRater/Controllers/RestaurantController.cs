using RestaurantRater.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestaurantRater.Controllers
{
    public class RestaurantController : Controller
    {
        private RestaurantDbContext _db = new RestaurantDbContext();

        // GET: Restaurant
        public ActionResult Index()
        {
            return View(_db.Restaurants.ToList());
        }

        // GET: Restaurant/Create
        public ActionResult Create()
        {
            return View();
        }

        // Post: Restaurant/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Restaurant restaurant)
        {
            if (ModelState.IsValid) //Checks the model given to the method
            {
                _db.Restaurants.Add(restaurant); //Adding the Restaurant parameter to the Restaurants Table
                _db.SaveChanges(); //Saves changes to actual SQL Database
                return RedirectToAction("Index");
            }

            return View(restaurant);
        }
    }
}