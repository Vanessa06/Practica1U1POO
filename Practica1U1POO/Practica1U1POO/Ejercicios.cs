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
        public static void del100Al0()
        {
            int i = 101;
            while (i > 0)
            {
                i = i - 1;
                Console.WriteLine(i);
            }
        }
        public static void paresdel0Al100()
        {
            int i = 0;
            while (i <= 98)
            {
                i = i + 2;
                Console.WriteLine(i);
            }
              
        }
        public static void multiplosDe3hastan()
        {
            int n = 0;
            Console.WriteLine("Ingrese un numero");
            n = int.Parse(Console.ReadLine());
            int i = 1;
            while (i <= n)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        public static void cantidadDe10()
        {
            int n = 0;
            int mayor = 0;
            int entre = 0;
            int negativos = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese un numero");
                n = int.Parse(Console.ReadLine());

                if (n > 50)
                {
                    mayor = mayor + 1;
                }
                else
                {
                    if (n < 0)
                    {
                        negativos = negativos + 1;
                    }
                    if ((n > 25) | (n < 45))
                    {
                        entre = entre + 1;
                    }
                }
            }
            Console.WriteLine("Hay " + mayor + " numeros mayores de 50");
            Console.WriteLine("Hay " + entre + " numeros entre 25 y 45");
            Console.WriteLine("Hay " + negativos + " numeros negativos");
        }
        public static void impuestodeRenta()
        {
            double salario = 0;
            double salarioA = 0;
            double deduccion = 0;
            double salarioAT = 0;
            int hijos = 0;
            int n = 0;
            double impuestos = 0;
            Console.WriteLine("VAMOS A CALCULAR EL IMPUESTO SOBRE LA RENTA");
            Console.WriteLine("¿Cuantas veces desea realizar el calculo?");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Ingrese su salario semanal");
                salario = double.Parse(Console.ReadLine());
                salarioA = salario * 52;
                Console.WriteLine("¿Cuantos hijos tiene?");
                hijos = int.Parse(Console.ReadLine());
                if (hijos == 0)
                {
                    salarioAT = salarioA;
                }
                if ((hijos == 1) | (hijos == 2))
                {
                    deduccion = salarioA * 0.05;
                  salarioAT = salarioA - deduccion;
                }
                else
                {
                    deduccion = salarioA * 0.15;
                    salarioAT = salarioA - deduccion;
                }

                impuestos = salarioAT * 0.15;
                Console.WriteLine("El total de los impuestos de renta es de " + impuestos);

            }
        }
        public static void cincoYcuatro()
        {
            int n = 0;
            int suma = 0;
            double promedio = 0;
            Console.WriteLine("Vamos a realizar 5 juegos con cuatro valores cada uno");
            Console.WriteLine("Calcularemos el promedio de cada juego");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Juego numero " + (i + 1));
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine("Ingrese el valor numero " + (j + 1));
                    n = int.Parse(Console.ReadLine());
                    suma = suma + n;
                }
                promedio = suma / 4;
                Console.WriteLine("El promedio del juego  es:");
                Console.WriteLine(promedio);
               
            }
           
        }
    }
}
