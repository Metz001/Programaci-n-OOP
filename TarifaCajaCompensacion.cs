using System;

namespace Precios
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Programa para calcular su tarifa de caja de compensación familiar");
            Console.WriteLine("Por favor ingrese su salario");
            double salario = double.Parse(Console.ReadLine());
            bool A = false;
            bool B = false;
            bool C = false;
            double tarifa = 30000;
            double porcentaje = (salario * 4) / 100;

            if (salario < 1656232)
            {
                A = true;
            }

            if (salario >= 1656232 && salario < 3312464)
            {
                B = true;
                tarifa = tarifa * 1.4;
            }

            if (salario >= 3312464)
            {
                C = true;
                tarifa = tarifa * 1.6;
            }

            double resultado = tarifa + porcentaje;

            if (A == true)
            {
                Console.WriteLine("Usted está en la categoría A, por lo que su tarifa es: " + tarifa + ", Y debe pagar: " + resultado);
            }

            if (B == true)
            { 
            Console.WriteLine("Usted está en la categoría B, por lo que su tarifa es: " + tarifa + ", Y debe pagar: " + resultado);
            }

            if (C == true)
            {

                Console.WriteLine("Usted está en la categoría C, por lo que su tarifa es: " + tarifa + ", Y debe pagar: " + resultado);
            }
        }
    }
}
