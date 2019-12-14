using System;
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
            foreach (Product product in ProductsOut)
            {
                product.Amount = Consumption.Demand(product, this);
                Console.WriteLine($"{Name} demands {product.Amount} {product.Name}");
            }
        }

        public void Consume()
        {
            foreach (Product productIn in ProductsIn)
            {
                Product productOut = ProductsOut[productIn.Id];
                if (true)   //warunki? demand > 0
                {
                    double ProductPrice = productOut.DefPrice * MarketPriceMod(productOut, productIn);
                    int SaleAmount = Math.Min(productOut.Amount, productIn.Amount);

                    productOut.Amount -= SaleAmount;
                    productIn.Amount -= SaleAmount;

                    double Income = SaleAmount * ProductPrice;

                    Console.WriteLine($"{Name} consumed {SaleAmount} {productOut.Name}");
                    Console.WriteLine($"{Name} still demands {productOut.Amount} {productOut.Name}");
                    Console.WriteLine($"{Name} stil has {productIn.Amount} {productOut.Name}");

                    Console.WriteLine($"{Name} paid {Income:c} ({ProductPrice:c} per 1 pc)\n");
                }
            }
        }

        public static double MarketPriceMod(Product productOut, Product productIn)
        {
            double p = (productOut.Amount - productIn.Amount);
            p/=(productOut.Amount);
            return p+1;
        }
    }
}
