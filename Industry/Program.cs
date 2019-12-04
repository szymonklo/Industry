using System;

namespace Industry
    //ILocation (distance)
    //IProduction (input<>, output, recipe, def_productivity, factory_type)
        //produce (output, factory)
    //IConsumption (goods<>, city, def_consumption)
        //consume (goods<>, consumption)
    //IProduct (Tier, components, production time, location)
        //get_components (output)
    //IFactory (product, production, efficiency, location)

        //City (population, shops, demands, growth, location)
        //Shop (product, price, demand, location)
        //Magazine
        //Resource (Renewability, location)
        //Transport (mean of transport, speed, cost)
        //Company (factories, transport)
        //Time
        //Action
        //Map (terrain, region)
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Day 0\n");

            City krakow = new City("Krakow", 800000);

            Product water = new Product(1, "water");

            //Consumption consumption = new Consumption();
            //int demand = consumption.Demand(krakow, water);

            Console.WriteLine($"City name: {krakow.cityName}, population: {krakow.population}\n" +
                $"Product: {water.productName}, product group: {water.productGroup}\n" +
                $"Daily demand: {krakow.cityDemand}\n");

            Factory waterSupply = new Factory("Water supply", 100000);
            int production = waterSupply.FactoryProduce(water);

            Console.WriteLine($"Factory name: {waterSupply.factoryName}, daily production: {waterSupply.factoryDefProduction}\n" +
                $"Product: {water.productName}, product group: {water.productGroup}\n" +
                $"Daily production: {production}\n");



        }
    }
}