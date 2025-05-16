using CascadingLookup.Data.Entities;

namespace CascadingLookup.Data.Seed
{
    public static class DbInitializer
    {
        public static void Seed(AppDbContext db)
        {
            if (db.Countries.Any()) return;

            var usa = new Country { Name = "USA" };
            var pakistan = new Country { Name = "Pakistan" };

            db.Countries.AddRange(usa, pakistan);
            db.SaveChanges();

            var ny = new City { Name = "New York", CountryId = usa.Id };
            var la = new City { Name = "Los Angeles", CountryId = usa.Id };
            var lahore = new City { Name = "Lahore", CountryId = pakistan.Id };
            var islamabad = new City { Name = "Islamabad", CountryId = pakistan.Id };

            db.Cities.AddRange(ny, la, lahore, islamabad);
            db.SaveChanges();

            db.Areas.AddRange(
                new Area { Name = "Manhattan", CityId = ny.Id },
                new Area { Name = "Brooklyn", CityId = ny.Id },
                new Area { Name = "Walled City", CityId = lahore.Id },
                new Area { Name = "Murree", CityId = islamabad.Id }
            );

            db.SaveChanges();
        }
    }

}
