using DAL.Interfaces;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementaciones
{
    public class PersonaDAL : IPersonaDAL
    {
        private GestionPersonasContext _context;

        public PersonaDAL(GestionPersonasContext context)
        {
            _context = context;
        }

        public bool AddPersona(Persona persona)
        {
            throw new NotImplementedException();
        }

        public bool UpdatePersona(Persona persona)
        {
            throw new NotImplementedException();
        }

        public bool DeletePersona(Persona persona) 
        {
            throw new NotImplementedException();
        }

        public List<Persona> GetAllPersona()
        {
            throw new NotImplementedException();
        }
    }
}
