using MovieShopDAL.Context;
using MovieShopDAL.DomainModel;
using MoviesShopDAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieShopDAL.Repository
{
    public class MovieRepository : IRepository<Movie>
    {
        MovieShopContextDB ctx;

        public MovieRepository(MovieShopContextDB context)
        {
            ctx = context;
        }

        public Movie Add(Movie movie) {
            
                ctx.Genres.Attach(movie.Genre);
                //Create the queries
                ctx.Movies.Add(movie);
                //Execute the queries
                ctx.SaveChanges();
                return movie;
            
        }

        public List<Movie> ReadAll()
        {
            
                return ctx.Movies.Include("Genre").ToList();
            
        }

        public Movie Read(int movieId)
        {
            
                return ctx.Movies.Include("Genre").FirstOrDefault(item => item.Id == movieId);
            
        }

        public Movie Update(Movie movie)
        {
            
                var movieDB = ctx.Movies.FirstOrDefault(item => item.Id == movie.Id);
                movieDB.Genre = ctx.Genres.FirstOrDefault(item => item.Id == movie.Genre.Id);
                movieDB.imageURL = movie.imageURL;
                movieDB.Price = movie.Price;
                movieDB.Title = movie.Title;
                movieDB.trailerURL = movie.trailerURL;
                movieDB.Year = movie.Year;
                ctx.SaveChanges();
                return movie;
            
        }

        public Movie Delete(Movie movie)
        {
            
                var movieDB = ctx.Movies.FirstOrDefault(item => item.Id == movie.Id);
                ctx.Movies.Remove(movieDB);
                ctx.SaveChanges();
                return movie;
            
        }

    }
}
