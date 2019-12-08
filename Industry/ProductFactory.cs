using System;
using System.Collections.Generic;
using System.Text;
using Industry;

namespace Industry
{
    class ProductFactory : Product
    {
        public Factory Factory { get; set; }
        public int Amount { get; set; }
        public ProductFactory(int id, byte group, string productName, double defPrice, List<Product> Components)
            : base(id, group, productName, defPrice) { }

        public ProductFactory(Product product)
            : this(product.Id, product.Group, product.Name, product.DefPrice, product.Components) { }

        public Product Product
        {
            get
            {
                return (Product)this;
            }
            set { }
        }

    }
}
