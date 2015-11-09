using DomainModel.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Movieshop.Models.ViewModels
{
    public class MovieViewModel
    {
        public MovieViewModel()
        {
            Genres = new List<Genre>();
        }
        public Movie Movie { get; set; }
        public IEnumerable<Genre> Genres { get; set; }
        
    }
}