using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace Industry
{
    class ProductsKeyed : KeyedCollection<int, Product>
    {
        protected override int GetKeyForItem(Product item)
        {
            return item.Id;
        }
    }
}
    /*
    public abstract class TT<T>
    { public abstract int GetKeyForItem { get; set; } }
    class ProductsKeyedT <int, T> : KeyedCollection<int, T>
    {
        protected override int GetKeyForItem(T item)
        {
            return item.GetKeyForItem;
        }
    }
}
*/