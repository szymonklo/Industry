using System;
using System.Collections.Generic;
using System.Text;

namespace Industry
{
    class Consumption : IConsumption
    {
        private static readonly int _defDemand = 1;

        public static int Demand (City city, Product product)
        {
            switch (product.Group)
            {
                case 1:
                    return _defDemand * city.Population;
                default:
                    return 0;
            }
        }
    }
}
