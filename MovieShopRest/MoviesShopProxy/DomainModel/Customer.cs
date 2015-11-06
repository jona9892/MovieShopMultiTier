using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieShopDAL.DomainModel
{
    [Table("Customer")]
    public class Customer
    {


        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Adress Adress { get; set; }
        public string Email { get; set; }
        
        public override string ToString()
        {
            return "" + FirstName + " " + LastName;
        }
    }
}
