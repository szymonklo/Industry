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

            Product water = new Product(1, "water", 1);
            Product bread = new Product(1, "bread", 2);

            List<City> Cities = new List<City>();
            Cities.Add(krakow);
            Cities.Add(warszawa);

            List<Product> Products = new List<Product>
            {
                water,
                bread
            };

            List<List<ProductInCity>> ProductsInCities = new List<List<ProductInCity>>();
            foreach (City city in Cities)
            {
                List<ProductInCity> ProductsInCity = new List<ProductInCity>();
                //foreach (ProductInCity productInCity in ProductsInCity)
                foreach (Product product in Products)
                {
                    ProductInCity productInCity = new ProductInCity(product.Group, product.Name, product.DefPrice);
                    productInCity.City = city;
                    productInCity.Demand = Consumption.Demand(productInCity);
                    ProductsInCity.Add(productInCity);
                    //ProductsInCity.Add(productInCity);
                }
                ProductsInCities.Add(ProductsInCity);
            }

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
