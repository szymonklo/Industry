using System;
using System.Collections.Generic;
using System.Text;
using Industry;

namespace Industry
{
    class Shop
    {
        public string Name { get; set; }
        public City City { get; set; }
        public int ProductStorage { get; set; }

        public Shop (City city, string name)
        {
            City = city;
            Name = name;
        }
    }
}