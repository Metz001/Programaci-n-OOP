using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego_de_dados
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            Console.WriteLine("Bienvenido Jugador");
            int total = 0;
            if (total < 100)
            {

                int dado1 = aleatorio.Next(1, 7);
                int dado2 = aleatorio.Next(1, 7);
                total = dado1 + dado2;
                double moreSix = 0;
                int lanzamientos = 0;
                while (dado1+dado2 !=2 && total<100)
                {
                    Console.WriteLine("Su primer dado sacó: {0} | su segundo dado sacó: {1} | su total de puntos es {2}", dado1, dado2, total);
                    Console.WriteLine("Siguiente lanzamiento, presione cualquier tecla");
                    lanzamientos += 1;
                    string repsuesta = Console.ReadLine();
                    dado1 = aleatorio.Next(1, 7);
                    dado2 = aleatorio.Next(1, 7);
                    if (dado1 + dado2 >= 6)
                        moreSix += 1;
                    
                    total += dado1 + dado2;
                    if (total >= 100)
                    {
                        Console.WriteLine("Ya has sacado la máxima cantidad de puntos, bien hehco");
                        break;

                    }
                    
                    
                }
                if (dado1+dado2==2)
                Console.WriteLine("Has sacado 1 en ambos dados, perdiste");
                Console.WriteLine("Tu total de puntos fue de {0}", total);
                double percentSix = (moreSix * 100) / lanzamientos;
                Console.WriteLine("el porcentaje de veces que sacaste más de 6 fue de {0}", percentSix);

            }
            
            

           
        }
    }
}
