using System;
using System.Collections.Generic;
using System.Text;
using Industry;

namespace Industry
{
    class ProductOutFactory : Product
    {
        //private int _productionOutFactory;
        public ProductOutFactory(int id, byte group, string productName, double defPrice, List<Product> Components)
            : base(id, group, productName, defPrice, Components) { }

        public ProductOutFactory(Product product)
            : this(product.Id, product.Group, product.Name, product.DefPrice, product.Components) { }

        public Product Product
        {
            get
            {
                return (Product)this;
            }
            set { }
        }
        public Factory Factory { get; set; }
        //public void ProductionOut()
        //{
        //    ProductionOutFactory = Factory.Produce(Product);
        //}
        public int ProductionOutFactory { get; set; }
        //{
        //    get { return _productionOutFactory; }
        //    set
        //    {
        //        _productionOutFactory = Production.Produce(Factory, Product);
        //    }
        //}
        public int Demand { get; set; }
        public int Supply { get; set; }
        //public static double ProductPrice { get; set; }
        public int Amount { get; set; }
        public double Income { get; set; }
        
        //private static readonly double defMarketPriceMod = 1;

        //public void Sell(City city, Shop shop, Factory factory, Product product)
        //{
        //    Demand = city.CityDemand(product);
        //    Transport.TransportProduct(shop, product, factory);
        //    Supply = shop.ProductStorage;
        //    //ProductPrice = product.DefPrice * MarketPriceMod(product);
        //    SaleAmount = Math.Min(Supply, Demand);
        //    shop.ProductStorage -= SaleAmount;
        //    Income = SaleAmount * ProductPrice;
        //}
        //public static double MarketPriceMod(Product product)
        //{
        //    return 1 + defMarketPriceMod * (this.Demand - this.Supply) / this.Demand;
        //}
    }
}
