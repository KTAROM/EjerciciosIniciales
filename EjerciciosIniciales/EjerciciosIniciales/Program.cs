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
            //Ejercicios Iniciales 1: Multiplos
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

             //Ejercicios inciales 2: Números Primos

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

             // Ejercicio 3: Palíndromo

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

             // Ejercicio 4: Anagrama

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


             //Ejercicio 5: Número Invertido
             Console.WriteLine("Escriba un número de 5 cifras");
             string numero = Console.ReadLine();
            char[] numero1= Armarchar(numero);
             numero1 = (OrdenarNum(numero1));
             numero = new string(numero1);
             int num1 = int.Parse(numero);
             Console.WriteLine("El número invertido es: "+num1);

            // Ejercicio 6: Cuentas
            Console.WriteLine("Ingrese el primer número");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine((num1 + num2) * (num1 - num2));

            // Ejercicio 7: Máximo y mínimo

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
            
            //Ejercicio 8: Diferencia hoy

            Console.WriteLine("Ingrese una fecha");
            DateTime fecha = DateTime.Parse(Console.ReadLine());
            DateTime hoy = DateTime.Now;
            Console.WriteLine(fecha);
            Console.WriteLine(hoy);
           int diferencia = (hoy - fecha).Days;
            Console.WriteLine("La diferencia de fecha es de " + diferencia + " días");
            
            //Ejercicio 9: Nombre usuario
            Console.WriteLine("Ingrese su nombre");
            string usuario1 = "Romina";
            string usuario = Console.ReadLine();
            ValidarUsuario(usuario,usuario1);

            // Ejercicio 10: Caracter

           Caracter();
            string car = Console.ReadLine().ToUpper();
          
            Verificar(car);

            // Ejercicio 11: Datos persona

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
            
            // Ejercicio 12: Diferencia fechas
           
                Console.WriteLine("Ingrese una fecha");
                DateTime fecha1 = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese una fecha");
            DateTime fecha2 = DateTime.Parse(Console.ReadLine());
            int fecharesul = DateTime.Compare(fecha1, fecha2);
            int años;
            int meses;
            int dias;
          
           if(fecharesul<0)
            {
                DateTime aux = fecha1;
                fecha1 = fecha2;
                fecha2 = aux;
            }
            
            años = fecha1.Year - fecha2.Year;
            meses = fecha1.Month - fecha2.Month;

            if (fecha1.Month<fecha2.Month)
            {
                meses +=12;
                años -= 1;
            }
            dias = fecha1.Day - fecha2.Day;

                 if(fecha1.Day < fecha2.Day)
            {
                dias += DateTime.DaysInMonth(fecha1.Year, (fecha1.Month-1)); 
                meses -= 1;
            }
            Console.WriteLine("La diferencia es de "+años+ " años, "+meses+" meses, "+dias+" días");
            
            //Ejercicio 13: Factorial

            Console.WriteLine("Ingrese un número");
            num = int.Parse(Console.ReadLine());
            int factorial = 1;
            for(int i=1; i<=num;i++)
            {
                factorial = factorial * i;
            }
            Console.WriteLine("El factorial de "+num+" es: "+factorial);
            
            //Ejercicio 14: Tabla multiplicar

            Console.WriteLine("Ingrese un número");
            num = int.Parse(Console.ReadLine());
            int producto;
            for(int i=1; i<=10;i++)
            {
                producto = i * num;
                imprimir += (num + " X " + i + " = " + producto+"\n");
            }
            Console.WriteLine(imprimir);
            

            //Ejercicio 15:Clave
            
            string clave = "Romina";
            string clave1;
            int i = 0;
            do
            {
                Console.WriteLine("Ingrese la clave de usuario");
                clave1 = Console.ReadLine().ToUpper();
                string compara = clave.ToUpper();
                if (compara == clave1)
                {
                    Console.WriteLine("Bienvenido, " + clave);
                    i = 3;
                }
                else
                {
                    
                        i += 1;

                    if(i==3)
                    {
                        Console.WriteLine("Clave bloqueada");
                    }
                    else
                    {
                        Console.WriteLine("Acceso denegado. La contraseña no es correcta. ");
                    }
                }
            } while (i < 3);
            

            // Ejercicio 16:Contar dígitos
            Console.WriteLine("Ingrese un número");
            string valor = Console.ReadLine();
            int cant = valor.ToString().Length;

            Console.WriteLine("Número ingresado: " + valor + " - Tiene " + cant + " dígitos");
         
            
            // Ejercicio 17: Sueldo Mayor
            string[,] Sueldos = new string[5, 2];
            for (int i = 0; i < 5; i++)
            {
                int f = 0;
                Console.WriteLine("Ingrese el nombre de un empleado");
                Sueldos[i, f] = Console.ReadLine();
                Console.WriteLine("Ahora ingrese su salario");
                f += 1;
                Sueldos[i, f] = Console.ReadLine();
            }

            int max = int.Parse(Sueldos[4, 1]);
            int cont = 4;
            for (int i = 0; i < 5; i++)
            {
                if (int.Parse(Sueldos[i, 1]) > max)
                {
                    max = int.Parse(Sueldos[i, 1]);
                    cont = i;
                }
            }
            Console.WriteLine("El mayor sueldo es: " + Sueldos[cont, 1] + " del empleado " + Sueldos[cont, 0]);
            */

            
            
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



    