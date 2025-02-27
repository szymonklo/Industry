﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Industry
{
    class City : Facility
    {
        public int Population { get; set; }

        public City(string name, int population)//, ProductsKeyed productsOut = null)
        {
            Name = name;
            Population = population;
        }

        public void Demand()
        {
            foreach (Product product in Products)
            {
                product.AmountOut = Consumption.Demand(product, this);
                Console.WriteLine($"{Name} demands {product.AmountOut} {product.Name}");
            }
        }

        public void Consume()
        {
            foreach (Product product in Products)
            {
                //Product productOut = ProductsOut[productIn.Id];
                if (true)   //warunki? demand > 0
                {
                    product.ProductPrice = product.DefPrice * MarketPriceMod(product.AmountOut, product.AmountIn);
                    product.AmountDone = Math.Min(product.AmountOut, product.AmountIn);

                    product.AmountOut -= product.AmountDone;
                    product.AmountIn -= product.AmountDone;

                    double income = product.AmountDone * product.ProductPrice;
                    double cost = product.AmountDone * product.ProductCost;
                    double profit = income - cost;
                    product.ProductProfit = profit / product.AmountDone;

                    //activate event
                    ProductWasSold?.Invoke(this, EventArgs.Empty);

                    Console.WriteLine($"{Name} consumed {product.AmountDone} {product.Name}");
                    Console.WriteLine($"{Name} still demands {product.AmountOut} {product.Name}");
                    Console.WriteLine($"{Name} stil has {product.AmountIn} {product.Name}");

                    Console.WriteLine($"{Name} paid {income:c} ({product.ProductPrice:c} per 1 pc)");

                    Console.WriteLine($"Company profit is {profit:c} ({product.ProductProfit:c} per 1 pc\n");
                }
            }
        }
        //przygotowanie delegata
        public delegate void EventHandler(Facility c, EventArgs e);
        //przygotować deklarację zdarzenia na podstawie powyższego delagata:
        public event EventHandler ProductWasSold;
        //public void DoSomething() =>
        //ProductSold?.Invoke(this, EventArgs.Empty);

        public static double MarketPriceMod(int amountOut, int amountIn)
        {
            double p = (amountOut - amountIn);
            p/=(amountOut);
            return p+1;
        }
    }
}
