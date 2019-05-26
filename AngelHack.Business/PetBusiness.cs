using AngelHack.Business.Interfaces;
using AngelHack.Domain.Models;
using AngelHack.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AngelHack.Business
{
    public class PetBusiness : IPetBusiness
    {
        private readonly IPetRepository petRepository;

        public PetBusiness(IPetRepository petRepository)
        {
            this.petRepository = petRepository;
        }

        public async Task<Pet> Inserir(Pet pet)
        {
            Pet newPet = new Pet(pet.Id, pet.Nome, pet.Idade, pet.Descricao, pet.Endereco, pet.NomeTutor, pet.Vacinado, pet.Castrado, pet.Imagem);

            return await petRepository.Inserir(newPet);

        }

        public async Task<Pet> SelecionarPorId(int id)
        {
            return await petRepository.SelecionarPorId(id);
        }

        public async Task<IEnumerable<Pet>> SelecionarTodosAsync()
        {
            return await petRepository.SelecionarTodosAsync();
        }
    }
}
