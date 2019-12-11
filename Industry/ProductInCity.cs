using System;
using System.Collections.Generic;
using System.Text;

namespace Industry
{
    class ProductInCity : ProductType
    {
        public ProductInCity(int id, byte group, string productName, double defPrice)
            : base(id, group, productName, defPrice) { }

        public ProductInCity(ProductType product)
            : this(product.Id, product.Group, product.Name, product.DefPrice) { }

        public ProductType Product
        {
            get
            {
                return (ProductType)this;
            }

            set { }
        }
        public City City { get; set; }
        public int Demand { get; set; }
        public int Supply { get; set; }
        //public static double ProductPrice { get; set; }
        public int SaleAmount { get; set; }
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
