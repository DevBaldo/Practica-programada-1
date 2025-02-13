using FrontEnd.ApiModels;
using FrontEnd.Helpers.Interfaces;
using FrontEnd.Models;
using Newtonsoft.Json;

namespace FrontEnd.Helpers.Implementations
{
    public class PersonaHelper : IPersonaHelper
    {
        IServiceRepository _ServiceRepository;

        PersonaViewModel Convertir(PersonaAPI persona)
        {
            PersonaViewModel personaViewModel = new PersonaViewModel
            {
                Id = persona.Id,
                PersonaName = persona.PersonaName
            };
            return personaViewModel;
        }


        public PersonaHelper(IServiceRepository serviceRepository)
        {
            _ServiceRepository = serviceRepository;
        }

        public PersonaViewModel Add(PersonaViewModel persona)
        {
            HttpResponseMessage response = _ServiceRepository.PostResponse("api/Persona", persona);
            if (response.IsSuccessStatusCode)
            {

                var content = response.Content.ReadAsStringAsync().Result;
            }
            return persona;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<PersonaViewModel> GetPersonas()
        {
            HttpResponseMessage responseMessage = _ServiceRepository.GetResponse("api/Persona");
            List<PersonaAPI> personas = new List<PersonaAPI>();
            if (responseMessage != null)
            {
                var content = responseMessage.Content.ReadAsStringAsync().Result;
                personas = JsonConvert.DeserializeObject<List<PersonaAPI>>(content);
            }
            List<PersonaViewModel> lista = new List<PersonaViewModel>();
            foreach (var persona in personas)
            {
                lista.Add(Convertir(persona));
            }   
            return lista;
        }

        public PersonaViewModel GetPersona(int? id)
        {
            HttpResponseMessage responseMessage = _ServiceRepository.GetResponse("api/Persona/" + id.ToString());
            PersonaAPI persona = new PersonaAPI();
            if (responseMessage != null)
            {
                var content = responseMessage.Content.ReadAsStringAsync().Result;
                persona = JsonConvert.DeserializeObject<PersonaAPI>(content);
            }

            PersonaViewModel resultado = Convertir(persona);


            return resultado;
        }

        public PersonaViewModel Update(PersonaViewModel persona)
        {
            throw new NotImplementedException();
        }
    }
}
