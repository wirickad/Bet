using Microsoft.EntityFrameworkCore;

namespace BetAPI.Data
{
    public class FoodDBContext : DbContext
    {
        public FoodDBContext (DbContextOptions<FoodDBContext> options) : base(options) { }

        public DbSet<MarriottFood> Foods { get; set; }


    }
}
