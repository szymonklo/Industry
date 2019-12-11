using System;
using System.Collections.Generic;
using System.Text;

namespace Industry
{
    class Consumption
    {
        private static readonly int _defDemand = 1;

        //public static int Demand (ProductInCity productInCity)
        //{
        //    switch (productInCity.Group)
        //    {
        //        case 1:
        //            return _defDemand * productInCity.City.Population;
        //        default:
        //            return 0;
        //    }
        //}

        public static int Demand(Product productCity, City city)
        {
            switch (productCity.Group)
            {
                case 1:
                    return _defDemand * city.Population;
                default:
                    return 0;
            }
        }
    }
}
