using System.Net;
using System.Threading.Tasks;
using AngelHack.Business.Inputs;
using AngelHack.Business.Interfaces;
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


        /// <summary>
        /// Seleciona todos os Pets
        /// </summary>
        /// <returns>Lista de Pets</returns>
        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> GetTodos()
        {
            var pet = await petBusiness.SelecionarTodosAsync();

            return Ok(pet);
        }

        /// <summary>
        /// Seleciona um pet por id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>A informação referente ao id do pet</returns>
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

        /// <summary>
        /// Seleciona todos os Pets que deram match  
        /// </summary>
        /// <returns>Lista de Pets com Match</returns>
        [HttpGet("Match")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> GetTodosComMatch()
        {
            var pet = await petBusiness.SelecionarTodosComMatch();

            return Ok(pet);
        }

        /// <summary>
        /// Inseri um novo pet
        /// </summary>
        /// <param name="petInput"></param>
        /// <returns>Os dados da pet cadastrado</returns>
        [HttpPost("Cadastro")]
        [ProducesResponseType((int)HttpStatusCode.Created)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> PostPet([FromBody] PetInput petInput)
        {

            var pet = await petBusiness.Inserir(petInput);
            if (pet == null)
                return BadRequest();

            return Created(nameof(GetPorId), pet);
        }

        /// <summary>
        /// Altera as informações do pet
        /// </summary>
        /// <param name="id"></param>
        /// <param name="petInput"></param>
        /// <returns>Os dados do pet alterado</returns>
        [HttpPut("Alterar/{id}")]
        [ProducesResponseType((int)HttpStatusCode.Accepted)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] PetInput petInput)
        {

            var pet = await petBusiness.Update(id, petInput);
            if (pet == null)
                return NotFound();

            return Accepted(nameof(GetPorId), pet);
        } 

    }
}