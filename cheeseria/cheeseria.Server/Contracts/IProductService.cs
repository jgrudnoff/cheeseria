namespace CheeseApp.Server.Contracts
{
    public interface IProductService
    {
        IProduct GetProduct(int id);
        IEnumerable<IProduct> GetAllProducts();

    }
}
