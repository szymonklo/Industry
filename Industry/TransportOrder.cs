using System;
using System.Collections.Generic;
using System.Text;

namespace Industry
{
    class TransportOrder
    {
        public TransportOrder(Facility sender, Facility receiver, ProductType productType, int capacity)
        {
            bool readyToSend = false;
            bool readyToReceive = false;
            bool addNewProduct = false;
            Product productToSend = null;
            Product productToReceive = null;

            foreach (Product product in sender.ProductsOut)
            {
                if (product.Id == productType.Id)
                {
                    readyToSend = true;
                    productToSend = product;
                }
            }
            foreach (Product product in receiver.ProductsIn)
            {
                if (product.Id == productType.Id)
                {
                    readyToReceive = true;
                    productToReceive = product;
                }
            }
            if (readyToReceive == false)
            {
                {
                    productToReceive = new Product(productType);
                    readyToReceive = true;
                    addNewProduct = true;
                }
            }
            else
                addNewProduct = false;

            if (readyToSend && readyToReceive)
            {
                productToSend.Amount -= capacity;
                productToReceive.Amount += capacity;

                if (addNewProduct == true)
                    receiver.ProductsIn.Add(productToReceive);

                Console.WriteLine("Transported " + capacity + " " + productType.Name + "\n" +
                    "In origin (" + sender.Name + ") left "+ productToSend.Amount + "\n" +
                    "In destination (" + receiver.Name + ") there are " + productToReceive.Amount + "\n");
            }
        }
    }
}