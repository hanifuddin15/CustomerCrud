using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomerCrud.Models
{
    public class Customer
    {
      
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        //[ForeignKey("CustomerPermanentAddress")]
       // public int CustomerID { get; set; }
        public ICollection<CustomerPermanentAddresses> customerPermanentAddresses { get; set; }
    }
}
