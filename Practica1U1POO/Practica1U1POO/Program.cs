using System;

namespace Practica1U1POO
{
    class Program
    {/// <summary>
    /// Clase principal///
    /// </summary>
    /// <param name="args"></param>
        static void Main(string[] args)
        {
            int opcion = 0;///Declarar variable de tipo entero para mi switch///
            do///La accion de elegir una opcion y presentarle el menu de opciones al 
            ///usuario se reperira siempre y cuando el valor de la variable de tipo entero sea 
            ///diferente de 21///
            {
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
                Console.WriteLine("15.- Multiplos de 3 hasta N");
                Console.WriteLine("16.- Cantidad de 10");
                Console.WriteLine("17.- Impuesto de renta");
                Console.WriteLine("18.- Cinco juegos");
                Console.WriteLine("19.- Calculo de salario");
                Console.WriteLine("20.- Primeros 10 cuadrados");
                Console.WriteLine("21.- SALIR DEL PROGRAMA");
                opcion = int.Parse(Console.ReadLine());
                Console.Clear();///Limpia la pantalla y da paso al ejercicio///
                switch (opcion)///Dependiendo de la opcion seleccionada, el programa realizara el
                ///ejercicio correspondiente///
                {
                    ///Todas las opcines mandan a llamar una clase publica llamada ejercicios, y un metodo 
                    ///en especifico dentro de ella///
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
                        Ejercicios.multiplosDe3hastan();
                        break;
                    case 16:
                        Ejercicios.cantidadDe10();
                        break;
                    case 17:
                        Ejercicios.impuestodeRenta();
                        break;
                    case 18:
                        Ejercicios.cincoYcuatro();
                        break;
                    case 19:
                        Ejercicios.empresa100Empleados();
                        break;
                    case 20:
                        Ejercicios.primerosCuadrados();
                        break;
                    case 21:
                        break;
                    default:
                        Console.WriteLine("OPCION NO VALIDA");///Para cualquier opcion que sea diferente de 21 y del menu///
                        break;
                }
            } while (opcion != 21);
           Console.ReadKey();   
        }
    }
}
