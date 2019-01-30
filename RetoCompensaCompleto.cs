using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetoCompensaciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Deduciones slariales. Este programa te dirá cuamto ganas realmente al restar las deduciones salariales");
            Console.WriteLine("Ingrese su salario actual");
            double smmlv = 828116;
            double salario = double.Parse(Console.ReadLine());
            double cotización = salario * 40 / 100;
            if (salario < smmlv)
            {
                cotización = smmlv * 40 / 100;
            }
            Console.WriteLine("¿caul es su tipo de contrato?, Tipo de contrato: 1. dependiente | 2. independiente");
            Console.WriteLine("ingrese 1 para depndiente, y 2 para contrato independiente");
            double contrato = double.Parse(Console.ReadLine());




            //Si y sólo si el tipo de contrato es independiente se pide que se ingrese un número de 1 a 5 equivalente a la clase del riesgo.
            if (contrato == 1 || contrato == 2)
            {
                        if (contrato == 1)
                        {
                            double pension = 4 * cotización / 100;
                            double eps = 4 * cotización / 100;
                            double arl = 0;
                            double prima = salario;

                            Console.WriteLine("Las dedudciones que recibirá son: \n");

                            Console.WriteLine("Pension {0}", pension * -1);
                            Console.WriteLine("Eps {0}", eps * -1);
                            Console.WriteLine("Arl {0}", arl);
                            Console.Write("total deduciones = {0}", pension + eps + arl);
                            Console.WriteLine("su salario real corresponde a {0}", salario - pension - eps - arl);
                            Console.WriteLine("su salario anuel sin deducciones más prima corresponde a {0}", salario * 12 + salario);

                        }

                        if (contrato == 2)
                        {
                    Console.WriteLine("Seleccione el riesgo de 1 a 5 de la actividad que va a desempeñar basado en la lista que se presenta a continuación: ");
              
                    Console.WriteLine("1. Financieras, trabajos de oficina, administrativos, centros educativos, restaurantes");
                    Console.WriteLine("2. Algunos procesos manufactureros como fabricación de tapetes, tejidos, confecciones y flores artificiales, almacén por departamentos, algunas labores agrícolas.");
                    Console.WriteLine("3. Algunos procesos manufactureros como la fabricación de agujas, alcoholes y artículos de cuero");
                    Console.WriteLine("4. Procesos manufactureros como fabricación de aceites, cervezas, vidrios, procesos de galvanización, transportes y servicios de vigilancia privada.");
                    Console.WriteLine("5. Areneras, manejo de asbesto, bomberos, manejo de explosivos, construcción y explotación petrolera.");
                    double riesgo = double.Parse(Console.ReadLine());


                    if (riesgo == 1)
                        riesgo = 0.522;

                    if (riesgo == 2)
                        riesgo = 1.044;

                    if (riesgo == 3)
                        riesgo = 2.436;

                    if (riesgo == 4)
                        riesgo = 4.350;

                    if (riesgo ==5)
                        riesgo = 6.960;

                    double pension = 16 * cotización / 100;
                     double eps = 12.5 * cotización / 100;
                    double arl = riesgo * cotización / 100;

                    Console.WriteLine("Pension {0}", pension * -1);
                    Console.WriteLine("Eps {0}", eps * -1);
                    Console.WriteLine("Arl {0}", arl);
                    Console.Write("total deduciones = {0}", pension + eps + arl);
                    Console.WriteLine("su salario real corresponde a {0}", salario - pension - eps - arl);
                    Console.WriteLine("su salario anuel sin deducciones más prima corresponde a {0}", salario * 12 + salario);



                }
                       
                    



                  
                
                    
                    
                   
              



            }

            



        }
    }
}
