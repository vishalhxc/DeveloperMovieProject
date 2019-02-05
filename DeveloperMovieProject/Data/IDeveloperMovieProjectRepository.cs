using System.Collections.Generic;
using DeveloperMovieProject.Models;
namespace DeveloperMovieProject.Data
{
    public interface IDeveloperMovieProjectRepository
    {
        void AddMovie(Movie movie);
        void AddGenre(Genre genre);
        IEnumerable<Genre> GetGenres();
        IEnumerable<Movie> GetMovies();
        IEnumerable<Movie> GetMoviesByGenre(Genre genre);
        void UpdateMovie(Movie movie);
        void UpdateGenre(Genre genre);
        void DeleteMovie(Movie movie);
        void DeleteGenre(Genre genre);
        bool SaveAll();
    }
}
