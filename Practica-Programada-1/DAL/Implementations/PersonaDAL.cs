using DAL.Interfaces;
using Entities.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
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


        public List<Persona> GetAllPersonas()
        {
            string query = "sp_GetAllPersonas";

            var resul = _context.Personas
                .FromSqlRaw(query);


            return resul.ToList();
        }

        public bool Add(Persona entity)
        {
            try
            {
                string sql = "exec [dbo].[sp_AddPersona] @Identificacion, @Nombre, @PrimerApellido, @SegundoApellido";

                var param = new SqlParameter[]
                {
            new SqlParameter()
            {
                ParameterName = "@Identificacion",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = entity.Identificacion
            },
            new SqlParameter()
            {
                ParameterName = "@Nombre",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = entity.Nombre
            },
            new SqlParameter()
            {
                ParameterName = "@PrimerApellido",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = entity.PrimerApellido
            },
            new SqlParameter()
            {
                ParameterName = "@SegundoApellido",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = entity.SegundoApellido
            }
                };
                _context
                    .Database
                    .ExecuteSqlRaw(sql, param);

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
