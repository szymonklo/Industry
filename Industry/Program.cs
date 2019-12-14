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

//czy ProductInCity zawiera Product (konstruktor (Product)), czy jest jego podklasą (też może być konstruktor)???
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Day 0\n");

            Round.Go();
        }
    }
}