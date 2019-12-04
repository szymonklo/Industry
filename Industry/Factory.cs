using System;
using System.Collections.Generic;
using System.Text;
using Industry;

namespace Industry
{
    class Factory
    {
        public int factoryDefProduction { get; set; }
        public string factoryName { get; set; }
        public int factoryProductsStorage {get; set;}
        public Factory(string factoryName, int factoryDefProduction)
        {
            this.factoryName = factoryName;
            this.factoryDefProduction = factoryDefProduction;
        }
        

        public int FactoryProduce(Product product)
        {
            factoryProductsStorage += Production.Produce(this, product);
            return factoryProductsStorage;
        }
    }
}