using System;
using System.Collections.Generic;
using System.Text;

namespace Industry
{
    class Product
    {
        public Product(byte group, string productName)
        {
            this.productGroup = group;
            this.productName = productName;
        }
        public string productName { get; set; }
        public byte productGroup { get; set; }
        //public IEnumerable<string> productType = new List<string> { "Water" };
    }
}
