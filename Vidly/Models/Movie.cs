using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Xml.Linq;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        [Required]
        [Display(Name = "Genre")]
        public byte? GenreId { get; set; }

        public Genre? Genre { get; set; }

        [Required]
        [Display(Name = "Release Date")]
        public DateTime? ReleaseDate { get; set; }
        public DateTime? DateAdded { get; set; }

        [Required]
        [Display(Name = "Number In Stock")]
        [Range(1,20)]
        public int? NumberInStock { get; set; }


    }


}
