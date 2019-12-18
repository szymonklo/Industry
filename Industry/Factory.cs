using System;
using System.Collections.Generic;
using System.Text;
using Industry;

namespace Industry
{
    class Factory : Facility
    {
        public int DefProduction { get; set; }
        public int BaseCost { get; set; } = 10;

        //public string Name { get; set; }
        //public int ProductStorage {get; set;}
        public ProductType ProductType { get; set; }
        //public override List<Product> ProductsIn { get; set; }
        //public override List<Product> ProductsOut { get; set; }
        public Product Product { get; set; }
        private static readonly int _defProduction = 1;

        public Factory(string factoryName, int factoryDefProduction, ProductType productType)
        {
            Name = factoryName;
            DefProduction = factoryDefProduction;
            ProductType = productType;
            Product = new Product(productType);
            Products.Add(Product);
            //Components = ProductOutFactory.Components;
            //ProductsIn = new ProductsKeyed();
            if (productType.Components != null)
            {
                foreach (ProductType component in productType.Components)
                {
                    Products.Add(new Product(component));
                }
            }
        }

        public void Produce(ProductType productType)
        {
            if (productType.Id != Product.Id)
            {
                Product = Products[productType.Id];
            }
            bool AreComponents, IsComponent = false;

            if (productType.Components != null)
            {
                foreach (ProductType component in productType.Components)
                {
                    Product factoryComponent = Products[component.Id];
                    if (factoryComponent.AmountIn > ProductionAmount())
                    {
                        IsComponent = true;
                        break;
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
                double produktsOnStockCosts = 0;

                if (productType.Components != null)
                {
                    foreach (ProductType component in productType.Components)
                    {
                        Product factoryComponent = Products[component.Id];
                        produktsOnStockCosts += factoryComponent.ProductPrice * ProductionAmount();
                        factoryComponent.AmountIn -= ProductionAmount();
                        Console.WriteLine($"{Name} used: {ProductionAmount()} {factoryComponent.Name} (Components remained: {factoryComponent.AmountIn} {factoryComponent.Name})");
                    }
                }

                produktsOnStockCosts += (Product.ProductCost * (Product.AmountOut + ProductionAmount()) + BaseCost);
                Product.AmountOut += ProductionAmount();
                Product.ProductCost = produktsOnStockCosts / Product.AmountOut;
                //foreach (Product product in ProductsOut)
                //{

                //}
                Console.WriteLine($"{Name} produced: {ProductionAmount()} {Product.Name} (On stock: {Product.AmountOut} {Product.Name})");
                Console.WriteLine($"{Product.Name} cost is {Product.ProductCost:c} per 1 pc.");
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