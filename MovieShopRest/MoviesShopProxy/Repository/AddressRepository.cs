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
    public class AddressRepository : IRepository<Adress>
    {
        MovieShopContextDB ctx;

        public AddressRepository(MovieShopContextDB context)
        {
            ctx = context;
        }
        public Adress Add(Adress address)
        {
            
                //Create the queries
                ctx.Adresses.Add(address);

                //Execute the queries
                ctx.SaveChanges();

                return address;
            
        }

        public List<Adress> ReadAll()
        {
            
                    return ctx.Adresses.ToList();
            
        }

        public Adress Read(int addressID)
        {
            
                return ctx.Adresses.FirstOrDefault(item => item.Id == addressID);
            
        }

        public Adress Update(Adress address)
        {
            
                var addressDB = ctx.Adresses.FirstOrDefault(item => item.Id == address.Id);
                addressDB.StreetName = address.StreetName;
                addressDB.StreetNumber = address.StreetNumber;
                addressDB.Zipcode = address.Zipcode;
                addressDB.Country = address.Country;
                ctx.SaveChanges();
                return address;

            
        }

        public Adress Delete(Adress address)
        {
            
                var addressDB = ctx.Adresses.FirstOrDefault(item => item.Id == address.Id);
                ctx.Adresses.Remove(addressDB);
                ctx.SaveChanges();
                return address;
            
        }

    }
}

