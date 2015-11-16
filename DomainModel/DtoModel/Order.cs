using System;
using System.Collections.Generic;

namespace DomainModel.DomainModel
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public List<OrderLine> OrderLines { get; set; }
        public DateTime Date { get; set; }
    }
}
