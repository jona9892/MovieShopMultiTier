using MovieShopDAL.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MovieShopDTO
{
    [DataContract(IsReference=true)]
    public class OrderDTO
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public virtual Customer Customer { get; set; }

        [DataMember]
        public virtual Movie Movie { get; set; }
        [DataMember]
        public DateTime Date { get; set; }
    }
}
