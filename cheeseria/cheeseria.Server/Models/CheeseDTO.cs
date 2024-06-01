using CheeseApp.Server.Contracts;
using System.ComponentModel.DataAnnotations;

namespace CheeseApp.Server
{
    public class CheeseDTO : IProduct
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public float PricePerKilo { get; set; }
        public string? Colour { get; set; }
    }
}
