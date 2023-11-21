using Laboratorium3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Laboratorium3.Controllers
{
    public class ComputerController : Controller
    {
        private readonly IComputerService _ComputerService;


        public ComputerController(IComputerService ComputerService)
        {
            _ComputerService = ComputerService;
        }
        public IActionResult Index()
        {
            return View(_ComputerService.FindAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Computer model)
        {
            if (ModelState.IsValid) // nie ma jawnego powiązania ale sprawdza czy model istenieje
            {
                _ComputerService.Add(model);
                // zapamietaj kontakt

                return RedirectToAction("Index");
            }
            return View();

        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            return View(_ComputerService.FindById(id));
        }
        [HttpPost]
        public IActionResult Details(Computer model)
        {
            if (ModelState.IsValid)
            {


                return RedirectToAction("Index");
            }
            return View();

        }


        [HttpGet]
        public IActionResult Update(int id)
        {
            return View(_ComputerService.FindById(id));
        }
        [HttpPost]
        public IActionResult Update(Computer model)
        {
            if (ModelState.IsValid)
            {
                _ComputerService.Update(model);
                return RedirectToAction("Index");
            }
            return View();
        }



        [HttpGet]
        public IActionResult Delete(int id)
        {
            return View(_ComputerService.FindById(id));
        }
        [HttpPost]
        public IActionResult Delete(Computer model)
        {
            var ComputerToDelete = _ComputerService.FindById(model.Id);

            if (ComputerToDelete != null)
            {
                _ComputerService.DeleteById(ComputerToDelete);
                return RedirectToAction("Index");
            }

            return NotFound(); // Możesz obsłużyć sytuację, gdy Computer nie istnieje.


        }


    }
}
