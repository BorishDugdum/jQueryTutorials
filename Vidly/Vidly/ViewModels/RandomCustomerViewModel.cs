using System.Collections.Generic;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class RandomCustomerViewModel
    {
        public List<Customer> Customers { get; set; }
        public RandomCustomerViewModel()
        {
            Customers = new List<Customer>();
        }
    }
}