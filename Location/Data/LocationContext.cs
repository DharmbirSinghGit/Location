using Location.Model;
using Microsoft.EntityFrameworkCore;

namespace Location.Data
{
    public class LocationContext:DbContext
    {
        public LocationContext(DbContextOptions<LocationContext> options) : base(options) { }
        public DbSet<LocationModel> locations { get; set; }
    }
}
