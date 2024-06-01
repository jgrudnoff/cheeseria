using CheeseApp.Server.Contracts;

namespace CheeseApp.Server.DataRepositories
{
    public class MockCheeseRepository : ICheeseRepository
    {
        public void DeleteCheese(int cheeseId)
        {
            throw new NotImplementedException();
        }

        public Task<CheeseDTO> GetCheeseById(int cheeseId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CheeseDTO>> GetCheeses()
        {
            throw new NotImplementedException();
        }

        public Task<CheeseDTO> InsertCheese(CheeseDTO cheese)
        {
            throw new NotImplementedException();
        }

        public void UpdateCheese(int cheeseId, CheeseDTO cheese)
        {
            throw new NotImplementedException();
        }
    }
}
