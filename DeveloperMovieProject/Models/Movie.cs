using System.ComponentModel.DataAnnotations;

namespace DeveloperMovieProject.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        [Range(1850, 2150)]
        public int Year { get; set; }

        [Required]
        public Genre Genre { get; set; }
    }
}
