using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]

        public string Titre { get; set; }
        public int Vu {get; set;}
        public string Image {get; set;}

        public string Resume{get; set;}

        [Display(Name = "Date de sortie"), DataType(DataType.Date)]
        public DateTime Datedesortie { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$"), Required, StringLength(30)]
        public string Genre { get; set; }

        [Range(1, 10)]
        [Column(TypeName = "decimal(18, 2)")]
        public int Note { get; set; }

        [StringLength(60, MinimumLength = 1)]
        public string Phase { get; set; }

    }
}