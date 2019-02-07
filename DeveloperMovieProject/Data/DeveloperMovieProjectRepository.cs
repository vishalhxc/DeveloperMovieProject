using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DeveloperMovieProject.Models;
using DeveloperMovieProject.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace DeveloperMovieProject.Data
{
    public class DeveloperMovieProjectRepository : IDeveloperMovieProjectRepository
    {
        private readonly DeveloperMovieProjectDbContext _context;

        public DeveloperMovieProjectRepository(DeveloperMovieProjectDbContext context)
        {
            _context = context;
        }
        public void AddGenre(Genre genre)
        {
            throw new NotImplementedException();
        }

        public void AddMovie(Movie movie)
        {
            throw new NotImplementedException();
        }

        public void DeleteGenre(Genre genre)
        {
            throw new NotImplementedException();
        }

        public void DeleteMovie(Movie movie)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Genre> GetGenres()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<HomeViewModel> GetHomeView()
        {
            var genres = _context.Genres
                .OrderBy(g => g.Name)
                .ToList();

            var homeView = new List<HomeViewModel>();
            foreach(Genre genre in genres)
            {
                var movies = _context.Movies
                    .OrderByDescending(m => m.Year)
                    .Where(m => m.Genre == genre)
                    .Take(5);

                homeView.Add(new HomeViewModel
                {
                    Genre = genre,
                    Movies = movies
                });
            }
            return homeView;
        }

        public IEnumerable<Movie> GetMovies()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> GetMoviesByGenre(Genre genre)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Movie>> GetMoviesSearch(string query)
        {
            return await _context.Movies
                .Where(m => m.Title.Contains(query))
                .ToListAsync();
        }

        public bool SaveAll()
        {
            throw new NotImplementedException();
        }

        public void UpdateGenre(Genre genre)
        {
            throw new NotImplementedException();
        }

        public void UpdateMovie(Movie movie)
        {
            throw new NotImplementedException();
        }
    }
}
