using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesShopGateway.Services.Abstraction
{
    public interface AbstractGatewayService<T>
    {
        IEnumerable<T> ReadAll();
        T Read(int id);
        T Add(T t);
        T Update(T t);
        T Delete(T t);
    }
}
