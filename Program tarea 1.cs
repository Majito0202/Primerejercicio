using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su edad");
            int edad = int.Parse(Console.ReadLine());

            Console.WriteLine("Años cumplidos: ");

            for (int i = 1; i <= edad; i++)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
