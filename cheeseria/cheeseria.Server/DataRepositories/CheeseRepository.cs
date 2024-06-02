using CheeseApp.Server;
using Microsoft.EntityFrameworkCore;
using CheeseApp.Server.Contracts;

namespace cheeseria.Server.DataRepositories
{

    public class CheeseRepository : ICheeseRepository, IDisposable
    {
        private ShopContext context;

        public CheeseRepository(ShopContext context)
        {
            this.context = context;
            context.Database.EnsureCreated();

        }

        public async Task<IEnumerable<CheeseDTO>> GetCheeses()
        {
            return await context.Cheeses.ToListAsync();
        }

        public async Task<CheeseDTO> GetCheeseById(int id)
        {
            return await context.Cheeses.FindAsync(id);
        }

        public async Task<CheeseDTO> InsertCheese(CheeseDTO cheese)
        {
            cheese.ModifiedDate = DateTime.Now;
            cheese.CreatedDate = DateTime.Now;
            context.Cheeses.Add(cheese);
            await context.SaveChangesAsync();
            return cheese;
        }

        public void DeleteCheese(int cheeseID)
        {
            CheeseDTO cheese = context.Cheeses.Find(cheeseID);
            context.Cheeses.Remove(cheese);
            context.SaveChanges();
        }

        public void UpdateCheese(int cheeseId, CheeseDTO cheese)
        {
            var entity = context.Cheeses.FirstOrDefault(item => item.Id == cheeseId);
            if (entity != null)
            {
                entity.Name = cheese.Name;
                entity.Colour = cheese.Colour;
                entity.PricePerKilo = cheese.PricePerKilo;
                entity.ModifiedDate = DateTime.Now;

                context.SaveChangesAsync();
            }
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}

