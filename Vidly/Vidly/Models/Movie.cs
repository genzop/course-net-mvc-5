using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The Name field is required.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The Release Date field is required.")]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }
        
        public DateTime AddedDate { get; set; }

        [Required(ErrorMessage = "The Number in Stock field is required.")]
        [Range(1, 20, ErrorMessage = "The field Number in Stock must be between 1 and 20.")]
        [Display(Name = "Number in Stock")]
        public int NumberInStock { get; set; }
               
        public int NumberAvailable { get; set; }

        [Required(ErrorMessage = "The Genre field is required.")]
        [Display(Name = "Genre")]
        public byte GenreId { get; set; }

        public Genre Genre { get; set; }
    }
}