using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plesoczki_Á_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            bool van;
            Console.WriteLine("Hány véletlen számot generáljak ?");
            n = Convert.ToInt32(Console.ReadLine());
            int[] vel = new int[n];
            Console.WriteLine();
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                vel[i] = rnd.Next(50,81);
                Console.Write("{0}, ", vel[i]);

            }
            int i = 0;
            while ((i < n) && !(vel[i] % 5 == 2))
                i++;
            van = i < n;
            if (van)
                Console.WriteLine("\nVan a generáltak közül olyan, amely 5-tel osztva 2 -öt ad maradékul ");
            else
                Console.WriteLine("\nNincs a generáltak közül olyan, amely 5-tel osztva 2 -öt ad maradékul ");
            Console.ReadLine();
        }
    }
}
