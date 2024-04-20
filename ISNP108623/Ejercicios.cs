using System;

namespace ISNP108623 {
    internal class Ejercicios {
        static void Main(string[] args) {
            bool continuar = true;
            while (continuar) {
                Console.Clear(); // Limpia La Consola
                Console.WriteLine("::..MENU..::");
                Console.WriteLine("1.Numero positivo y negativo");
                Console.WriteLine("2.Numeros del 1 al 10");
                Console.WriteLine("3.Suma de numeros positivos");
                Console.WriteLine("4.Suma de 5 numeros");
                Console.WriteLine("5.Promedio de numeros");
                Console.WriteLine("0.Salir");
                Console.Write("Opcion: ");
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion) {
                    case 1:
                        numeropositivoynegativo();
                        break;
                    case 2:
                        numerosdel1al10();
                        break;
                    case 3:
                        sumadenumerospositivos();
                        break;
                    case 4:
                        sumade5numeros();
                        break;
                    case 5:
                        promediodenumeros();
                        break;
                    case 0:
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Inténtelo de nuevo.");
                        break;
                }

                Console.WriteLine("Presione cualquier tecla para continuar...");
                Console.ReadKey();
            }
        }

        static void numeropositivoynegativo() {
            // Identificar números positivos y negativos
            int numero;

            Console.Write("Ingrese un número para identificar : ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero > 0) {
                Console.WriteLine("El número ingresado es positivo.");
            } else if (numero < 0) {
                Console.WriteLine("El número ingresado es negativo.");
            } else {
                Console.WriteLine("Ha ingresado el número 0. El programa ha terminado.");
            }
        }

        static void numerosdel1al10() {
            int numero = 1;

            while (numero <= 10) {
                Console.WriteLine(numero);
                numero++;
            }
        }

        static void sumadenumerospositivos() {
            int suma = 0;
            bool continuar = true;

            Console.WriteLine("Ingrese números positivos para sumar. Ingrese un número negativo o cero para terminar.");

            while (continuar) {
                Console.Write("Ingrese un número: ");
                int numero = int.Parse(Console.ReadLine());

                if (numero > 0) {
                    suma += numero;
                } else {
                    continuar = false;
                }
            }

            Console.WriteLine("La suma de los números positivos ingresados es: " + suma);
        }

        static void sumade5numeros() {
            int suma = 0;
            int contador = 0;

            // Ciclo do-while para solicitar 5 números al usuario
            do {
                Console.Write("Ingrese el número {0}: ", contador + 1);
                int numero = int.Parse(Console.ReadLine());

                suma += numero; // Sumar el número ingresado a la suma total
                contador++; // Incrementar el contador

            } while (contador < 5); // Continuar el ciclo mientras no se hayan ingresado 5 números

            Console.WriteLine("La sumatoria de los 5 números ingresados es: " + suma);
        }

        static void promediodenumeros() {
            int suma = 0;
            int cantidadNumeros = 0;

            Console.WriteLine("Ingrese un número para calcular su promedio:");

            // Solicitar un solo número al usuario
            Console.Write("Ingrese un número: ");
            int numero = int.Parse(Console.ReadLine());

            suma += numero; // Sumar el número ingresado a la suma total
            cantidadNumeros++; // Incrementar el contador de números ingresados

            // Calcular el promedio
            double promedio = cantidadNumeros > 0 ? (double)suma / cantidadNumeros : 0;

            Console.WriteLine("El promedio del número ingresado es: " + promedio);
        }
    }
}
