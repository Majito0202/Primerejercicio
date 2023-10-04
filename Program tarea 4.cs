using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string emailCorrecto = "admin@admin.com";
            string contrasenaCorrecta = "123";
            int intentosMaximos = 3;
            int intentos = 0;

            do
            {
                Console.Write("Ingrese su email: ");
                string email = Console.ReadLine();

                Console.Write("Ingrese su contraseña: ");
                string contrasena = Console.ReadLine();

                intentos++;

                if (email == emailCorrecto && contrasena == contrasenaCorrecta)
                {
                    Console.WriteLine(" Acceso permitido.¡Credenciales correctas!");
                    break;
                }
                else
                {
                    Console.WriteLine("Credenciales incorrectas. Intento {0} de {1}.", intentos, intentosMaximos);
                }

            } while (intentos < intentosMaximos);

            if (intentos >= intentosMaximos)
            {
                Console.WriteLine("Máximos de intentos. Acceso denegado.");
            }
            Console.ReadKey();
        }
    }
}
