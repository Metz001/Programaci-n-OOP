using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados1y1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int D1 = random.Next(1, 11);
            int D2 = random.Next(1, 11);
            int puntos = D1 + D2;

            if (D1 == 1 && D2 == 1)
            {
                Console.WriteLine("sacaste 1 en ambos dados, perdiste");
                puntos = -1;
            }

            while (puntos < 100 && puntos > 0)
            {
                Console.WriteLine("Por ahora tines {0} puntos, quieres continuar? s para sí, n para No", puntos);
                int Jugó = 0;
                string respuesta = (Console.ReadLine()

                if (Console.ReadLine() == "s") Jugó++;
                if (Console.ReadLine() == "n") break;
                D1 = random.Next(1, 11);
                D2 = random.Next(1, 11);
                int More6 = 0;
                
                if (D1 + D2 > 6) More6++;
                puntos += D1 + D2;
               
                
               
                if (D1 ==1 && D2 == 1)
                    {
                        Console.WriteLine("sacaste 1 en ambos dados, perdiste");
                    break;
                   
                    }
                int porcentaje = More6 / Jugó * 100;
                Console.WriteLine("El porcentaje de la veces que sacó más de 6 fue {0}", porcentaje);
            }
            if (puntos > 100) Console.WriteLine("Bien Hecho, has sacado la puntuación máxima, (100)");
               


        }
    }
}
