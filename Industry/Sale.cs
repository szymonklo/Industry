using System;
using System.Collections.Generic;
using System.Text;

namespace Industry
{
    static class Sale
    {
        public static int Demand { get; set; }
        public static int Supply { get; set; }
        public static double ProductPrice { get; set; }
        public static int SaleAmount { get; set; }
        public static double Income { get; set; }
        

        private static readonly double defMarketPriceMod = 1;

        public static void Sell(City city, Shop shop, Factory factory, Product product)
        {
            //Demand = city.CityDemand(product);
            Transport.TransportProduct(shop, product, factory);
            Supply = shop.ProductStorage;
            ProductPrice = product.DefPrice * MarketPriceMod(product);
            SaleAmount = Math.Min(Supply, Demand);
            shop.ProductStorage -= SaleAmount;
            Income = SaleAmount * ProductPrice;
        }
        public static double MarketPriceMod(Product product)
        {
            return 1 + defMarketPriceMod * (Demand - Supply) / Demand;
        }
    }
}
