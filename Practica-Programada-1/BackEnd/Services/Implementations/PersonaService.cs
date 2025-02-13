using BackEnd.Services.Interfaces;
using DAL.Implementations;
using DAL.Interfaces;
using Entities.Entities;

namespace BackEnd.Services.Implementations
{
    public class PersonaService : IPersonaService
    {
        private IUnidadDeTrabajo _unidadDeTrabajo;

        public PersonaService (IUnidadDeTrabajo unidadDeTrabajo)
        {
            _unidadDeTrabajo = unidadDeTrabajo;
        }

        void IPersonaService.AddPersona(Persona persona)
        {
            _unidadDeTrabajo.PersonaDAL.Add(persona);
            _unidadDeTrabajo.Complete();
        }

        void IPersonaService.DeletePersona(Persona persona)
        {
            throw new NotImplementedException();
        }

        List<Persona> IPersonaService.GetAllPersonas()
        {
            throw new NotImplementedException();
        }

        void IPersonaService.UpdatePersona(Persona persona)
        {
            _unidadDeTrabajo.PersonaDAL.Update(persona);
            _unidadDeTrabajo.Complete();
        }
    }
}
