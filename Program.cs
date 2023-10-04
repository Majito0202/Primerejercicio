using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int i, cantidad;
            string nombre;
            i = 1;

           
            Console.WriteLine("Ingrese la cantidad de estudiantes");
            cantidad =int.Parse(Console.ReadLine());

            while (i<= cantidad)
            {
                Console.WriteLine("ingrese el nombre de estudiantes");
                nombre = Console.ReadLine();

                i=i+1;  
            } */

            int cantidad;
            Console.WriteLine("ingrese la cantidad deseada");
            cantidad = int.Parse(Console.ReadLine());

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Hola");
            }
            
            Console.ReadKey();
        }
    }
}
