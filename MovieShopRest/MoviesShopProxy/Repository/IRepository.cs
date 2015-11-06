using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesShopDAL.Repository
{
    public interface IRepository<T>
    {
        List<T> ReadAll();
        T Add(T t);
        T Read(int id);
        T Update(T t);
        T Delete(T t);
    }
}
