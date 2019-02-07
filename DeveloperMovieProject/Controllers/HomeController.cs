using System.Threading.Tasks;
using DeveloperMovieProject.Data;
using Microsoft.AspNetCore.Mvc;

namespace DeveloperMovieProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDeveloperMovieProjectRepository _repository;

        public HomeController(IDeveloperMovieProjectRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            var homeView = _repository.GetHomeView();
            return View(homeView);
        }
    }
}
