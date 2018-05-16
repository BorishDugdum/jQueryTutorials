using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        private static int id_counter = 0;
        public int ID { get; }
        public string Name { get; }
        public Movie(string name)
        {
            ID = id_counter++;
            Name = name;
        }
    }
}