using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DeveloperMovieProject.Data;
using DeveloperMovieProject.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DeveloperMovieProject.Controllers
{
    public class MovieController : Controller
    {
        private readonly IDeveloperMovieProjectRepository _repository;

        public MovieController(IDeveloperMovieProjectRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            var movies = _repository.GetMovies();
            ViewData["Title"] = $"Top {movies.Count()}";
            return View(movies);
        }

        [HttpGet]
        [Route("/Movie/Genre/{id}")]
        public IActionResult Index(int id)
        {
            var movies = _repository.GetMoviesByGenre(id);
            ViewData["Title"] = $"Top {movies.Count()} {movies.FirstOrDefault().Genre.Name}";
            return View(movies);
        }

        [HttpGet]
        public async Task<IActionResult> Search()
        {
            var movies = await _repository.GetMoviesSearch("");
            return View(movies);
        }

        [HttpGet]
        [Route("/Movie/Search/{query}")]
        public async Task<JsonResult> Search(string query)
        {
            var movies = await _repository.GetMoviesSearch(query);
            return Json(movies);
        }
    }
}
