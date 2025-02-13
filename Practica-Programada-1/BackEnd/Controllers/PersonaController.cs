using BackEnd.DTO;
using BackEnd.Services.Interfaces;
using Entities.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {

        IPersonaService _personaService;

        public PersonaController(IPersonaService personaService)
        {
            _personaService = personaService;
        }

        // GET: api/<PersonaController>
        [HttpGet]
        public IEnumerable<PersonaDTO> Get()
        {
            return _personaService.GetAllPersonas();
        }

        // GET api/<PersonaController>/5
        [HttpGet("{id}")]
        public PersonaDTO Get(int id)
        {
            return _personaService.GetPersonaById(id);
        }

        // POST api/<PersonaController>
        [HttpPost]
        public void Post([FromBody] PersonaDTO persona)
        {
            _personaService.AddPersona(persona);
        }

        // PUT api/<PersonaController>/5
        [HttpPut]
        public void Put([FromBody] PersonaDTO persona)
        {
            _personaService.UpdatePersona(persona);
        }

        // DELETE api/<PersonaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _personaService.DeletePersona(id);
        }
    }
}
