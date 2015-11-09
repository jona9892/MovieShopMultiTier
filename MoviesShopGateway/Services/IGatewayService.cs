using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesShopGateway.Services
{
    public interface IGatewayService<T>
    {
        List<T> ReadAll();
        T Read(int id);
        T Add(T t);
        T Update(T t);
        T Delete(T t);
    }
}
