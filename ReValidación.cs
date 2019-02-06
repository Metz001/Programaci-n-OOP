using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicoValidación
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido, es usted humano?, realice la sigueinte operación. Solo tiene 5 intentos");
            Random random = new Random();
            int N1 = random.Next(1, 51);
            int N2 = random.Next(1, 51);
            int intentos = 0;

            while (intentos < 3)
            {
                Console.WriteLine("cuanto es {0} + {1} ", N1, N2);
                int SuRespuesta = int.Parse(Console.ReadLine());
                int suma = N1 + N2;



                if (SuRespuesta != suma)
                {
                    Console.WriteLine("La suma no es {0}", SuRespuesta);
                    intentos++;
                }
                if (SuRespuesta == suma)
                {
                    Console.WriteLine("Bien Hecho, usted es humano, continue");
                    break;
                }


            }
            if (intentos == 3) Console.WriteLine("Intentos Superoados. se cerrará el progrma");
        }
    }
}
