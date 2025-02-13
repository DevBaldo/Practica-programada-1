using BackEnd.DTO;
using Entities.Entities;

namespace BackEnd.Services.Interfaces
{
    public interface IPersonaService
    {
        void AddPersona(PersonaDTO persona);
        void UpdatePersona(PersonaDTO persona);
        void DeletePersona(int id);
        List<PersonaDTO> GetAllPersonas();

        PersonaDTO GetPersonaById(int id);
    }
}
