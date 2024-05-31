using CheeseApp.Server.Contracts;
using Mine4DData.Contracts;

namespace CheeseApp.Server.Services
{
    public class CheeseService : IProductService
    {
        IDataRepository _dataRepository;
        public CheeseService(ILogger<CheeseService> logger, IDataRepository dataRepository )
        {
            _dataRepository = dataRepository;
        }

        IEnumerable<IProduct> IProductService.GetAllProducts()
        {
            return _dataRepository.GetCheese();
        }

        IProduct IProductService.GetProduct(int id)
        {
            throw new NotImplementedException();
        }
    }
}