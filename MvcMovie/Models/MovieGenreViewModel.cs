using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcMovie.Models
{
    public class MovieGenreViewModel
    {
        public List<Movie> Movies { get; set; }  //List of movies
        public SelectList Genres { get; set; }   //Select with distinct genres
        public string MovieGenre { get; set; }   //The genre that the user search for
        public string SearchString { get; set; } //The movie name user search for
    }
}