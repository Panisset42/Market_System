using System;

namespace Market_System
{
    internal class Product
    {
        public string ProductName { get; }
        public int ProductCode { get; }
        public float ProductPrice { get; }
        public int ProductAmount { get; }

        public Product(string productName, int productCode, float productPrice, int productAmount)
        {
            ProductName = productName;
            ProductCode = productCode;
            ProductPrice = productPrice;
            ProductAmount = productAmount;
        }
    }
}
