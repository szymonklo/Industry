using System;
using System.Collections.Generic;
using System.Text;
using Industry;

namespace Industry
{
    class Factory
    {
        public int DefProduction { get; set; }
        public string Name { get; set; }
        public int ProductStorage {get; set;}
        public Product ProductsType { get; set; }
        public Factory(string factoryName, int factoryDefProduction, Product product)
        {
            Name = factoryName;
            DefProduction = factoryDefProduction;
            ProductsType = product;
        }
        
        public int FactoryProduce(Product product)
        {
            if (product == ProductsType)
                ProductStorage += Production.Produce(this, product);
            return ProductStorage;
        }
    }
}