using FrontEnd.Helpers.Interfaces;
using FrontEnd.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FrontEnd.Controllers
{
    public class PersonaController : Controller
    {

        IPersonaHelper _personaHelper;

        public PersonaController(IPersonaHelper personaHelper)
        {
            _personaHelper = personaHelper;
        }

        // GET: PersonaController
        public ActionResult Index()
        {
            var result = _personaHelper.GetPersonas();
            return View(result);
        }

        // GET: PersonaController/Details/5
        public ActionResult Details(int id)
        {
            var result = _personaHelper.GetPersona(id);
            return View(result);
        }

        // GET: PersonaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PersonaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PersonaViewModel persona)
        {
            try
            {
                _personaHelper.Add(persona);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PersonaController/Edit/5
        public ActionResult Edit(int id)
        {
            var persona = _personaHelper.GetPersona(id);
            if (persona == null)
            {
                return NotFound();
            }
            return View(persona);
        }

        // POST: PersonaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, PersonaViewModel persona)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _personaHelper.Update(persona);
                    return RedirectToAction(nameof(Index));
                }
                return View(persona);
            }
            catch
            {
                return View(persona);
            }
        }

        // GET: PersonaController/Delete/5
        public ActionResult Delete(int id)
        {
            var persona = _personaHelper.GetPersona(id);
            if (persona == null)
            {
                return NotFound();
            }
            return View(persona);
        }

        // POST: PersonaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                _personaHelper.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return RedirectToAction(nameof(Delete), new { id });
            }
        }
    }
}
