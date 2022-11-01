using System;

namespace GenericsProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //******Crate array****//
            HeroTable<Knight> HT = new HeroTable<Knight>(4);
            Knight k1 = new Knight(1, "A", 1.90);
            Knight k2 = new Knight(2, "B", 1.95);
            Knight k3 = new Knight(3, "C", 2.10);
            Knight k4 = new Knight(2, "D", 2.15);

            //******Set function*****///
            HT.Set(0, k1);
            HT.Set(1, k2);
            HT.Set(2, k3);
            HT.Set(3, k4);
            Console.WriteLine(HT.Count());

            //*****Delete function*****//
            HT.Delete(1);
            Console.WriteLine(HT.Count());

            //*******GetHero function****//
            HeroTable<Knight> HT2 = new HeroTable<Knight>(HT.Count());
            HT2.Heroes = HT.GetHeros();
            Console.WriteLine(HT2.Count());

            //*******Out of range index*****//
            Console.WriteLine(HT[4]);
            Console.WriteLine(HT[5]);
            Console.WriteLine(HT[6]);
        }
    }
}