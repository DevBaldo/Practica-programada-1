using FrontEnd.Models;

namespace FrontEnd.Helpers.Interfaces
{
    public interface IPersonaHelper
    {

        List<PersonaViewModel> GetPersonas();

        PersonaViewModel GetPersona(int? id);
        PersonaViewModel Add(PersonaViewModel persona);
        PersonaViewModel Update(PersonaViewModel persona);
        void Delete(int id);
    }
}
