using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;

namespace CustomerCrud.Models
{
    public class CustomerPermanentAddresses
    {
        [Key]
        public int Id { get; set; }
        
        public int CustomerID { get; set; }
        public string House { get; set; }
        public string Road { get; set; }
        public string Post { get; set; }
        public string City { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
