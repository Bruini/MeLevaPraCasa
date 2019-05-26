using AngelHack.Business.Interfaces;
using AngelHack.Domain.Models;
using AngelHack.Repository.Interfaces;
using System.Collections.Generic;
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
            Pet newPet = new Pet(pet.Id, pet.Nome, pet.Idade, pet.Descricao, pet.Endereco, pet.NomeTutor, pet.Vacinado, pet.Castrado, pet.Match, pet.Imagem);

            return await petRepository.Inserir(newPet);

        }

        public async Task<Pet> SelecionarPorId(int id)
        {
            var petExiste = await petRepository.SelecionarPorId(id);
            if (petExiste == null)
                return null;
            return await petRepository.SelecionarPorId(id);
        }

        public async Task<IEnumerable<Pet>> SelecionarTodosAsync()
        {
            return await petRepository.SelecionarTodosAsync();
        }

        public async Task<Pet> Update(int id, Pet pet)
        {
            var petExiste = await petRepository.SelecionarPorId(id);
            if (petExiste == null)
                return null;

            Pet newPet = new Pet(pet.Id, pet.Nome, pet.Idade, pet.Descricao, pet.Endereco, pet.NomeTutor, pet.Vacinado, pet.Castrado, pet.Match, pet.Imagem);

            return await petRepository.Update(id, newPet);
        }
    }
}
