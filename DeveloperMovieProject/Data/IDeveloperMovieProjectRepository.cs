using System.Collections.Generic;
using System.Threading.Tasks;
using DeveloperMovieProject.Models;
using DeveloperMovieProject.ViewModels;

namespace DeveloperMovieProject.Data
{
    public interface IDeveloperMovieProjectRepository
    {
        void AddMovie(Movie movie);
        void AddGenre(Genre genre);
        IEnumerable<HomeViewModel> GetHomeView();
        IEnumerable<Genre> GetGenres();
        IEnumerable<Movie> GetMovies();
        IEnumerable<Movie> GetMoviesByGenre(int genreId);
        Task<IEnumerable<Movie>> GetMoviesSearch(string query);
        void UpdateMovie(Movie movie);
        void UpdateGenre(Genre genre);
        void DeleteMovie(Movie movie);
        void DeleteGenre(Genre genre);
        bool SaveAll();
    }
}
