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
            /* for (num = 1; num <= 465; num++)
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
             int d = cantlet - 1;

             char[] letras = new char[cantlet];
             for (int i = 0; i < cantlet; i++)
             {
                 letras[i] = palabra[d];
                 d -= 1;

             }

             string palabra2 = new string(letras);
             if (palabra == palabra2)
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
                 if (palabra1 == palabra2)
                 {
                     Console.WriteLine("Son anagramas");
                 }
                 else { Console.WriteLine("No son anagramas"); }
             }


             //Ejercicio 5
             Console.WriteLine("Escriba un número de 5 cifras");
             string numero = Console.ReadLine();
            char[] numero1= Armarchar(numero);
             numero1 = (OrdenarNum(numero1));
             numero = new string(numero1);
             int num1 = int.Parse(numero);
             Console.WriteLine("El número invertido es: "+num1);

            // Ejercicio6
            Console.WriteLine("Ingrese el primer número");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine((num1 + num2) * (num1 - num2));

            // Ejercicio 7

            int[] numero = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese el número " + (i + 1));
                numero[i] = int.Parse(Console.ReadLine());
            }
            int maximo = Maximo(numero);
            int minimo = Minimo(numero);
            numero = Ordenar2(numero);
            int medio = numero[2];
            Console.WriteLine("El número máximo es " + maximo + "\n" + "El número intermedio es " + medio + "\n" + "El número mínimo es " + minimo);
            
            //Ejercicio 8

            Console.WriteLine("Ingrese una fecha");
            DateTime fecha = DateTime.Parse(Console.ReadLine());
            DateTime hoy = DateTime.Now;
            Console.WriteLine(fecha);
            Console.WriteLine(hoy);
           int diferencia = (hoy - fecha).Days;
            Console.WriteLine("La diferencia de fecha es de " + diferencia + " días");
            
            //Ejercicio 9
            Console.WriteLine("Ingrese su nombre");
            string usuario1 = "Romina";
            string usuario = Console.ReadLine();
            ValidarUsuario(usuario,usuario1);

            // Ejercicio 10

           Caracter();
            string car = Console.ReadLine().ToUpper();
          
            Verificar(car);*/

            // Ejercicio 11
            Console.WriteLine("Ingrese Nombre, Apellido y edad");
            string datos = Console.ReadLine();
            string[] separar = datos.Split(' ');
            string nombre;
            string apellido;
            int edad = 0;
            int d = 0;
            string[] nombres = new string[2];

           for(int i=0; i<3;i++)
            {
                bool esnum = Esnum(separar[i]);
                if(esnum)
                {
                    edad = int.Parse(separar[i]);
                }
                else
                {
                   
                    nombres[d] = separar[i];
                    d += 1;
                }
              
            }
            
            Console.WriteLine("Edad: " + edad +", Nombre: " + nombres[0] + ", Apellido: " + nombres[1]);





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

        public static char[] OrdenarNum(char[] num)
        {
            int j = num.Length - 1;
            int i = 0;
            while (i < j)
            {
                do
                {
                    char aux = num[i];
                    num[i] = num[j];
                    num[j] = aux;
                    i += 1;
                    j -= 1;
                } while (i > j);
            }

            return num;
        }
        public static int Maximo(int[] num)
        {

            int cant = num.Length - 1;
            int max = num[cant];

            for (int i = 0; i <= cant; i++)
            {
                if (num[i] > max)
                {
                    max = num[i];

                }
            }
            return max;



        }
        public static int Minimo(int[] num)
        {

            int cant = num.Length - 1;
            int min = num[cant];

            for (int i = 0; i <= cant; i++)
            {
                if (num[i] < min)
                {
                    min = num[i];

                }
            }
            return min;


        }
        private static int[] Ordenar2(int[] num)
        {
            int cant = num.Length;
            for (int j = 0; j < cant; j++)
            {
                for (int i = 0; i < cant - 1; i++)
                {
                    if (num[i] > num[i + 1])
                    {
                        int aux = num[i];
                        num[i] = num[i + 1];
                        num[i + 1] = aux;
                    }
                }
            }
            return num;
        }
       static void ValidarUsuario (string usuario, string usuario1)
        {
            if(usuario!=usuario1)
            {
                Console.WriteLine("No te conozco");
            }
            else
            {
                Console.WriteLine("Hola, " + usuario + "!");
            }
        }
       
        public static void Caracter()
        {
            Console.WriteLine("Ingrese un caracter");
        }
        static void Verificar(string car)
        {
            int num;

            bool Esnum = int.TryParse(car, out num);
            if (Esnum)
            {
                Console.WriteLine("El valor ingresado es una cifra númerica");
            }
            else
            {
                if (car == "A" || car == "E" || car == "I" || car == "O" || car == "U")
                {
                    Console.WriteLine("El valor ingresado es una vocal");
                }
                else
                {
                    Console.Write("El valor ingreso es una consonante");
                }
            }
        }

            public static bool Esnum(string valor)
            {
                int num;

                bool Esnum = int.TryParse(valor, out num);
                return Esnum;
            }

        }
    }



    