using AngelHack.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AngelHack.Business.Interfaces
{
    public interface IPetBusiness
    {
        Task<IEnumerable<Pet>> SelecionarTodosAsync();
        Task<Pet> SelecionarPorId(int id);
        Task<Pet> Inserir(Pet pet);
    }
}
