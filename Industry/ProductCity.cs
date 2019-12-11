using System;
using System.Collections.Generic;
using System.Text;
using Industry;

namespace Industry
{
    class ProductCity : ProductType
    {
        public int Demand { get; set; }
        public ProductCity(int id, byte group, string productName, double defPrice, List<ProductType> components)
            : base(id, group, productName, defPrice, components) { }

        public ProductCity(ProductType product)
            : this(product.Id, product.Group, product.Name, product.DefPrice, product.Components) { }
    }
}
