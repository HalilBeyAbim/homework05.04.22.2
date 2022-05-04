using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork._04._05._22
{
    class Milk : Product
    {
        public double Voulme;
        public double FatRate;
        static Milk()
        {
            Count = 10;
            Totalincome = 0;
            
        }
        public Milk(string name, double price, double voulme, double fatrate) : base(name, price)
        {
            Voulme = voulme;
            FatRate = fatrate;
        }

        public override void Sell()
        {
            if (Count > 0)
            {
                Count--;
                Totalincome += Price;
                Console.WriteLine($"Qalan mehsul sayi: {Count}");
                //Console.WriteLine($"Satisdan gelen umumi gelir: {Totalincome}");
                Console.WriteLine($"satilan litr: {Voulme}");
            }
            else
            {
                Console.WriteLine("sene yoxdu;) ");
            }
        }
        public override void TotalInCome()
        {
            Console.WriteLine($"Satisdan gelen umumi gelir: {Totalincome}");
        }
       
    }
}
