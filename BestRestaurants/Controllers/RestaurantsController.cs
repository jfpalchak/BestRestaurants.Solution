using Microsoft.AspNetCore.Mvc;
using BestRestaurants.Models;
using System.Collections.Generic;
using System.Linq;
// USING DIRECTIVES HERE

namespace BestRestaurants.Controllers
{
  public class RestaurantsController : Controller
  {
    private readonly BestRestaurantsContext _db;

    public RestaurantsController(BestRestaurantsContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    { // Database -> Restaurant Table -> For each Restaurant row, grab the information for it's associated Cuisine -> Return each Restaurant item and put it in a list
      // List<Restaurant> model = _db.Restaurants.Include(restaurant => restaurant.Cuisine).ToList();
      List<Restaurant> model = _db.Restaurants.ToList();
      return View(model);
    }

    public ActionResult Create() 
    {
      return View();
    }
    
    [HttpPost]
    public ActionResult Create(Restaurant restaurant)
    {
      _db.Restaurants.Add(restaurant);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Restaurant thisRestaurant = _db.Restaurants.FirstOrDefault(restaurant => restaurant.RestaurantId == id);
      return View(thisRestaurant);
    }
  }
}