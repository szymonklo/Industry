using System;
using System.Collections.Generic;
using System.Text;
using Industry;

namespace Industry
{
    class Product : ProductType
    {
        public int Amount { get; set; }
        public Product(int id, byte group, string productName, double defPrice, List<ProductType> components)
            : base(id, group, productName, defPrice, components) { }

        public Product(ProductType productType)
            : this(productType.Id, productType.Group, productType.Name, productType.DefPrice, productType.Components) { }
    }
}
