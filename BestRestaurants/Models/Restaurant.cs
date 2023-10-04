
namespace BestRestaurants.Models
{
  public class Restaurant 
  {
    public int RestaurantId { get; set; }
    public string Name { get; set; }
    public string City { get; set; }
    public bool Accessible { get; set; }
    public int Capacity { get; set; }

    // Foreign Key
    public int CuisineId { get; set; }
    
    // Reference Navigation Property 
    // (this creates our One-to-Many relationship!)
    // Navigation properties are not actually in the Database:
    // Instead, they are populated in our projects BY EF Core FROM the database.
    public Cuisine Cuisine { get; set; }
  }
}

