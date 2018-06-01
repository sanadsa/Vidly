using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {  
            return View(getCustomers());
        }

        //GET: Customers/Details/Id
        [Route("customers/details/{id}")]
        public ActionResult Details(int id)
        {           
            var customer = getCustomers().Find(item => item.Id == id);

            if (customer != null)
            {
                return View(customer);
            }            
            else
            {
                return HttpNotFound();
            }
        }

        private List<Customer> getCustomers() => new List<Customer>
            {
                new Customer() { Id = 1, Name = "Jhon" },
                new Customer() { Id = 2, Name = "mate" }
            };
    }
}