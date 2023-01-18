using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Limitless.Classes
{
    public class Amenity
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }

        public Amenity() { }

        public Amenity(string name, double price, string category)
        {
            Name = name;
            Price = price;
            Category = category;
        }
    }
}
