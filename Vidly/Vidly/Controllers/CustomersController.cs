using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var viewModel = new RandomCustomerViewModel();
            for(int i = 0; i < 7; i++)
            {
                viewModel.Customers.Add(new Customer("first", "last"));
            }


            return View(viewModel);
        }
    }
}