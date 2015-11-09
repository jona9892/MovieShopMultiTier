namespace DomainModel.DomainModel
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }
        public string imageURL { get; set; }
        public string trailerURL { get; set; }
        public virtual Genre Genre { get; set; }
    }
}
