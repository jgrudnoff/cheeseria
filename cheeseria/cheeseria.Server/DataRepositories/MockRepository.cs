using Mine4DData.Contracts;

namespace CheeseApp.Server.DataRepositories
{
    public class MockRepository : IDataRepository
    {

        public IEnumerable<Cheese> GetCheese()
        {
            return new List<Cheese>()
            {
                new Cheese() {Id = 1, Name = "Cheddar", PricePerKilo =  10, Colour = "Red"},
                new Cheese() {Id = 2, Name = "Gorgonzola", PricePerKilo = 15, Colour = "Yellow"},
                new Cheese() {Id = 3, Name = "Gouda", PricePerKilo = 13, Colour = "Green"},
                new Cheese() {Id = 4, Name = "Feta", PricePerKilo = 20, Colour = "Blue"},
                new Cheese() {Id = 5, Name = "Aarenwasser", PricePerKilo = 400, Colour = "Purple"}
            };
        }
    }
}
