using _12_MvcCoreEnfermosEF.Models;
using _12_MvcCoreEnfermosEF.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace _12_MvcCoreEnfermosEF.Controllers
{
    public class EnfermoController : Controller
    {

        private RepositoryEnfermo repo;

        public EnfermoController(RepositoryEnfermo repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            List<Enfermo> enfermos = this.repo.GetEnfermos();
            return View(enfermos);
        }

        public IActionResult Details(int inscripcion)
        {
            Enfermo enfermo = this.repo.FindEnfermo(inscripcion);
            return View(enfermo);
        }
    }
}
