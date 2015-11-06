using MoviesShopProxy.Context;
using MoviesShopProxy.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesShopProxy.Repository
{
    public class GenreRepository
    {
        public Genre Add(Genre genre)
        {
            using (var ctx = new MovieShopContextDB())
            {
                //Create the queries
                ctx.Genres.Add(genre);
                //Execute the queries
                ctx.SaveChanges();

                return genre;
            }
        }

        public List<Genre> ReadAll(bool asc = true)
        {
            using (var ctx = new MovieShopContextDB())
            {
                return ctx.Genres.ToList();

            }
        }

        public Genre Read(int genreID)
        {
            using (var ctx = new MovieShopContextDB())
            {

                return ctx.Genres.FirstOrDefault(item => item.Id == genreID);
            }
        }

        public Genre Update(Genre genre)
        {
            using (var ctx = new MovieShopContextDB())
            {
                var genreDB = ctx.Genres.FirstOrDefault(item => item.Id == genre.Id);
                genreDB.Name = genre.Name;
                genreDB.Movies = genre.Movies;
                ctx.SaveChanges();
                return genre;
            }
        }

        public Genre Delete(Genre genre)
        {
            using (var ctx = new MovieShopContextDB())
            {
                var genreDB = ctx.Genres.FirstOrDefault(item => item.Id == genre.Id);
                ctx.Genres.Remove(genreDB);
                ctx.SaveChanges();
                return genre;
            }
        }
    }
}
