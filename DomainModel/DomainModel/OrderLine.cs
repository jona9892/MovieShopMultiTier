using DomainModel.DomainModel;

namespace MovieShopUser.Models
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