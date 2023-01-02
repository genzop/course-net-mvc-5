using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }
        public string Title
        {
            get
            {
                return Id == 0 ? "New Movie" : "Edit Movie";                
            }
        }

        public int? Id { get; set; }

        [Required(ErrorMessage = "The Name field is required.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The Release Date field is required.")]
        [Display(Name = "Release Date")]
        public DateTime? ReleaseDate { get; set; }        

        [Required(ErrorMessage = "The Number in Stock field is required.")]
        [Range(1, 20, ErrorMessage = "The field Number in Stock must be between 1 and 20.")]
        [Display(Name = "Number in Stock")]
        public int? NumberInStock { get; set; }

        [Required(ErrorMessage = "The Genre field is required.")]
        [Display(Name = "Genre")]
        public byte? GenreId { get; set; }
        
        public MovieFormViewModel()
        {
            Id = 0;
        }

        public MovieFormViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            ReleaseDate = movie.ReleaseDate;
            NumberInStock = movie.NumberInStock;
            GenreId = movie.GenreId;
        }
    }
}