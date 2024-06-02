﻿namespace CheeseApp.Server.Contracts
{
    public interface IProduct
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
