using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int anno, op, edad;
            string nombre;
            op = 0;    
            nombre = "";
            edad = 0;   
            anno = 0;

            while (op !=4)
            {
                Console.Clear(); 
                Console.WriteLine("1.INGRESAR");
                Console.WriteLine("2.CALCULAR");
                Console.WriteLine("3.MOSTRAR");
                Console.WriteLine("4.SALIR");

                Console.WriteLine("Ingrese la opcion deseada: ");
                op = int.Parse(Console.ReadLine());
                switch (op) /*nombre de variable*/
                {
                    case 1:
                        Console.WriteLine("ingrese el nombre");
                        nombre = Console.ReadLine();

                        Console.WriteLine("Ingrese el año de nacimineto");
                        anno = int.Parse(Console.ReadLine());

                        break;

                    case 2:
                        edad = 2023 - anno;

                        break;

                    case 3:
                        Console.WriteLine(nombre + "su edad es de" + edad + "años  " );
                        break;
                    case 4:
                        op = 4;
                        Console.WriteLine("saliendo....");
                        break;

                    default:
                        Console.WriteLine("el valor ingresado no es valido. Ingresa valores del 1 al 4");
                        break;


                }
                Console.ReadKey();  
            }

        
        }

    }
}
/*para hacerlo todo en una linea seria Console.writeLine("1.INGRESAR\n  2.Calcular ")*/