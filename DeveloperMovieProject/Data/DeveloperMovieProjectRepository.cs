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
            var genres = _context.Genres
                .OrderBy(g => g.Name)
                .ToArray();
            return genres;
        }

        public IEnumerable<HomeViewModel> GetHomeView()
        {
            var genres = _context.Genres
                .OrderBy(g => g.Name)
                .ToArray();

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
            var movies = _context.Movies
                .OrderByDescending(m => m.Year)
                .Take(25)
                .ToArray();
            return movies;
        }

        public IEnumerable<Movie> GetMoviesByGenre(int genreId)
        {
            var movies = _context.Movies
                .Where(m => m.Genre.Id == genreId)
                .OrderByDescending(m => m.Year)
                .Include(m => m.Genre)
                .Take(25)
                .ToArray();
            return movies;
        }

        public async Task<IEnumerable<Movie>> GetMoviesSearch(string query)
        {
            return await _context.Movies
                .Where(m => m.Title.Contains(query))
                .Take(25)
                .ToArrayAsync();
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
