using Microsoft.EntityFrameworkCore;

namespace HotelListing.API.Data
{
    public class HotelListingDbContext : DbContext
    {
        public HotelListingDbContext(DbContextOptions options) : base(options)
        {
            //This is where we are going to be outlining different tables
        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }

        //Here we are seeding the data into the database, so that we can use it 
        //when the database runs for the first time
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "Jamaica",
                    ShortName = "JM"

                },

                new Country
                {
                    Id = 2,
                    Name = "Japan",
                    ShortName = "JPN"
                }, 
                new Country
                {
                    Id = 3,
                    Name = "China",
                    ShortName = "CHN"
                }

                );

            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Sandals Resort and  Spa",
                    Address = "Negril",
                    CountryId = 1,
                    Rating = 4.2
                },

                new Hotel
                {
                    Id =2,
                    Name = "Comfort Suites",
                    Address = "George Town",
                    CountryId = 3,
                    Rating = 4.5
                },

                new Hotel
                {
                    Id = 3,
                    Name = "Grand Palldium",
                    Address = "Nassua",
                    CountryId = 2,
                    Rating = 3.7
                }
                );
        } 
    }
}
