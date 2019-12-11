using System;
using System.Collections.Generic;
using System.Text;

namespace Industry
{
    class Facility
    {
        public string Name { get; set; }
        public virtual List<Product> ProductsIn { get; set; } = new List<Product>();
        public virtual List<Product> ProductsOut { get; set; } = new List<Product>();

        //public Facility(string name, List<Product> ProductsIn = null, List<Product> ProductsOut = null)
        //{
        //    Name = name;
        //}
    }
}
