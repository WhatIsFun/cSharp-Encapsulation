using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_PropertiesAndEncapsulation
{
    internal class Product
    {
        private int productId;
        private string name;
        private decimal price;

        public Product(int productId, string name, decimal price)
        {
            this.productId = productId;
            this.name = name;
            this.price = price;
        }

        public void SetProductId(int newProductId)
        {
            productId = newProductId;
        }

        // This method to set the value of the name
        public void SetName(string newName)
        {
            name = newName;
        }

        // This method to set the value of the price
        public void SetPrice(decimal newPrice)
        {
            price = newPrice;
        }

        // This method to get the value of the productId 
        public int GetProductId()
        {
            return productId;
        }

        // This method to get the value of the name
        public string GetName()
        {
            return name;
        }

        // This method to get the value of the product price
        public decimal GetPrice()
        {
            return price;
        }

        // This method to calculate the discounted price
        public decimal GetDiscountedPrice(decimal percentage)
        {
            decimal discount = price * percentage / 100;

            decimal discountedPrice = price - discount;

            return discountedPrice;
        }
    }
}
