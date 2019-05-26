using AngelHack.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AngelHack.Business.Interfaces
{
    public interface IPetBusiness
    {
        Task<IEnumerable<Pet>> SelecionarTodosAsync();
        Task<Pet> SelecionarPorId(int id);
        Task<Pet> Inserir(Pet pet);

        Task<Pet> Update(int id, Pet pet);
    }
}
