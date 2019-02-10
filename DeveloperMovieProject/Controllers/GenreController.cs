using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DeveloperMovieProject.Data;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DeveloperMovieProject.Controllers
{
    public class GenreController : Controller
    {
        private readonly IDeveloperMovieProjectRepository _repository;

        public GenreController(IDeveloperMovieProjectRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            var genres = _repository.GetGenres();
            return View(genres);
        }
    }
}
