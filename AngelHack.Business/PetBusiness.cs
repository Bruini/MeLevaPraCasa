using AngelHack.Business.Inputs;
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

        public async Task<Pet> Inserir(PetInput petInput)
        {
            Pet newPet = new Pet(petInput.Nome, petInput.Idade, petInput.Descricao, petInput.NomeTutor, petInput.Vacinado, petInput.Castrado, petInput.Match, petInput.Imagem, petInput.Bairro, petInput.Cidade, petInput.Estado);

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

        public async Task<Pet> Update(int id, PetInput petInput)
        {
            var petExiste = await petRepository.SelecionarPorId(id);
            if (petExiste == null)
                return null;

            Pet newPet = new Pet(petInput.Nome, petInput.Idade, petInput.Descricao, petInput.NomeTutor, petInput.Vacinado, petInput.Castrado, petInput.Match, petInput.Imagem, petInput.Bairro, petInput.Cidade, petInput.Estado);

            await petRepository.Update(id, newPet);

            return await petRepository.SelecionarPorId(id);
        }
    }
}
