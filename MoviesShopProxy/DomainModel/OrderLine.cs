using MoviesShopProxy.DomainModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieShopUser.Models
{
    public class OrderLine
    {
        [Key]
        [Column(Order = 2)]
        public int OrderId { get; set; }

        [ForeignKey("OrderId")]
        public Order order { get; set; }


        public int Amount { get; set; }
        [Key]
        [Column(Order = 1)]
        public int MovieId { get; set; }

        [ForeignKey("MovieId")]
        public Movie Movie { get; set; }
    }
}