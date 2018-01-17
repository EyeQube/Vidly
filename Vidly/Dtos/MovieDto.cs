using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.Dtos
{
    public class MovieDto
    {

        [DataType(DataType.Date)]
        public DateTime DateAdded;

        public MovieDto()   
        {
            DateAdded = DateTime.Now;
        }

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public Genre Genre { get; set; }


        [Required]
        public byte GenreId { get; set; }


        [Required]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }


        [Required]
        [Range(1, 20)]
        public int NumberInStock { get; set; }

    }
}