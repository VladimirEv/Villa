using MagicVilla_VillaApi.Models;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_VillaApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Villa> Villas { get; set; }

        protected override void OnModelCreating (ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<Villa>().HasData(
                 new Villa()
                 {
                     Id = 1,
                     Name = "Royal villa",
                     Details = "Master bedroom of 230 m2 with open air bathroom including separated rain shower, bath tub for 2 and completed wardrobe · 4 suites built and designed",
                     ImageUrl = "https://www.houzz.ru/foto/castellina-1272-model-home-phvw-vp~22592068",
                     Occupancy = 5,
                     Rate = 200,
                     Sqft = 350,
                     Amenity = "",
                     CreatedDate = DateTime.Now
                 },
                 new Villa()
                 {
                     Id = 2,
                     Name = "Viki villa",
                     Details = "Master bedroom of 280 m2 with open air bathroom including separated rain shower, bath tub for 3 and completed wardrobe · 5 suites built and designed",
                     ImageUrl = "https://www.houzz.ru/foto/private-residence-the-estuary-naples-fl-phvw-vp~6599751",
                     Occupancy = 7,
                     Rate = 450,
                     Sqft = 570,
                     Amenity = "",
                     CreatedDate = DateTime.Now
                 },
                 new Villa()
                 {
                     Id = 3,
                     Name = "Golden Sand villa",
                     Details = "Master bedroom of 370 m2 with open air bathroom including separated rain shower, bath tub for 4 and completed wardrobe · 4 suites built and designed",
                     ImageUrl = "https://www.google.com/search?q=Details+for+Villa&rlz=1C1GCEA_enBY909BY909&oq=Details+for+Villa&aqs=chrome..69i57j0i15i22i30i625j0i15i22i30j0i22i30j0i15i22i30.5191j0j7&sourceid=chrome&ie=UTF-8#imgrc=t_-GUyvZjXGWBM",
                     Occupancy = 11,
                     Rate = 550,
                     Sqft = 750,
                     Amenity = "",
                     CreatedDate = DateTime.Now
                 },
                new Villa()
                {
                    Id= 4,
                    Name = "Viliam villa",
                    Details = "Master bedroom of 480 m2 with open air bathroom including separated rain shower, bath tub for 5 and completed wardrobe · 4 suites built and designed",
                    ImageUrl = "https://www.google.com/search?q=Details+for+Villa&rlz=1C1GCEA_enBY909BY909&oq=Details+for+Villa&aqs=chrome..69i57j0i15i22i30i625j0i15i22i30j0i22i30j0i15i22i30.5191j0j7&sourceid=chrome&ie=UTF-8#imgrc=t_-GUyvZjXGWBM",
                    Occupancy = 15,
                    Rate = 800,
                    Sqft = 1050,
                    Amenity = "",
                    CreatedDate = DateTime.Now
                },
                new Villa()
                {
                    Id = 5,
                    Name = "Teritorial villa",
                    Details = "Master bedroom of 580 m2 with open air bathroom including separated rain shower, bath tub for 7 and completed wardrobe · 4 suites built and designed",
                    ImageUrl = "https://www.google.com/search?q=Details+for+Villa&rlz=1C1GCEA_enBY909BY909&oq=Details+for+Villa&aqs=chrome..69i57j0i15i22i30i625j0i15i22i30j0i22i30j0i15i22i30.5191j0j7&sourceid=chrome&ie=UTF-8#imgrc=t_-GUyvZjXGWBM",
                    Occupancy = 25,
                    Rate = 1250,
                    Sqft = 1650,
                    Amenity = "",
                    CreatedDate = DateTime.Now
                }
               );
        }
    }
}
