using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork._04._05._22
{
    abstract class Product
    {
        public string Name;
        public double Price;
        public static int Count;
        public static double Totalincome;
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
        public abstract void Sell();
        public abstract void TotalInCome();
    }
}
