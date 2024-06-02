using CheeseApp.Server.Contracts;

namespace CheeseApp.Server.Services
{
    public class CheeseService : ICheeseService
    {

        ICheeseRepository _cheeseRepository;
        public CheeseService(ICheeseRepository cheeseRepository )
        {
            _cheeseRepository = cheeseRepository;
        }

        public async Task<CheeseDTO> GetCheeseById(int cheeseId)
        {
            if (cheeseId <= 0)
                throw new ArgumentOutOfRangeException();

            var cheese = await _cheeseRepository.GetCheeseById(cheeseId);
            return cheese;
        }

        public async Task<IEnumerable<CheeseDTO>> GetCheeses()
        {
            return await _cheeseRepository.GetCheeses();
        }

        public Task<CheeseDTO> InsertCheese(CheeseDTO cheese)
        {
            return _cheeseRepository.InsertCheese(cheese);
        }

        public void UpdateCheese(int cheeseId, CheeseDTO cheese)
        {
            if (cheeseId <= 0)
                throw new ArgumentOutOfRangeException();

            _cheeseRepository.UpdateCheese(cheeseId, cheese);
        }

        public void DeleteCheese(int cheeseId)
        {
            if (cheeseId <= 0)
                throw new ArgumentOutOfRangeException();

            _cheeseRepository.DeleteCheese(cheeseId);
        }
    }
}