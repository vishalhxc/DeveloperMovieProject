using System.Collections.Generic;
using DeveloperMovieProject.Models;

namespace DeveloperMovieProject.ViewModels
{
    public class HomeViewModel
    {
        public Genre Genre { get; set; }

        public IEnumerable<Movie> Movies { get; set; }
    }
}
