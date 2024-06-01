using CheeseApp.Server;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace cheeseria.Server.DataRepositories
{
    public class ShopContext : DbContext
    {
        public DbSet<CheeseDTO> Cheeses { get; set; }

        string _connString = null;
        public ShopContext(DbContextOptions<ShopContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var cheese1 = new CheeseDTO { Id = 1, Name = "Cheddar", Colour = "Light Yellow", PricePerKilo = 1 };
            var cheese2 = new CheeseDTO { Id = 2, Name = "Feta", Colour = "White", PricePerKilo = 1 };
            var cheese3 = new CheeseDTO { Id = 3, Name = "Gorgonzola", Colour = "White with Blue Pigment", PricePerKilo = 1 };
            var cheese4 = new CheeseDTO { Id = 4, Name = "Gouda", Colour = "Light Yellow", PricePerKilo = 1 };
            var cheese5 = new CheeseDTO { Id = 5, Name = "Aarenwasser", Colour = "White", PricePerKilo = 8 };

            modelBuilder.Entity<CheeseDTO>().HasData(cheese1, cheese2, cheese3, cheese4, cheese5);
            base.OnModelCreating(modelBuilder);
        }
    }
}
