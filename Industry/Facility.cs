using System;
using System.Collections.Generic;
using System.Text;

namespace Industry
{
    class Facility
    {
        public string Name { get; set; }
        public virtual ProductsKeyed ProductsIn { get; set; } = new ProductsKeyed();
        public virtual ProductsKeyed ProductsOut { get; set; } = new ProductsKeyed();

        //public Facility(string name, List<Product> ProductsIn = null, List<Product> ProductsOut = null)
        //{
        //    Name = name;
        //}
    }
}
