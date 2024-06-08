using Microsoft.AspNetCore.Mvc;
using WebBaoDoi.Models;
using WebBaoDoi.Repository;
using WebBaoDoi.Areas.Identity.Data;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebBaoDoi.Controllers
{
    public class FacultiesController : Controller
    {
        private readonly IFacultyRepository _facultyRepository;
        public FacultiesController(IFacultyRepository facultyRepository) 
        {
            _facultyRepository = facultyRepository;
        }
        public IActionResult Index()
        {
            var faculties = _facultyRepository.GetAllFaculties();
            return View(faculties);
        }
        public IActionResult Create()
        {
            var faculties = _facultyRepository.GetAllFaculties();
            ViewBag.Faculties = new SelectList(faculties, "Id", "Name");
            return View();
        }
        public IActionResult Details()
        {
            var faculties = _facultyRepository.GetAllFaculties();
            if(faculties == null)
            {
                return NotFound();
            }
            return View(faculties);
        }
        public IActionResult Edit()
        {
            var faculties = _facultyRepository.GetAllFaculties();
            if(faculties == null)
            {
                return NotFound();
            }
            return View(faculties);
        }
        [HttpPost]
        public IActionResult Edit(Faculties faculties)
        {
                _facultyRepository.Edit(faculties);
                return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var faculties = _facultyRepository.GetById(id);
            if(faculties == null)
            {
                return NotFound();
            }
            return View(faculties);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _facultyRepository.Delete(id);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Create(Faculties faculties)
        {
                _facultyRepository.Add(faculties);
                return RedirectToAction("Index", new {faculties.id });
        }
    }
}
