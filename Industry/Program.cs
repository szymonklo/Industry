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

            Product water = new Product(1, "water", 1);

            //Consumption consumption = new Consumption();
            //int demand = consumption.Demand(krakow, water);

            Console.WriteLine($"City name: {krakow.Name}, population: {krakow.Population}\n" +
                $"Product: {water.Name}, product group: {water.Group}\n" +
                $"Daily demand: {""}\n");

            Factory waterSupply = new Factory("Water supply", 100000, water);
            int production = waterSupply.FactoryProduce(water);

            Console.WriteLine($"Factory name: {waterSupply.Name}, daily production: {waterSupply.DefProduction}\n" +
                $"Product: {water.Name}, product group: {water.Group}\n" +
                $"Daily production: {production}\n");

            Shop market = new Shop(krakow, "Market");
            Sale.Sell(krakow, market, waterSupply, water);

            Console.WriteLine($"Shop name: {market.Name}, Storage: {market.ProductStorage}\n" +
                $"Product: {water.Name}, demand: {Sale.Demand}, supply: {Sale.Supply}\n" +
                $"Product price: {Sale.ProductPrice}, Sale Amount: {Sale.SaleAmount}, Income: {Sale.Income}\n");

            Round.Go();
        }
    }
}