using DataAccessPoint;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace WebApiNorthwindEX.Controllers.API
{
    public class CustomerAPIController : ApiController
    {
        [Route("api/CustomerAPI/GetCustomers")]
        //[HttpPost]
        [HttpGet]
        public List<DataAccessPoint.Customer> GetCustomers(Models.CustomerModel customer)
        {
            //System.Drawing.Rectangle rec = new System.Drawing.Rectangle();
            
            NorthwindEntities entities = new NorthwindEntities();
            entities.Configuration.ProxyCreationEnabled = false;
            try
            {
                List<Customer> lst = new List<Customer>();
                lst = (from c in entities.Customers.Take(10)
                           //where c.ContactName.StartsWith(customer.fullName) || string.IsNullOrEmpty(customer.fullName)
                           select c).ToList();

                return lst;
            }
            catch (Exception e)
            {
                string errMsg = e.Message;
                return null;
            }

        }
    }
}
