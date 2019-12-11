using System;
using System.Collections.Generic;
using System.Text;

namespace Industry
{
    class City : Facility
    {
        public int Population { get; set; }
        //public override string Name { get; set; }
        //public int cityDemand { get; set; }
        //public override List<Product> ProductsIn { get; set; }
        //public override List<Product> ProductsOut { get; set; }


        public City(string name, int population, List<Product> productsOut = null)
        {
            Name = name;
            Population = population;
            if (productsOut ==null)
                ProductsOut = new List<Product>();
            //if (ProductsOut != null)
            {
                foreach (Product product in productsOut)
                {
                    //Product Product = new Product(product);
                    product.Amount = Demand(product);
                    ProductsOut.Add(product);

                    //Console.WriteLine(Name + ": " + product.Name + " " + product.Amount);
                }
            }
        }

        public int Demand(Product product)
        {
            return Consumption.Demand(product, this);
            //return cityDemand;
        }

        public void Demand()
        {
            foreach (Product product in ProductsOut)
            {
                product.Amount = Demand(product);
                Console.WriteLine($"{Name} demands {product.Amount} {product.Name}");
            }
        }

        public void Consume()
        {
            foreach (Product productOut in ProductsOut)
            {
                foreach (Product productIn in ProductsIn)
                {
                    if (productOut.Id == productIn.Id)
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
        }

        public static double MarketPriceMod(Product productOut, Product productIn)
        {
            double p = (productOut.Amount - productIn.Amount);
            p/=(productOut.Amount);
            return p+1;
        }
    }
}
