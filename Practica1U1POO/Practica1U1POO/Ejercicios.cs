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
            Console.WriteLine("VAMOS A REALIZAR LA SUMA DE DOS NUMEROS INGRESADOS POR TECLADO");
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
        /// <summary>
        /// Declarar el metodo como publico///
        /// </summary>
        public static void suma100porteclado()
        {///Declarar variable de tipo double para el numero y el total///
            Console.WriteLine("VAMOS A REALIZAR LA SUMA DE 100 NUMEROS INGRESADOS POR TECLADO");
            double num = 0, total = 0;
            for (int i = 0; i < 100; i++)///Abrir ciclo for que se repita 100 veces///
            {
                Console.WriteLine("Ingrese un numero");
                num = double.Parse(Console.ReadLine());///La variable tomara valores diferentes en cada ciclo///
                total = total + num;///Se utiliza la variable total como acumulador///
            }
            Console.WriteLine("El total de su suma es " + total);///Imprimir por mensaje el total de la suma///
        }

        /// <summary>
        /// Metodo publico///
        /// </summary>
        public static void sumaNnumeros()
        {
            Console.WriteLine("VAMOS A REALIZAR LA SUMA DE N NUMEROS INGRESADOS");
         ///Declarar variable de tipo entero con valor igual a 0///
         int n = 0;
            ///Declarar variables de tipo double para ingresar numeros y acumular valores///
            double num = 0, total = 0;
            Console.WriteLine("Ingrese la cantidad de numeros que desea sumar");
            n = int.Parse(Console.ReadLine()); ///Leer la cantidad de numeros que se desean sumar///
            for (int i = 0; i < n; i++)///Abrir un ciclo for que incie en cero hasta los n numeros deseados///
            {
                Console.WriteLine("Ingrese un numero");///Pedir al usuario que ingrese los numeros///
                num = double.Parse(Console.ReadLine());///Leer los numeros///
                total = total + num;///Acumular los valores en la variable total///
            }
            Console.WriteLine("El total de su suma es " + total);///Imprimir el valor acumulado o sumado///
        }
        /// <summary>
        /// Metodo publico///
        /// </summary>
        public static void primeros100Pares()
        {
            Console.WriteLine("VAMOS A IMPRIMIR LOS 100 PRIMEROS PARES");
            for (int i = 1; i < 201; i++)///Abrir un ciclo for que inicie en 1 y llegue hasta 201, para mostrar 
            ///los 100 pares///
            {
                if (i % 2 == 0)///Agregar una condicion, si el contador es divisible entre dos sin residuo es par///
                {
                    Console.WriteLine(i);///Se imprime el valor///
                }
            }
        }
        /// <summary>
        /// Metodo publico///
        /// </summary>
        public static void imprimirNimpares()
        {///Declarar una variable n que seran la cantidad de numeros a evaluar, sera de tipo entero///
            int n = 0;
            Console.WriteLine("VAMOS A IMPRIMIR NUMEROS IMPARES");
            Console.WriteLine("Ingrese la cantidad de numeros que desea evaluar");///Pedir al usuario la cantidad de 
            ///numeros a evaluar///
            n = int.Parse(Console.ReadLine());///Leer el valor y guardarlo en la variable///
            for (int i = 1; i < n; i++)///Abrir un ciclo for que inicie en 1 y llegue hasta n///
            {
                if (i % 2 != 0)///Agregar una condicion///
                ///Si el valor de i se puede dividir entre dos, pero deja residuo, es impar///
                {
                    Console.WriteLine(i);///Se imprime el valor impar///
                }
            }
        } 
        /// <summary>
        /// Metodo publico///
        /// </summary>
        public static void imprimirNpares()
        { ///Declarar una variable n que seran la cantidad de numeros a evaluar, sera de tipo entero///
            int n = 0;
            Console.WriteLine("VAMOS A IMPRIMIR NUMEROS PARES");
            Console.WriteLine("Ingrese la cantidad de numeros que desea evaluar");///Pedir al usuario la cantidad de 
        ///numeros a evaluar///
            n = int.Parse(Console.ReadLine());///Leer el valor y guardarlo en la variable///
            for (int i = 1; i < n; i++)///Abrir un ciclo for que inicie en 1 y llegue hasta n///
            {
                if (i % 2 == 0)///Agregar una condicion///
                {
                    ///Si el contador es divisible entre dos sin residuo es par///
                    Console.WriteLine(i);///Se imprime el valor par///
                }
            }
        }
        /// <summary>
        /// Metodo publico///
        /// </summary>
        public static void imprimirNmultiplos3()
        {///Declarar una variable n que seran la cantidad de numeros a evaluar, sera de tipo entero///
            int n = 0;
            Console.WriteLine("VAMOS A IMPRIMIR NUMEROS MULTIPLOS DE 3");
            Console.WriteLine("Ingrese la cantidad de numeros que desea evaluar");///Pedir al usuario la cantidad de 
         ///numeros a evaluar///
            n = int.Parse(Console.ReadLine());///Leer el valor y guardarlo en la variable///
            for (int i = 1; i < n; i++)///Abrir un ciclo for que inicie en 1 y llegue hasta n///
            {
                if (i % 3 == 0)///Agregar una condicion///
                {///Si el contador es divisible entre tres sin residuo es multiplo de 3///
                    Console.WriteLine(i);///Se imprime el valor multiplo///
                }
            }
        }
         /// <summary>
        /// Metodo publico///
        /// </summary>
        public static void sumaImparesypares()
        {///Declarar dos variables para acumular valores de pares e impares con valor de 0///
            int pares = 0;
            int impares = 0;
            ///Declarar una variable n que seran la cantidad de numeros a evaluar, sera de tipo entero///
            int n = 0;
            Console.WriteLine("VAMOS A REALIZAR SUMA DE PARES E IMPARES");
            Console.WriteLine("Ingrese la cantidad de numeros que desea evaluar");
            n = int.Parse(Console.ReadLine());///Leer el valor y guardarlo en la variable///
            for (int i = 1; i <= n; i++)///Abrir un ciclo for que inicie en 1 y llegue hasta n///
            {
                if (i % 2 == 0)///Agregar una condicion///
                { ///Si el contador es divisible entre dos sin residuo es par///
                    pares = pares + i;///Se acumula el valor en la variable pares///
                }
                else
                {///Si no lo es, se acumula el valor en la variable impares///
                    impares = impares + i;
                }
            }
            ///Mostrar ambos valores acumulados por mensaje///
            Console.WriteLine("La suma de los numeros impares es " + impares);
            Console.WriteLine("La suma de los numeros pares es " + pares);
        }
         /// <summary>
        /// Metodo publico///
        /// </summary>
        public static void decimalaBinario()
        {
            Console.WriteLine("VAMOS A CONVERTIR UN DECIMAL A BINARIO");
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
         /// <summary>
        /// Metodo publico///
        /// </summary>
        public static void entre0Y999()
        {
            Console.WriteLine("VAMOS A CONTAR LOS DIGITOS DE LOS NUMEROS INGRESADOS");
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
         /// <summary>
        /// Metodo publico///
        /// </summary>
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
         /// <summary>
        /// Metodo publico///
        /// </summary>
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
         /// <summary>
        /// Metodo publico///
        /// </summary>
       public static void del100Al0()
        {
            int i = 101;
            while (i > 0)
            {
                i = i - 1;
                Console.WriteLine(i);
            }
        }
         /// <summary>
        /// Metodo publico///
        /// </summary>
       public static void paresdel0Al100()
        {
            int i = 0;
            while (i <= 98)
            {
                i = i + 2;
                Console.WriteLine(i);
            }

        }
         /// <summary>
        /// Metodo publico///
        /// </summary>
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
         /// <summary>
        /// Metodo publico///
        /// </summary>
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
        /// <summary>
        /// Metodo publico///
        /// </summary>
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
        /// <summary>
        /// Metodo publico///
        /// </summary>
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
                Console.WriteLine("El promedio del juego es:");
                Console.WriteLine(promedio);
               
            }

        }
         /// <summary>
        /// Metodo publico///
        /// </summary>
       public static void empresa100Empleados()
        {
            double P = 0;
            int horas = 0;
            double sueldoT = 0;
            int extras = 0;
            string nombre, numeroe;
            Console.WriteLine("Calculo de salario a razon de horas trabajadas");
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Escriba el nombre del empleado");
                nombre = Console.ReadLine();
                Console.WriteLine("Escriba el numero de empleado");
                numeroe = Console.ReadLine();
                Console.WriteLine("Total de sueldo por hora");
                P = double.Parse(Console.ReadLine());
                Console.WriteLine("Total de horas trabajadas");
                horas = int.Parse(Console.ReadLine());
                if ( horas > 40)
                {
                    extras = horas - 40;
                    sueldoT = (40 * P) + (extras * 1.5 * P);
                }
                else
                {
                    sueldoT = horas * P;
                }
                Console.WriteLine("Trabajador : ");
                Console.WriteLine("Nombre: " + nombre);
                Console.WriteLine("Numero de empleado : " + numeroe);
                Console.WriteLine("Sueldo Total: " + sueldoT);
            }
        }
        /// <summary>
        /// Metodo publico///
        /// </summary>
        public static void primerosCuadrados()
        {
            int suma = 0;
            for ( int i = 1; i <= 10; i++)
            {
                suma = suma + (i * i);
            }
            Console.WriteLine("La suma de los cuadrados de los primeros 10 numeros es: " + suma);
        }
    }
}
