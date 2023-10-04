using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Números del 1 al 10 al revés:");

            for (int i = 10; i >= 1; i--)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();  
        }
    }
}
