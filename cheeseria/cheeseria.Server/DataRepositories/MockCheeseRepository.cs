using CheeseApp.Server.Contracts;

namespace CheeseApp.Server.DataRepositories
{
    public class MockCheeseRepository : ICheeseRepository
    {
        public void DeleteCheese(int cheeseId)
        {
            return;
        }

        public Task<CheeseDTO> GetCheeseById(int cheeseId)
        {
            return Task.FromResult(new CheeseDTO { Id = cheeseId, Name = "Cheese1", PricePerKilo = 10, Colour = "Red", CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now });
        }

        public Task<IEnumerable<CheeseDTO>> GetCheeses()
        {
            throw new NotImplementedException();
        }

        public Task<CheeseDTO> InsertCheese(CheeseDTO cheese)
        {
            return Task.FromResult(cheese);
        }

        public void UpdateCheese(int cheeseId, CheeseDTO cheese)
        {
            return;
        }
    }
}
