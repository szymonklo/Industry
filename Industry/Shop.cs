using System;
using System.Collections.Generic;
using System.Text;

namespace Industry
{
    class Shop
    {
        public int demand { get; set; }
        public int supply { get; set; }

        public Shop(City city, Factory factory)
        {
            this.demand = city.cityDemand;
            this.supply = factory.factoryProductsStorage;
        }
        
    }
}
