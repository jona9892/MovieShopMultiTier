using DomainModel.DomainModel;

namespace DomainModel.DomainModel
{
    public class OrderLine
    {
        public int OrderId { get; set; }
        public Order order { get; set; }
        public int Amount { get; set; }
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
    }
}