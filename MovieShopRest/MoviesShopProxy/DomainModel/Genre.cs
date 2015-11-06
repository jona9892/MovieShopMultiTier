using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieShopDAL.DomainModel
{
    [Table("Genre")]

    public class Genre
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        //public virtual List<Movie> Movies { get; set; }
    }
}