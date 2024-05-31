using CheeseApp.Server.Contracts;

namespace CheeseApp.Server
{
    public class Cheese : IProduct
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public float PricePerKilo { get; set; }
        public string? Colour { get; set; }
    }
}
