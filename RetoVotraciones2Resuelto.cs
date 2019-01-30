using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    /*
     * Si el total de votos es superior a la población, O la diferencia de votos entre el partido 1
     * y el partido 2 es menor al 10% de los votos totales Y el Número de votantes es inferior al 30% de la población
     * 
     * a: número de votos por el partido 1

        b: número de votos por el partido 2

        blancos: número de votos en blanco

        anulados: número de votos anulados

        n: número total de la población de todas las edades

        p: el porcentaje (de 0 a 100%) de la población que es mayor de edad


           while (esCorrecto == false)
            {
                try
                {
                    Console.Write("Ingresa un numero entero positivo: ");
                    numero = long.Parse(Console.ReadLine());

                    //Validamos que sea entero positivo hasta 4 cifras
                    if (numero > 0 )
                        esCorrecto = true;
                    else
                        Console.WriteLine("El dato ingresado no es un entero positivo. Intenta nuevamente! \n");

     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para la comprovación de datos de las eleciones");


            bool RepetirVotaciones = true;

            while (RepetirVotaciones == true)
            {
                try
                {
                    Console.WriteLine("Ingrese la población total de habitantes");
                    double n = double.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese el porcentaje de la población que puede votar");
                    double p = double.Parse(Console.ReadLine());

                    double Votantes = p * n / 100;
                    if (p > 100)
                        p = 100;

                    Console.WriteLine("ingrese los votos del partido 1");
                    double Partido1 = double.Parse(Console.ReadLine());

                    Console.WriteLine("ingrese los votos del partido 2");
                    double Partido2 = double.Parse(Console.ReadLine());

                    Console.WriteLine("ingrese los votos en blanco");
                    double Blanco = double.Parse(Console.ReadLine());

                    Console.WriteLine("ingrese los votos nulos");
                    double Nulos = double.Parse(Console.ReadLine());

                    double DifPartidos = Partido1 - Partido2;
                    if (DifPartidos < 0)
                        DifPartidos = DifPartidos * -1;

                    double totalVotos = Partido1 + Partido2 + Blanco;

                    double DiezPercentVotos = totalVotos * 10 / 100;

                    double treintaPoblacion = n * 30 / 100;

                    if (totalVotos > Votantes || DifPartidos <DiezPercentVotos && Votantes < treintaPoblacion )
                    {

                        Console.WriteLine("Se ha presentado el siguiente problema en las eleciones \n");
                        if (totalVotos > Votantes)
                        {
                            Console.WriteLine("el total de votos es mayor al númeor de votantes. Repetir eleciones o hacer un reconteo \n");
                        }

                        if (DifPartidos < DiezPercentVotos && Votantes < treintaPoblacion)

                            Console.WriteLine("La diferencia de votos entre el partido 1 y el partido 2 es menor al 10% de los votos totales Y el Número de votantes es inferior al 30% de la población");
                        RepetirVotaciones = true;
                     
                    }

                  

                    else
                    {

                        Console.WriteLine("Las eleciones han sido un éxito");
                        if (Partido1 > Partido2)
                        {
                            Console.WriteLine("El partido1 es el victorioso \n");
                        }


                        Console.WriteLine("Las eleciones han sido un éxito");
                        if (Partido2 > Partido1)
                        {
                            Console.WriteLine("El partido1 es el victorioso \n");
                        }
                        RepetirVotaciones = false;
                    }
                }

                catch (FormatException error)
                {
                    Console.WriteLine("Ingresaste un dato no numérico. Intenta nuevamente!");
                    Console.WriteLine("Error: " + error.Message + "\n");
                }
            }






        }
    }
}
