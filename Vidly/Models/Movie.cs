using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models  
{
    public class Movie
    {
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime DateAdded;

        public Movie()
        {
            DateAdded = DateTime.Now;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public Genre Genre { get; set; }

        
        [Display(Name = "Genre")]
        [Required]
        public byte GenreId { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Add/update numbers in stock")]
        public int NumberInStock { get; set; }
      

    }
}