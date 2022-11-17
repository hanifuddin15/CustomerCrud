using CustomerCrud.Models;
using CustomerCrud.Models.RequestResponseModel.RequestModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace CustomerCrud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly CustomerDbContext _context;

        public CustomerController(CustomerDbContext context)
        {
            _context = context;
        }

        [HttpPost("CustomerCreate")]
        public async Task<IActionResult> CustomerCreate(CustomerCreateRequestModel request)
        {
            Customer customer = new Customer();
           
            customer.Name = request.Name;
            customer.Address = request.Address;
          

            await _context.customers.AddAsync(customer);
            await _context.SaveChangesAsync();
            return Ok();

        }
        [HttpPost("CustomerAdd")]
        public async Task<IActionResult> CustomerAdd(CustomerPermanentAddressRequest address)
        {
            CustomerPermanentAddresses customerPermanentAddresses = new CustomerPermanentAddresses();
            customerPermanentAddresses.Id = address.CustomerID;
            customerPermanentAddresses.CustomerID = address.CustomerID;
            customerPermanentAddresses.House = address.House;
            customerPermanentAddresses.Road = address.Road;
            customerPermanentAddresses.Post = address.Post;
            customerPermanentAddresses.City = address.City;
            //  // customerPermanentAddress.Customer = 
            await _context.customerPermanentAddresses.AddAsync(customerPermanentAddresses);
            await _context.SaveChangesAsync();
            return Ok();


        }
    }
}
