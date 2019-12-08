using System;
using System.Collections.Generic;
using System.Text;

namespace Industry
{
    class Product
    {
        public Product()
        { }
        public Product(int id, byte group, string productName, double defPrice, List<Product> components = null, string name2 = "222222")
        {
            Id = id;// _nextId++;                    //dodać zabezpieczenie przed użyciem ponownie numeru id
            Group = group;
            Name = productName;
            DefPrice = defPrice;
            Components = components;
            Name2 = name2;

        }
        public string Name2 { get; set; }
        public int Id { get;  }
        public string Name { get; set; }
        public byte Group { get; set; }
        public double DefPrice { get; set; }
        public List<Product> Components { get; set; }
        //private static int _nextId = 1;

    }
}
