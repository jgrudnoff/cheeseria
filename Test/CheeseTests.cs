using CheeseApp.Server;
using CheeseApp.Server.DataRepositories;
using CheeseApp.Server.Services;

namespace Test
{
    [TestClass]
    public class CheeseTests {

        CheeseService cheeseService;

        [TestInitialize]
        public void Setup()
        {
            cheeseService = new CheeseService(new MockCheeseRepository());
        }
        

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Parameter value out of range.")]

        public async Task TestGetCheeseById_ParameterOutOfRange()
        {
            var test = await cheeseService.GetCheeseById(-1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Parameter value out of range.")]

        public async Task TestUpdateCheese_ParameterOutOfRange()
        {
            var cheese = new CheeseDTO { Name = "Cheese1", PricePerKilo = 10, Colour = "Red", CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now };
            cheeseService.UpdateCheese(-1, cheese);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Parameter value out of range.")]

        public async Task TestDeleteCheese_ParameterOutOfRange()
        {
            cheeseService.DeleteCheese(-1);
        }

    }
}