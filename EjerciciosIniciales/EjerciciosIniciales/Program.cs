using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosIniciales
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicios Iniciales 1
            int num = 1;
            string imprimir = "";
           for (num = 1; num <= 465; num++)
            {
                imprimir += num;
                if (num % 5 == 0 && num % 3 == 0)
                {
                    imprimir += "FooBar";
                }
                else
                {
                    if (num % 3 == 0)
                    { imprimir += "Foo"; }
                    else
                    {
                        if (num % 5 == 0)
                            imprimir += "Bar";
                    }
                }
                imprimir += "\n";
            }
            Console.WriteLine(imprimir);
            Console.ReadKey();
            //Ejercicios inciales 2

           num = 1;
            imprimir = "";
            for (num = 1; num <= 465; num++)
            {
                imprimir += num;
                if (num % 3 == 0)
                {
                    imprimir += " es divisible por 3";
                }

                else
                {
                    int prueba = 1;
                    int div = num-1;

                    while (prueba > 0 && div > 1)
                    {
                        prueba = num % div;
                        div -= 1;
                        
                    }
                    if (prueba != 0)
                    {
                        imprimir += " es primo";
                    }

                }
                imprimir += "\n";
            }
            Console.WriteLine(imprimir);
            Console.ReadKey();
        }
    }
}
   