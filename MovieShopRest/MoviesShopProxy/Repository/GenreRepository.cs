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
    public class GenreRepository : IRepository<Genre>
    {
        MovieShopContextDB ctx;

        public GenreRepository(MovieShopContextDB context)
        {
            ctx = context;
        }
        public Genre Add(Genre genre)
        {
            
                //Create the queries
                ctx.Genres.Add(genre);
                //Execute the queries
                ctx.SaveChanges();

                return genre;
            
        }

        public List<Genre> ReadAll()
        {
            
                return ctx.Genres.ToList();
                
            
        }

        public Genre Read(int genreID)
        {
                return ctx.Genres.FirstOrDefault(item => item.Id == genreID);
            
        }

        public Genre Update(Genre genre)
        {
                var genreDB = ctx.Genres.FirstOrDefault(item => item.Id == genre.Id);
                genreDB.Name = genre.Name;
                //genreDB.Movies = genre.Movies;
                ctx.SaveChanges();
                return genre;
            
        }

        public Genre Delete(Genre genre)
        {
                var genreDB = ctx.Genres.FirstOrDefault(item => item.Id == genre.Id);
                ctx.Genres.Remove(genreDB);
                ctx.SaveChanges();
                return genre;
            
        }
    }
}
