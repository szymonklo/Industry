using System;
using System.Collections.Generic;
using System.Text;

namespace Industry
{
    class Product
    {
        public Product(byte group, string productName, double defPrice)
        {
            Group = group;
            Name = productName;
            DefPrice = defPrice;
        }
        public string Name { get; set; }
        public byte Group { get; set; }
        public double DefPrice { get; set; }
    }
}
