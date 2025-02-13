using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IPersonaDAL
    {
        bool AddPersona(Persona persona);
        bool UpdatePersona(Persona persona);
        bool DeletePersona(Persona persona);
        List<Persona> GetAllPersona();
    }
}
