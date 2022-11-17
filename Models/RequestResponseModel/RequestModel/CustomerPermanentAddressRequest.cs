using CustomerCrud.Models;
using Microsoft.EntityFrameworkCore;

namespace CustomerCrud.Models.RequestResponseModel.RequestModel
{
    public class CustomerPermanentAddressRequest
    {
        public int CustomerID { get; set; }
        public string House { get; set; }
        public string Road { get; set; }
        public string Post { get; set; }
        public string City { get; set; }
        //public ICollection<Customer> Customer { get; set; }
    }
}


