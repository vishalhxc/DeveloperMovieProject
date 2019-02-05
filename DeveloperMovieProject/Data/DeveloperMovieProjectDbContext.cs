using DeveloperMovieProject.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DeveloperMovieProject.Data
{
    public class DeveloperMovieProjectDbContext : IdentityDbContext<AdminMovieUser>
    {
        public DeveloperMovieProjectDbContext(DbContextOptions<DeveloperMovieProjectDbContext> options) : base(options)
        {

        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }
    }
}
