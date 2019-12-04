using System;
using System.Collections.Generic;
using System.Text;

namespace Industry
{
    class Consumption : IConsumption
    {
        private static readonly int defDemand = 1;

        public static int Demand (City city, Product product)
        {
            switch (product.productGroup)
            {
                case 1:
                    return defDemand * city.population;
                default:
                    return 0;
            }
        }
    }
}
