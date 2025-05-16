using CascadingLookup.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace CascadingLookup.Data
{
    public class AppDbContext : DbContext
    {
        private AppDbContext(){} // required by ef core.
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Country> Countries => Set<Country>();
        public DbSet<City> Cities => Set<City>();
        public DbSet<Area> Areas => Set<Area>();
    }

}
