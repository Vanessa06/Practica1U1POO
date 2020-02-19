using System;

namespace Practica1U1POO
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            Console.WriteLine("Elige una opcion");
            Console.WriteLine("1.- Ejercicio 1");
            Console.WriteLine("2.- Ejercicio 2");
            Console.WriteLine("3.- Ejercicio 3");
            Console.WriteLine("4.- Ejercicio 4");
            Console.WriteLine("5.- Ejercicio 5");
            Console.WriteLine("6.- Ejercicio 6");
            Console.WriteLine("7.- Ejercicio 7");
            Console.WriteLine("8.- Ejercicio 8");
            Console.WriteLine("9.- Ejercicio 9");
            Console.WriteLine("10.- Ejercicio 10");
            Console.WriteLine("11.- Ejercicio 11");
            Console.WriteLine("12.- Ejercicio 12");
            Console.WriteLine("13.- Ejercicio 13");
            Console.WriteLine("14.- Ejercicio 14");
            Console.WriteLine("15.- Ejercicio 15");
            Console.WriteLine("16.- Ejercicio 16");
            Console.WriteLine("17.- Ejercicio 17");
            Console.WriteLine("18.- Ejercicio 18");
            Console.WriteLine("19.- Ejercicio 19");
            Console.WriteLine("20.- Ejercicio 20");
            Console.WriteLine("21.- SALIR DEL PROGRAMA");
            opcion = int.Parse(Console.ReadLine());
            switch (opcion) 
            {
                case 1:
                    Ejercicios.sumaPorteclado();
                    break;
                case 2:
                    Ejercicios.suma100porteclado();
                    break;
                case 3:
                    Ejercicios.sumaNnumeros();
                    break;
                case 4:
                    Ejercicios.primeros100Pares();
                    break;
                case 5:
                    Ejercicios.imprimirNimpares();
                    break;
                case 6:
                    Ejercicios.imprimirNpares();
                    break;
                case 7:
                    Ejercicios.imprimirNmultiplos3();
                    break;
                case 8:
                    Ejercicios.sumaImparesypares();
                    break;
                case 9:
                    break;
                case 10:
                    break;
                case 11:
                    break;
                case 12:
                    break;
                case 13:
                    break;
                case 14:
                    break;
                case 15:
                    break;
                case 16:
                    break;
                case 17:
                    break;
                case 18:
                    break;
                case 19:
                    break;
                case 20:
                    break;
                case 21:
                    break;
                default:
                    break;
            }
            Console.ReadKey();   
        }
    }
}
