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
            int total = 0, vidas = 2, unos = 0, life= 0;
          

            if (vidas > 0)
            {

                int dado1 = aleatorio.Next(1, 7);
                total = dado1;                               
                while (vidas != 0)
                {
                    
                    Console.WriteLine("Su primer dado sacó: {0} | su total de puntos es {1} | le quedan {2} vidas", dado1, total, vidas);
                    Console.WriteLine("Siguiente lanzamiento, ¿Desea Continuar? (S/N)");
                    string continuar = Console.ReadLine();
                    if (continuar != "s") break;
                    dado1 = aleatorio.Next(5, 7);
                    if (dado1 == 6) life += 1;
                    else 
                    {
                         life = 0;
                    }
                    if (life == 2)
                    {
                        vidas += 1;
                        life = 0;
                    }              
                    if (dado1 == 1) unos += 1;
                    if (unos == 2)
                    {
                        vidas -= 1;
                        total -= 10;
                        unos = 0;
                    }
                    if (vidas > 3) vidas = 3;                  
                    total += dado1;
                }
                if (vidas < 1)
                    Console.WriteLine("Te has queado sin vidas , perdiste");
                Console.WriteLine("Tu total de puntos fue de {0}", total);
                
            }




        }
    }
}
