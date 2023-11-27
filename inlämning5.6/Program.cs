using System;
namespace inlämning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in tal");
            int produkt = 1;
            string svar = Console.ReadLine();
            string[] faktorer = svar.Split('*');
            for(int i = 0; i < faktorer.Length; i++)
            {
                produkt *= int.Parse(faktorer[i]);
            }
            Console.WriteLine(produkt);
        }
    }
}