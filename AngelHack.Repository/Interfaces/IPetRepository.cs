using AngelHack.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AngelHack.Repository.Interfaces
{
    public interface IPetRepository
    {
        Task<IEnumerable<Pet>> SelecionarTodosAsync();
        Task<Pet> SelecionarPorId(int id);
        Task<Pet> Inserir(Pet pet);
    }
}
