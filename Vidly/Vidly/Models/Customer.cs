using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Customer
    {
        private static int id_counter = 0;
        public int ID { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public Customer(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            ID = id_counter++;
        }
    }
}