﻿using System;
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
            if (palabra1.Length == palabra2.Length)
            {

                char[] pal = Armarchar(palabra1);
                char[] pal2 = Armarchar(palabra2);
                palabra1 = Ordenar(palabra1, pal);
                palabra2 = Ordenar(palabra2, pal2);
                if(palabra1==palabra2)
                {
                  Console.WriteLine("Son anagramas");
                }
                else { Console.WriteLine("No son anagramas"); }
            }

            Console.ReadKey();
        }

        private static char[] Armarchar(string palabra)
        {
            int cant = palabra.Length;
            char[] pal = new char[cant];
            for (int i = 0; i < cant; i++)
            {
                pal[i] = palabra[i];
            }
            return pal;

        }
        private static string Ordenar(string palabra, char[] pal)
        {
            int cant = palabra.Length;
            for (int j = 0; j < cant; j++)
            {
                for (int i = 0; i < cant - 1; i++)
                {
                    if (pal[i] > pal[i + 1])
                    {
                        char aux = pal[i];
                        pal[i] = pal[i + 1];
                        pal[i + 1] = aux;
                    }
                }

            }
            string palordenada = new string(pal);
            return palordenada;
        }
    }
}
    