using MovieShopUser.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesShopProxy.DomainModel
{
    [Table("Order")]

    public class Order
    {
        [Key]
        public int Id { get; set; }

        public int CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }
        
        public int MovieId { get; set; }
        [ForeignKey("MovieId")]
        public virtual Movie  Movie { get; set; }

        public DateTime Date { get; set; }
    }
}
