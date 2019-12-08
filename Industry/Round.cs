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
            

            City krakow = new City("Krakow", 800000);
            City warszawa = new City("Warszawa", 1000000);

            Product water = new Product(1, 1, "water", 1);
            Product bread = new Product(2, 1, "bread", 2, new List<Product> { water });

            Factory waterSupply = new Factory("Water supply", 100000, water);
            Factory bakery = new Factory("Bakery", 60000, bread);

            //sposob 1
            List<City> Cities = new List<City>();
            Cities.Add(krakow);
            Cities.Add(warszawa);

            //sposob 2
            List<Product> Products = new List<Product>
            {
                water,
                bread
            };

            List<Factory> Factories = new List<Factory>
            {
                waterSupply,
                bakery
            };

            //temp
            bakery.Components = new List<ProductFactory> { new ProductFactory(water) };

            List<List<ProductInCity>> ProductsInCities = new List<List<ProductInCity>>();
            foreach (City city in Cities)
            {
                List<ProductInCity> ProductsInCity = new List<ProductInCity>();
                //foreach (ProductInCity productInCity in ProductsInCity)
                foreach (Product product in Products)
                {
                    ProductInCity productInCity = new ProductInCity(product);
                    productInCity.City = city;
                    productInCity.Demand = Consumption.Demand(productInCity);
                    ProductsInCity.Add(productInCity);
                    Console.WriteLine(productInCity.City.Name + ": " + productInCity.Name + ": " + productInCity.Demand);
                    //Console.WriteLine(productInCity.Product.Name);
                }
                ProductsInCities.Add(ProductsInCity);
            }

            //List<List<ProductOutFactory>> ProductsOutFactories = new List<List<ProductOutFactory>>();
            foreach (Factory factory in Factories)
            {
                
                factory.Produce(factory.ProductOutFactory);
                //ProductsOutFactory.Add(productOutFactory);
                //Console.WriteLine(factory.Name + ": " + factory.ProductOutFactory.Name + ": +" + factory.ProductOutFactory.Amount);
                
                //ProductsOutFactories.Add(ProductsOutFactory);
            }

            //List<List<ProductOutFactory>> ProductsOutFactories = new List<List<ProductOutFactory>>();
            //foreach (Factory factory in Factories)
            //{
            //    //List<ProductOutFactory> ProductsOutFactory = new List<ProductOutFactory>();
            //    foreach (Product product in factory.Products)
            //    {
            //        ProductOutFactory productOutFactory = new ProductOutFactory(product);
            //        productOutFactory.Factory = factory;
            //        //productOutFactory.Demand = Consumption.Demand(productOutFactory);
            //        productOutFactory.ProductionOut();
            //        ProductsOutFactory.Add(productOutFactory);
            //        Console.WriteLine(productOutFactory.Factory.Name + ": " + productOutFactory.Name + ": " + productOutFactory.ProductionOutFactory);
            //        //Console.WriteLine(productOutFactory.Product.Name);
            //    }
            //    ProductsOutFactories.Add(ProductsOutFactory);
            //}
            Console.WriteLine(1);
            //foreach (City city in Cities)
            //{
            //    foreach (ProductInCity productInCity in ProductsInCity)
            //    {
            //        productInCity.Demand = Consumption.Demand(city, productInCity.Product);
            //    }
            //}
            
        }
    }
}
