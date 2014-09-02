using UsingCoreAjaxDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace UsingCoreAjaxDemo.Web.Api
{
    [RoutePrefix("api/customers")]
    public class CustomerController : ApiController
    {
        [HttpGet]
        [Route("{id}")]
        public Customer GetCustomer(int id)
        {
            if (id == 2)
                return new Customer
                {
                    Id = 2,
                    Name = "Test customer",
                    Email = "Test@test.com"
                };
            else
                return new Customer
                {
                    Id = 3,
                    Name = "Another test customer",
                    Email = "Another@Test.com",
                };
        }

        [HttpPost]
        [Route("{id}")]
        public HttpResponseMessage UpdateCustomer(int id, [FromBody]Customer customer)
        {
            return new HttpResponseMessage();
        }
    }
}
