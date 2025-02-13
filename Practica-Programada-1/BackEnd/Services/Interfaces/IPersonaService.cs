using Entities.Entities;

namespace BackEnd.Services.Interfaces
{
    public interface IPersonaService
    {
        void AddPersona(Persona persona);
        void UpdatePersona(Persona persona);
        void DeletePersona(Persona persona);
        List<Persona> GetAllPersonas();
    }
}
