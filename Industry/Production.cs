﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Industry
{
    class Production
    {
        private static readonly int _defProduction = 1;
        private static bool AreComponents { get; set; }

        public static int Produce (Factory factory, Product product)
        {
            if (product.Components == null)
                AreComponents = true;
            else
            {
                foreach (Product component in product.Components)
                {
                    foreach (Product factoryComponent in factory.Components)
                    {
                        if (component.Id == factoryComponent.Id)
                        {
                            AreComponents = true;
                            break;
                        }
                    }
                    AreComponents = false;
                    break;

                }
            }

            if (AreComponents)
            {
                switch (product.Group)
                {
                    case 1:
                        return _defProduction * factory.DefProduction;
                    default:
                        return 0;
                }
            }
            else
                return 0;
        }
    }
}