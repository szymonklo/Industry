using System;
using System.Collections.Generic;
using System.Text;

namespace Industry
{
    class Transport
    {
        public static void TransportProduct(Shop shop, Product product, Factory factory)
        {
            if (product == factory.ProductType)
            {
                shop.ProductStorage += factory.ProductStorage;
                factory.ProductStorage = 0;
            }
        }
    }
}