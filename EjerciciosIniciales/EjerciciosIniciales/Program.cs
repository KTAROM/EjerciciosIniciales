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
                      int div = num - 1;

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

              // Ejercicio 3

              Console.WriteLine("Ingrese una palabra");
              string palabra = Console.ReadLine();
              int cantlet = palabra.Length;
              int d = cantlet-1;

              char[] letras = new char[cantlet];
              for ( int i=0; i<cantlet; i++)
              {                
                  letras[i] = palabra[d];
                  d -= 1;

              }

              string palabra2 = new string(letras);
              if(palabra==palabra2)
              { Console.WriteLine("Es palíndromo"); }
              Console.ReadKey();

            // Ejercicio 4

            Console.WriteLine("Escriba una palabra");
            string palabra1 = Console.ReadLine();
            Console.WriteLine("Escriba una palabra");
            palabra2 = Console.ReadLine();
            if (palabra1.Length==palabra2.Length)
            {
                char[] pal = new char[palabra1.Length];
                d = palabra1.Length - 1;
                    for(int i=0; i<palabra1.Length; i++)
                {
                    pal[i] = palabra1[d];
                    d -= 1;
                }
                string pal1 = new string(pal);
                if (palabra2 == pal1)
                {
                    Console.WriteLine("Son un anagrama");
                }
                Console.WriteLine("No son un anagrama");
            }


        }
    }
}
   