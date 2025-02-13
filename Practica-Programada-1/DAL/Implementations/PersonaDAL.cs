using DAL.Interfaces;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementations
{
    public class PersonaDAL : DALGenericoImpl<Persona>, IPersonaDAL
    {
        private GestionPersonasContext _context;

        public PersonaDAL(GestionPersonasContext context) : base(context)
        {
            _context = context;
        }

    }
}
