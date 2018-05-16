using System.Collections.Generic;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class RandomMovieViewModel
    {
        public List<Movie> Movies { get; set; }
        public RandomMovieViewModel()
        {
            Movies = new List<Movie>();
        }
    }
}