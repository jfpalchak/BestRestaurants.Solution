using System.Collections.Generic;

namespace BestRestaurants.Models
{
  public class Cuisine 
  {
    public string Name { get; set; }
    // "other end" of navigation property
    public int CuisineId { get; set; }

    // Collection Navigation Property:
    // Navigation properties are not actually in the Database:
    // Instead, they are populated in our projects BY EF Core FROM the database.
    public List<Restaurant> Restaurants { get; set; }
  }
}