using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models  
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Genre { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dddd, MMMM dd, yyyy}")]
        public DateTime ReleaseDate { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dddd, MMMM dd, yyyy}")]
        public DateTime DateAdded { get; set; }

        public int NumberInStock { get; set; }  


    }
}