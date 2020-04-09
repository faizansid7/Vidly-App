using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlyApp.Models;

namespace VidlyApp.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            var customer = customerList();
            return View(customer);
        }

        public ActionResult Details( int id)
        {
            var detail = customerList().SingleOrDefault(c => c.Id == id);
            return View(detail);
        }

        private List<Customers> customerList()
        {
            return new List<Customers>()
            {
                new Customers(){Id = 1, Name = "daniel"},
                new Customers(){Id = 2, Name = "shard"}
            };
        }

    }
}