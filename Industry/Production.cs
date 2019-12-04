using System;
using System.Collections.Generic;
using System.Text;

namespace Industry
{
    class Production
    {
        private static readonly int _defProduction = 1;

        public static int Produce (Factory factory, Product product)
        {
            switch (product.Group)
            {
                case 1:
                    return _defProduction * factory.DefProduction;
                default:
                    return 0;
            }
        }
    }
}