
using System;

namespace HomeWork._04._05._22
{
    class Program
    {
        static void Main(string[] args)
        {
            Milk AzerSud = new Milk("AzerSud", 5, 1.0, 10.0);
            Milk AzerSud1 = new Milk("AzerSud1", 5, 1.0, 10.0);
            Milk AzerSud2= new Milk("AzerSud2", 3, 1.0, 10.0);
            AzerSud.Sell();
            AzerSud1.Sell();
            AzerSud2.Sell();
            AzerSud.TotalInCome();
        }

    }
}
