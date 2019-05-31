using AdotaPatos.DAO;
using AdotaPatos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdotaPatos.Controllers
{
    public class AnimalController : Controller
    {
        AnimalDAO animalDAO = new AnimalDAO();
        // GET: Animal
        public ActionResult Index()
        {
            var AnimalIndex = animalDAO.Listar();
            return View(AnimalIndex);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Animal animal)
        {
            animalDAO.Salvar(animal);
            return RedirectToAction(nameof(Index));
        }
        public ActionResult Edit()
        {
            return View();
        }
        
        public ActionResult Details( long AnimalId)
        {

            if (AnimalId == 0)
            {
                return HttpNotFound();
            }

            var AnimalDetails = animalDAO.PorId(AnimalId);
            return View(AnimalDetails);
        }
        public ActionResult Delete()
        {
            return View();
        }
    }
}