using System;

namespace Practica1U1POO
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            Console.WriteLine("Elige una opcion");
            Console.WriteLine("1.- Suma por teclado");
            Console.WriteLine("2.- Suma de 100 numeros por teclado");
            Console.WriteLine("3.- Suma de N numeros");
            Console.WriteLine("4.- Primeros 100 pares");
            Console.WriteLine("5.- Imprimir N impares");
            Console.WriteLine("6.- Imprimir N pares");
            Console.WriteLine("7.- Imprimir N multiplos de 3");
            Console.WriteLine("8.- Suma de pares e impares");
            Console.WriteLine("9.- De decimal a binario");
            Console.WriteLine("10.- Entre 0 y 999");
            Console.WriteLine("11.- Carga de valores");
            Console.WriteLine("12.- Hasta el 9999");
            Console.WriteLine("13.- Del 100 al 0");
            Console.WriteLine("14.- Pares del 0 al 100");
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
                    Ejercicios.decimalaBinario();
                    break;
                case 10:
                    Ejercicios.entre0Y999();
                    break;
                case 11:
                    Ejercicios.cargadeValores();
                    break;
                case 12:
                    Ejercicios.hastaEl9999();
                    break;
                case 13:
                    Ejercicios.del100Al0();
                    break;
                case 14:
                    Ejercicios.paresdel0Al100();
                    break;
                case 15:
                    Ejercicios.primeros100Numeros();
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
