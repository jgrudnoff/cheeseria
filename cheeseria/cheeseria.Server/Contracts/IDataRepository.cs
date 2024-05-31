using CheeseApp.Server;
using CheeseApp.Server.Contracts;

namespace Mine4DData.Contracts
{
    public interface IDataRepository
    {
        IEnumerable<Cheese> GetCheese();
    }
}