using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AngelHack.Api.Inputs;
using AngelHack.Business.Interfaces;
using AngelHack.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AngelHack.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetController : ControllerBase
    {
        private readonly IPetBusiness petBusiness;

        public PetController(IPetBusiness petBusiness)
        {
            this.petBusiness = petBusiness;
        }

        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> GetTodos()
        {
            var pet = await petBusiness.SelecionarTodosAsync();

            return Ok(pet);
        }

        [HttpGet("{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> GetPorId([FromRoute] int id)
        {
            var pet = await petBusiness.SelecionarPorId(id);
            if (pet == null)
                return NotFound();

            return Ok(pet);
        }

        [HttpPost("Cadastro")]
        [ProducesResponseType((int)HttpStatusCode.Created)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> PostPet([FromBody] PetInput petInput)
        {
            Pet newPet = new Pet()
            {
                Id = petInput.Id,
                Nome = petInput.Nome,
                Descricao = petInput.Descricao,
                Idade = petInput.Idade,
                Endereco = petInput.Endereco,
                NomeTutor = petInput.NomeTutor,
                Castrado = petInput.Castrado,
                Vacinado = petInput.Vacinado,
                Imagem = petInput.Imagem
            };

            var pet = await petBusiness.Inserir(newPet);
            if (pet == null)
                return BadRequest();

            return CreatedAtRoute(nameof(GetPorId), pet);
        }

    }
}