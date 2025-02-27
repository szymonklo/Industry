﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Industry
{
    class TransportOrder
    {
        public int TransportCost { get; set; } = 1;
        public TransportOrder(Facility sender, Facility receiver, ProductType productType, int capacity)
        {
            
            if (sender.Products.Contains(productType.Id) && sender.Products[productType.Id].AmountOut>0)
            {
                sender.Products[productType.Id].AmountOut -= capacity;
                Product productIn;
                if (receiver.Products.Contains(productType.Id))
                {
                    productIn = receiver.Products[productType.Id];
                }
                else
                {
                    productIn = new Product(productType, capacity);
                    receiver.Products.Add(new Product(productType, capacity));
                }
                double productInCost = productIn.AmountIn * productIn.ProductCost + capacity * sender.Products[productType.Id].ProductCost + TransportCost;
                productIn.AmountIn += capacity;
                productIn.ProductCost = productInCost / productIn.AmountIn;

                Console.WriteLine($"Transported {capacity} {productType.Name}");
                Console.WriteLine($"In {sender.Name} (origin) left {sender.Products[productType.Id].AmountOut} {productType.Name}");
                Console.WriteLine($"In {receiver.Name} (destination) there are {receiver.Products[productType.Id].AmountIn} {receiver.Products[productType.Id].Name}\n");
            }
            else
                Console.WriteLine("no product to send");
        }
    }
}