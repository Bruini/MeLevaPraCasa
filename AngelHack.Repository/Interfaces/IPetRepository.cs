﻿using AngelHack.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AngelHack.Repository.Interfaces
{
    public interface IPetRepository
    {
        Task<IEnumerable<Pet>> SelecionarTodosAsync();
        Task<Pet> SelecionarPorId(int id);
        Task<Pet> Inserir(Pet pet);
        Task<Pet> Update(int id, Pet pet);
    }
}