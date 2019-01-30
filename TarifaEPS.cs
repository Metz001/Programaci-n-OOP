using System;

namespace TarifaMedica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para calcular su tarifa de EPS");
            Console.WriteLine("Por favor ingrese su salario");
            double salario = double.Parse(Console.ReadLine());
            bool A = false;
            bool B = false;
            bool C = false;
            double tarifa = 4000;

            if(salario < 1656232)
            {
                A = true;
            }

            if(salario >= 1656232 && salario < 3312464)
            {
                B = true;
                tarifa = tarifa * 1.4;

            }

            if(salario >= 3312464)
            {
                C = true;
                tarifa = tarifa * 1.6;
            }

            if(A == true)
            {
                Console.WriteLine("Su cuota moderadora es de 3200 y su tarifa es de " + tarifa);
            }

            if (B == true)
            {
                Console.WriteLine("Su cuota moderadora es de 12700 y su tarifa es de " + tarifa);
            }

            if (C == true)
            {
                Console.WriteLine("Su cuota moderadora es de 33500 y su tarifa es de " + tarifa );
            }
        }
    }
}
