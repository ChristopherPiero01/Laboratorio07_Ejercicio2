using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp60
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int max = 1000;
            int cont = 0;
            Console.WriteLine("Divores de 3 del 1 al 1000...");
            Console.ReadKey();
            Console.WriteLine();

            do
            {
                if (i % 3 == 0)
                {
                    cont = cont + 1;
                    Console.WriteLine(cont + ") Divisor: " + i);
                }
                i++;
            } while (i <= max);
            Console.ReadKey();
        }
    }
}
