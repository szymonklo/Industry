using System;
using System.Collections.Generic;
using System.Text;
using Industry;
using System.Collections.ObjectModel;

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

            ProductsKeyed products = new ProductsKeyed();
            //Dictionary<int, Product> ProductsD= new Dictionary<int, Product>();

            foreach (ProductType productType in ProductsTypes)
            {
                products.Add(new Product(productType));
                //ProductsD.Add(productType.Id, new Product(productType));
            }


            Factory waterSupply = new Factory("Water supply", 100, water);
            Factory bakery = new Factory("Bakery", 60, bread);

            //City krakow = new City("Krakow", 80, ProductsD.Values);
            City krakow = new City("Krakow", 80);//, ProductsTypes);
            City warszawa = new City("Warszawa", 100);//, ProductsTypes);

            //City warszawa = new City("Warszawa", 100, Products);
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

            bakery.Products[1].AmountIn = 200;
            bakery.Products[1].ProductPrice = 1.1;

            //temp

            //Create cities demand
            Console.WriteLine("**** Cities demand ****\n");
            foreach (City city in Cities)
            {
                foreach (ProductType productType in ProductsTypes)
                {
                    city.Products.Add(new Product(productType));
                }
            }

            //Cities demand
            //Console.WriteLine("**** Cities demand ****\n");
            foreach (City city in Cities)
            {
                city.Demand();
            }
            Console.WriteLine("\n");

            //Factories produce
            Console.WriteLine("**** Factories produce ****\n");
            foreach (Factory factory in Factories)
            {
                factory.Produce(factory.Product);
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
                city.ProductWasSold += new Write().HandleProductSold;
                city.Consume();
            }
        }
    }
}
