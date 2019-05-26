using AngelHack.Domain.Models;
using AngelHack.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AngelHack.Repository.Repos
{
    public class PetRepository : IPetRepository
    {
        public Task<Pet> Inserir(Pet pet)
        {
            throw new NotImplementedException();
        }

        public Task<Pet> SelecionarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Pet>> SelecionarTodosAsync()
        {
            throw new NotImplementedException();
        }
    }
}
