using System;
using System.Collections.Generic;
using System.Text;

namespace Industry
{
    class Consumption : IConsumption
    {
        private static readonly int _defDemand = 1;

        public static int Demand (ProductInCity productInCity)
        {
            switch (productInCity.Group)
            {
                case 1:
                    return _defDemand * productInCity.City.Population;
                default:
                    return 0;
            }
        }
    }
}
