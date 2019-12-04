﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Industry
{
    class City
    {
        public int Population { get; set; }
        public string Name { get; set; }
        //public int cityDemand { get; set; }

        public City(string cityName, int population)
        {
            Name = cityName;
            Population = population;
        }

        public int CityDemand(Product product)
        {
            return Consumption.Demand(this, product);
            //return cityDemand;
        }
    }
}
