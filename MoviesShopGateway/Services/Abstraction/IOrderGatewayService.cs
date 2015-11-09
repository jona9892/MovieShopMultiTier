using DomainModel.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesShopGateway.Services.Abstraction
{
    public interface IOrderGatewayService<T> : AbstractGatewayService<Order>
    {
        
    }
}
