using System;
using System.Collections.Generic;
using System.Text;

namespace Practica1U1POO
{
    class Ejercicio1
    {
        public static void sumaPorteclado()
        {
            double num1 = 0, num2 = 0, total = 0;
            Console.WriteLine("Ingrese un numero");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un segundo numero");
            num2 = double.Parse(Console.ReadLine());
            total = num1 + num2;
            Console.WriteLine("El total de su suma es " + total);
        }
    }
}
