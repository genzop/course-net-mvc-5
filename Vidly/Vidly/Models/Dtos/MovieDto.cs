using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The Name field is required.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The Release Date field is required.")]        
        public DateTime ReleaseDate { get; set; }
        
        [Required(ErrorMessage = "The Number in Stock field is required.")]
        [Range(1, 20, ErrorMessage = "The field Number in Stock must be between 1 and 20.")]        
        public int NumberInStock { get; set; }

        [Required(ErrorMessage = "The Genre field is required.")]        
        public byte GenreId { get; set; }

        public Genre Genre { get; set; }
    }
}