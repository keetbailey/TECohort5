using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GetExercises.Web.Models
{
    public class FilmSearchModel : Film
    {
        public string Genre { get; set; }
        public int? MinLength { get; set; }
        public int? MaxLength { get; set; }
    }
}