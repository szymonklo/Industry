using System;
using System.Collections.Generic;
using System.Text;
using Industry;

namespace Industry
{
    class Round
    {
        public static void Go()
        {
            ProductType water = new ProductType(1, 1, "water", 1);
            ProductType bread = new ProductType(2, 1, "bread", 2, new List<ProductType> { water });
            List<ProductType> ProductsTypes = new List<ProductType>
            {
                water,
                bread
            };

            List<Product> Products = new List<Product>();
            foreach (ProductType productType in ProductsTypes)
            {
                Products.Add(new Product(productType));
            }


            Factory waterSupply = new Factory("Water supply", 100, water);
            Factory bakery = new Factory("Bakery", 60, bread);

            City krakow = new City("Krakow", 80, Products);
            City warszawa = new City("Warszawa", 100, Products);
            //sposob 1
            List<City> Cities = new List<City>();
            Cities.Add(krakow);
            Cities.Add(warszawa);

            //sposob 2
            

            List<Factory> Factories = new List<Factory>
            {
                waterSupply,
                bakery
            };

            bakery.ProductsIn[0].Amount = 200;
            //temp

            //Cities demand
            Console.WriteLine("**** Cities demand ****\n");
            foreach (City city in Cities)
            {
                city.Demand();
            }
            Console.WriteLine("\n");

            //Factories produce
            Console.WriteLine("**** Factories produce ****\n");
            foreach (Factory factory in Factories)
            {
                factory.Produce(factory.ProductOutFactory);
            }
            Console.WriteLine("\n");

            //Products are transported from factories to cities
            Console.WriteLine("**** Products are transported from factories to cities ****\n");
            foreach (Factory factory in Factories)
            {
                foreach (City city in Cities)
                {
                    TransportOrder transportOrder = new TransportOrder(factory, city, factory.ProductType, 10);
                }
            }
            Console.WriteLine("\n");

            //Cities consume
            Console.WriteLine("**** Cities consume ****\n");
            foreach (City city in Cities)
            {
                city.Consume();
            }
        }
    }
}
