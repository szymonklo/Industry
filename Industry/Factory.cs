using System;
using System.Collections.Generic;
using System.Text;
using Industry;

namespace Industry
{
    class Factory : Facility
    {
        public int DefProduction { get; set; }
        //public string Name { get; set; }
        //public int ProductStorage {get; set;}
        public ProductType ProductType { get; set; }
        //public override List<Product> ProductsIn { get; set; }
        //public override List<Product> ProductsOut { get; set; }
        public Product ProductOutFactory { get; set; }
        private static readonly int _defProduction = 1;

        public Factory(string factoryName, int factoryDefProduction, ProductType productType)
        {
            Name = factoryName;
            DefProduction = factoryDefProduction;
            ProductType = productType;
            ProductOutFactory = new Product(productType);
            ProductsOut.Add(ProductOutFactory);
            //Components = ProductOutFactory.Components;
            ProductsIn = new List<Product>();
            if (productType.Components != null)
            {
                foreach (ProductType component in productType.Components)
                {
                    ProductsIn.Add(new Product(component));
                }
            }
        }

        public void Produce(ProductType productType)
        {
            if (productType.Id != ProductOutFactory.Id)
            {
                ProductOutFactory = ProductsOut.Find(x => x.Id.Equals(productType.Id));
            }
            bool AreComponents, IsComponent = false;

            if (productType.Components != null)
            {
                foreach (ProductType component in productType.Components)
                {
                    foreach (Product factoryComponent in ProductsIn)
                    {
                        if ((component.Id == factoryComponent.Id) && (factoryComponent.Amount>ProductionAmount()))
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
                if (productType.Components != null)
                {
                    foreach (ProductType component in productType.Components)
                    {
                        foreach (Product factoryComponent in ProductsIn)
                        {
                            if (component.Id == factoryComponent.Id)
                            {
                                factoryComponent.Amount -= ProductionAmount();
                                Console.WriteLine($"{Name} used: {ProductionAmount()} {factoryComponent.Name} (Components remained: {factoryComponent.Amount} {factoryComponent.Name})");
                            }
                        }
                    }
                }
                ProductOutFactory.Amount += ProductionAmount();
                //foreach (Product product in ProductsOut)
                //{

                //}
                Console.WriteLine($"{Name} produced: {ProductionAmount()} {ProductOutFactory.Name} (On stock: {ProductOutFactory.Amount} {ProductOutFactory.Name})");
            }

            int ProductionAmount()
            {
                    switch (productType.Group)
                    {
                        case 1:
                            return _defProduction * DefProduction;
                        default:
                            return 0;
                    }
            }
        }
    }
}