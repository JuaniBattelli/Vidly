﻿using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        
        public Genre Genre { get; set; }
        public byte GenreId { get; set; }

        [Display(Name = "Release Date")]
        public DateTime? ReleaseDate { get; set; }
        public DateTime? DateAdded { get; set; }

        [Display(Name = "Number In Stock")]
        public int NumberInStock { get; set; }


    }


}
