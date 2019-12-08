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
        public Product ProductType { get; set; }
        public List<ProductFactory> Components { get; set; }
        public List<ProductOutFactory> ProductsOutFactory { get; set; }
        public ProductOutFactory ProductOutFactory { get; set; }
        private static readonly int _defProduction = 1;
        //private static bool AreComponents { get; set; }
        public Factory(string factoryName, int factoryDefProduction, Product product)
        {
            Name = factoryName;
            DefProduction = factoryDefProduction;
            ProductType = product;
            ProductOutFactory = new ProductOutFactory(product);
        }

        public void Produce(Product product)
        {
            if (product.Id != ProductOutFactory.Id)
            {
                ProductOutFactory = ProductsOutFactory.Find(x => x.Id.Equals(product.Id));
            }
            bool AreComponents, IsComponent = false;

            if (product.Components != null)
            {
                foreach (Product component in product.Components)
                {
                    foreach (Product factoryComponent in Components)
                    {
                        if (component.Id == factoryComponent.Id)
                        {
                            IsComponent = true;
                            break;
                        }
                    }
                    if (!IsComponent)
                        break;
                }
                if (IsComponent)
                    AreComponents = true;
                else
                    AreComponents = false;      //Sprawdzić
            }
            else
                AreComponents = true;

            if (AreComponents)
            {
                if (product.Components != null)
                {
                    foreach (Product component in product.Components)
                    {
                        foreach (ProductFactory factoryComponent in Components)
                        {
                            if (component.Id == factoryComponent.Id)
                                factoryComponent.Amount -= ProductionAmount();
                            Console.WriteLine(factoryComponent.Amount+factoryComponent.Name);
                        }
                    }
                }
                ProductOutFactory.Amount += ProductionAmount();
                Console.WriteLine(ProductOutFactory.Amount+ ProductOutFactory.Name);
            }



            //{
            //if (ProductsOutFactory.Find(x => x.Id.Equals(product.Id))!=null)
            //{
            //    ProductsOutFactory.Find(x => x.Id.Equals(product.Id)).Amount += Production.Produce(this, product);
            //}
            int ProductionAmount()
            {
                    switch (product.Group)
                    {
                        case 1:
                            return _defProduction * DefProduction;
                        default:
                            return 0;
                    }
            }

            //}
        }
        
    }
}