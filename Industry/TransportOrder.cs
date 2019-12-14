using System;
using System.Collections.Generic;
using System.Text;

namespace Industry
{
    class TransportOrder
    {
        public TransportOrder(Facility sender, Facility receiver, ProductType productType, int capacity)
        {
            if (sender.ProductsOut.Contains(productType.Id))
            {
                sender.ProductsOut[productType.Id].Amount -= capacity;
                if (receiver.ProductsIn.Contains(productType.Id))
                    receiver.ProductsIn[productType.Id].Amount += capacity;
                else
                {
                    receiver.ProductsIn.Add(new Product(productType, capacity));
                }
                Console.WriteLine($"Transported {capacity} {productType.Name}");
                Console.WriteLine($"In {sender.Name} (origin) left {sender.ProductsOut[productType.Id].Amount} {productType.Name}");
                Console.WriteLine($"In {receiver.Name} (destination) there are {receiver.ProductsIn[productType.Id].Amount} {receiver.ProductsIn[productType.Id].Name}\n");
            }
            else
                Console.WriteLine("no product to send");
        }
    }
}