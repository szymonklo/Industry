using System;
using System.Collections.Generic;
using System.Text;

namespace Industry
{
    class City
    {
        public int population { get; set; }
        public string cityName { get; set; }
        public int cityDemand { get; set; }

        public City(string cityName, int population)
        {
            this.cityName = cityName;
            this.population = population;
        }


        public int CityDemand(Product product)
        {
            cityDemand = Consumption.Demand(this, product);
            return cityDemand;
        }
    }
}
