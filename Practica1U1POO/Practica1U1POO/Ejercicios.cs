using System;
using System.Collections.Generic;
using System.Text;

namespace Practica1U1POO
{
    /// <summary>
    /// Declarar mi clase ejercicios, donde agregare metodos que me realicen lo que se me pide en los 20 ejercicios///
    /// </summary>
    class Ejercicios
    {/// <summary>
     /// Declarar el metodo como publico///
     /// </summary>
        public static void sumaPorteclado()
        {
            ///Declarar tres variables con tipo de dato double e igualados a 0///
            double num1 = 0, num2 = 0, total = 0;
            ///Pedir por mensaje al usuario que ingrese un numero///
            Console.WriteLine("Ingrese un numero");
            ///Leer por teclado un numero y guardarlo en la primer variable///
            num1 = double.Parse(Console.ReadLine());
            ///Pedir por mensaje que se ingrese un segundo numero///
            Console.WriteLine("Ingrese un segundo numero");
            ///Leer por teclado y guardar el numero en la segunda variable///
            num2 = double.Parse(Console.ReadLine());
            ///Realizar una suma de las dos variables y guardar el total en una tercera variable///
            total = num1 + num2;
            ///Imprimir el valor de la tercer variable por mensaje///
            Console.WriteLine("El total de su suma es " + total);

        }
        public static void suma100porteclado()
        {
            double num = 0, total = 0;
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Ingrese un numero");
                num = double.Parse(Console.ReadLine());
                total = total + num;
            }
            Console.WriteLine("El total de su suma es " + total);
        }
        public static void sumaNnumeros()
        {
            int n = 0;
            double num = 0, total = 0;
            Console.WriteLine("Ingrese la cantidad de numeros que desea sumar");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Ingrese un numero");
                num = double.Parse(Console.ReadLine());
                total = total + num;
            }
            Console.WriteLine("El total de su suma es " + total);
        }
        public static void primeros100Pares()
        {
            int i;
            Console.WriteLine("Vamos a imprimir los 100 primeros pares");
            for (i = 1; i < 201; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        public static void imprimirNimpares()
        {
            int i;
            int n = 0;
            Console.WriteLine("Vamos a imprimir numeros impares");
            Console.WriteLine("Ingrese la cantidad de numeros que desea evaluar");
            n = int.Parse(Console.ReadLine());
            for (i = 1; i < n; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        public static void imprimirNpares()
        {
            int i;
            int n = 0;
            Console.WriteLine("Vamos a imprimir numeros pares");
            Console.WriteLine("Ingrese la cantidad de numeros que desea evaluar");
            n = int.Parse(Console.ReadLine());
            for (i = 1; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        public static void imprimirNmultiplos3()
        {
            int i;
            int n = 0;
            Console.WriteLine("Vamos a imprimir numeros multiplos de 3");
            Console.WriteLine("Ingrese la cantidad de numeros que desea evaluar");
            n = int.Parse(Console.ReadLine());
            for (i = 1; i < n; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        public static void sumaImparesypares()
        {
            int i;
            int pares = 0;
            int impares = 0;
            int n = 0;
            Console.WriteLine("Vamos a realizar sumas de pares e impares");
            Console.WriteLine("Ingrese la cantidad de numeros que desea evaluar");
            n = int.Parse(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    pares = pares + i;
                }
                else
                {
                    impares = impares + i;
                }
            }
            Console.WriteLine("La suma de los numeros impares es " + impares);
            Console.WriteLine("La suma de los numeros pares es " + pares);
        }
        public static void decimalaBinario()
        {
            double numero = 0;
            Console.WriteLine("Ingrese un numero decimal");
            numero = double.Parse(Console.ReadLine());
            if (numero > 0)
            {
                string cadena = "";
                while (numero > 0)
                {
                    if (numero % 2 == 0)
                    {
                        cadena = "0" + cadena;
                    }
                    else
                    {
                        cadena = "1" + cadena;
                    }
                }
                Console.WriteLine(cadena);
            }
            else
            {
                if (numero == 0)
                {
                    Console.WriteLine("0");
                }
            }
        }
        public static void entre0Y999()
            {
            int numero = 0;
           do
            {
                Console.WriteLine("Escriba un numero entre 0 y 999");
                numero = int.Parse(Console.ReadLine());
                if (numero < 100)
                {
                    if (numero > 10)
                    {
                        Console.WriteLine("Este numero tiene dos digitos");
                    }
                    else
                    {
                        Console.WriteLine("Este numero tiene un digito");
                    }
                }
                else
                {
                    if (numero > 999)
                    {
                        Console.WriteLine("Este numero esta fuera de rango");
                    }
                   else
                    {
                        Console.WriteLine("Este numero tiene tres digitos");
                    }
                }
            } while (numero != 0);
        }
        public static void cargadeValores()
        {
            int numero = 0;
            int suma = 0;
            int n = 0;
            double promedio = 0;
            do
            {
                Console.WriteLine("Ingrese un numero");
                numero = int.Parse(Console.ReadLine());
                suma = suma + numero;
                if (numero != 0)
                {
                    n = n + 1;
                }
            } while (numero != 0);
            Console.WriteLine("Su suma es " + suma);
            Console.WriteLine("El total de numeros ingresados es " + n);
            promedio = suma / n;
            Console.WriteLine("El promedio es " + promedio);
        }
        public static void hastaEl9999()
        {
            int numero = 0;
            int suma = 0;
            do
            {
                Console.WriteLine("Ingrese un numero");
                numero = int.Parse(Console.ReadLine());

                if (numero != 9999)
                {
                    suma = suma + numero;
                }
            } while (numero != 9999);
            if (suma > 0)
            {
                Console.WriteLine("La suma " + suma + " es mayor a" +
                    " 0");
            }
            else
            {
                if (suma == 0)
                {
                    Console.WriteLine("La suma " + suma + " es igual a 0");
                }
                else
                {
                    Console.WriteLine("La suma " + suma + " es menor a 0");
                }
            }
        }
    }
}
