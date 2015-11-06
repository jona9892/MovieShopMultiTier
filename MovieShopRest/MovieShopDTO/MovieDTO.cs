using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MovieShopDTO
{
    [DataContract(IsReference=true)]
    public class MovieDTO
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public int Year { get; set; }
        [DataMember]
        public double Price { get; set; }
        [DataMember]
        public string imageURL { get; set; }
        [DataMember]
        public string trailerURL { get; set; }
        [DataMember]
        public virtual GenreDTO Genre { get; set; }
    }
}
