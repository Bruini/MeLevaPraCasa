using AngelHack.Business.Inputs;
using AngelHack.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AngelHack.Business.Interfaces
{
    public interface IPetBusiness
    {
        Task<IEnumerable<Pet>> SelecionarTodosAsync();
        Task<Pet> SelecionarPorId(int id);
        Task<Pet> Inserir(PetInput petInput);

        Task<Pet> Update(int id, PetInput petInput);
    }
}
