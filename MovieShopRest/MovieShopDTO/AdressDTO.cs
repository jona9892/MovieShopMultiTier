using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MovieShopDTO
{
    [DataContract(IsReference = true)]
    public class AdressDTO
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string StreetName { get; set; }
        [DataMember]
        public int StreetNumber { get; set; }
        [DataMember]
        public int Zipcode { get; set; }
        [DataMember]
        public string Country { get; set; }
    }
}
