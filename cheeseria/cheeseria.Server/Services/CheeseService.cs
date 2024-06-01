using CheeseApp.Server.Contracts;

namespace CheeseApp.Server.Services
{
    public class CheeseService : ICheeseService
    {
        ICheeseRepository _cheeseRepository;
        public CheeseService(ILogger<CheeseService> logger, ICheeseRepository cheeseRepository )
        {
            _cheeseRepository = cheeseRepository;
        }

        public async Task<CheeseDTO> GetCheeseById(int cheeseId)
        {
            return await _cheeseRepository.GetCheeseById(cheeseId);
        }

        public async Task<IEnumerable<CheeseDTO>> GetCheeses()
        {
            return await _cheeseRepository.GetCheeses();
        }

        public Task<CheeseDTO> InsertCheese(CheeseDTO student)
        {
            return _cheeseRepository.InsertCheese(student);
        }

        public void UpdateCheese(int cheeseId, CheeseDTO cheese)
        {
            _cheeseRepository.UpdateCheese(cheeseId, cheese);
        }

        public void DeleteCheese(int cheeseId)
        {
            _cheeseRepository.DeleteCheese(cheeseId);
        }
    }
}