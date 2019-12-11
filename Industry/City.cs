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


        public City(string name, int population, List<Product> ProductsOut = null)
        {
            Name = name;
            Population = population;
            ProductsOut = new List<Product>();
            if (ProductsOut != null)
            {
                foreach (Product product in ProductsOut)
                {
                    //Product Product = new Product(product);
                    product.Amount = Demand(product);
                    ProductsOut.Add(product);

                    Console.WriteLine(Name + ": " + product.Name + " " + product.Amount);
                }
            }
        }

        public int Demand(Product product)
        {
            return Consumption.Demand(product, this);
            //return cityDemand;
        }

        public void Consume ()
        {
            foreach (Product product in ProductsOut)
            {
                product.Amount = Demand(product);
                Console.WriteLine(this.Name + ": " + product.Name + " "+ product.Amount);


            }
        }
    }
}
