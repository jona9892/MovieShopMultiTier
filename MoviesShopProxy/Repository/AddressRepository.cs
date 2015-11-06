using MoviesShopProxy.Context;
using MoviesShopProxy.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesShopProxy.Repository
{
    public class AddressRepository
    {
        public void Add(Adress address)
        {
            using (var ctx = new MovieShopContextDB())
            {
                //Create the queries
                ctx.Adresses.Add(address);

                //Execute the queries
                ctx.SaveChanges();
            }
        }

        public List<Adress> ReadAll()
        {
            using (var ctx = new MovieShopContextDB())
            {
                    return ctx.Adresses.ToList();
            }
        }

        public Adress Read(int addressID)
        {
            using (var ctx = new MovieShopContextDB())
            {
                return ctx.Adresses.FirstOrDefault(item => item.Id == addressID);
            }
        }

        public void Update(Adress address)
        {
            using (var ctx = new MovieShopContextDB())
            {
                var addressDB = ctx.Adresses.FirstOrDefault(item => item.Id == address.Id);
                addressDB.StreetName = address.StreetName;
                addressDB.StreetNumber = address.StreetNumber;
                addressDB.Zipcode = address.Zipcode;
                addressDB.Country = address.Country;
                ctx.SaveChanges();

            }
        }

        public void Delete(Adress address)
        {
            using (var ctx = new MovieShopContextDB())
            {
                var addressDB = ctx.Adresses.FirstOrDefault(item => item.Id == address.Id);
                ctx.Adresses.Remove(addressDB);
            }
        }

    }
}

