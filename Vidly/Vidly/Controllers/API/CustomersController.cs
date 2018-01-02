using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vidly.Models;

namespace Vidly.Controllers.API
{
    public class CustomersController : ApiController
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        //GET /API/customers
        public IEnumerable<Customer> GetCustomers()
        {
            return _context.Customers.ToList();
        }

        //GET /API/customer/1

        public Customer GetCustomer(int id)
        {
            Customer customer = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customer == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            return customer;
        }

        //POST /API/customers
        [HttpPost]
        public Customer CreateCustomer(Customer customer)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            _context.Customers.Add(customer);
            _context.SaveChanges();

            return customer;
        }

        //PUT /API/customer/1

            [HttpPut]
        public void UpdateCustomer(int id, Customer customer)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var customerInDB = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customerInDB == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            customerInDB.Name = customer.Name;
            customerInDB.Birthdate = customer.Birthdate;
            customerInDB.isSubscribedToNewsletter = customer.isSubscribedToNewsletter;
            customerInDB.MembershipTypeId = customer.MembershipTypeId;

            _context.SaveChanges();
        }


        //DELETE /API/customer/1
        [HttpDelete]
        public void DeleteCustomer(int id)
        {
            var customerIdDb = _context.Customers.SingleOrDefault(c=>c.Id == id);

            if (customerIdDb == null)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            _context.Customers.Remove(customerIdDb);
            _context.SaveChanges();
        }

    }
}
