using System;
using System.Collections.Generic;
using System.Text;

namespace Industry
{
    class Production
    {
        private static readonly int defProduction = 1;

        public static int Produce (Factory factory, Product product)
        {
            switch (product.productGroup)
            {
                case 1:
                    return defProduction * factory.factoryDefProduction;
                default:
                    return 0;
            }
        }
    }
}
