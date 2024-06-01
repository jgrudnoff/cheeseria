﻿using Microsoft.AspNetCore.Mvc;

namespace CheeseApp.Server.Contracts
{
    public interface ICheeseService
    {
        Task<IEnumerable<CheeseDTO>> GetCheeses();
        Task<CheeseDTO> GetCheeseById(int cheeseId);
        Task<CheeseDTO> InsertCheese(CheeseDTO student);
        void DeleteCheese(int cheeseId);
        void UpdateCheese(int cheeseId, CheeseDTO cheese);
    }
}