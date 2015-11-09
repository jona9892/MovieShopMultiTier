using System;

namespace DomainModel.DomainModel
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public int MovieId { get; set; }
        public virtual Movie  Movie { get; set; }
        public DateTime Date { get; set; }
    }
}
