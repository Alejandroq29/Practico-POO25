using System;
using System.Collections.Generic;
using System.Linq;

// Definimos un espacio de nombres para organizar nuestro código.
namespace EjerciciosCSharp
{
    // La clase principal de nuestro programa.
    public class Program
    {
        // El método Main es el punto de entrada de la aplicación.
        public static void Main(string[] args)
        {
            // Bucle para que el menú se muestre repetidamente hasta que el usuario decida salir.
            while (true)
            {
                // Limpiamos la consola para una mejor presentación.
                Console.Clear();
                Console.WriteLine("======================================");
                Console.WriteLine("  SELECCIONE EL EJERCICIO A EJECUTAR  ");
                Console.WriteLine("======================================");
                Console.WriteLine("1. Mostrar lista de asignaturas");
                Console.WriteLine("2. Mostrar 'Yo estudio <asignatura>'");
                Console.WriteLine("3. Ingresar notas por asignatura");
                Console.WriteLine("4. Ordenar números de lotería");
                Console.WriteLine("5. Números del 1 al 10 en orden inverso");
                Console.WriteLine("6. Salir del programa");
                Console.WriteLine("======================================");
                Console.Write("Por favor, elige una opción (1-6): ");

                string opcion = Console.ReadLine();

                // Un switch para ejecutar el código correspondiente a la opción elegida.
                switch (opcion)
                {
                    case "1":
                        EjecutarEjercicio1();
                        break;
                    case "2":
                        EjecutarEjercicio2();
                        break;
                    case "3":
                        EjecutarEjercicio3();
                        break;
                    case "4":
                        EjecutarEjercicio4();
                        break;
                    case "5":
                        EjecutarEjercicio5();
                        break;
                    case "6":
                        // Si el usuario elige salir, se muestra un mensaje y se termina el programa.
                        Console.WriteLine("Saliendo del programa...");
                        return; // Termina la ejecución del método Main.
                    default:
                        // Si la opción no es válida, se informa al usuario.
                        Console.WriteLine("Opción no válida. Inténtalo de nuevo.");
                        break;
                }

                // Pausa para que el usuario pueda leer el resultado antes de que el menú se muestre de nuevo.
                Console.WriteLine("\nPresiona cualquier tecla para volver al menú...");
                Console.ReadKey();
            }
        }

        public static void EjecutarEjercicio1()
        {
            Console.Clear();
            Console.WriteLine("--- Ejercicio 1: Mostrar lista de asignaturas ---");
            List<string> asignaturas = new List<string> { "Estructura de datos", "Fundamento", "Metodologia", "Administracion", "Instalaciones" };
            Console.WriteLine("Las asignaturas del curso son:");
            foreach (string asignatura in asignaturas)
            {
                Console.WriteLine($"- {asignatura}");
            }
        }

        public static void EjecutarEjercicio2()
        {
            Console.Clear();
            Console.WriteLine("--- Ejercicio 2: Mostrar 'Yo estudio <asignatura>' ---");
            List<string> asignaturas = new List<string> { "Estructura de datos", "Fundamento", "Metodologia", "Administracion", "Instalaciones" };
            foreach (string asignatura in asignaturas)
            {
                Console.WriteLine($"Yo estudio {asignatura}");
            }
        }

        public static void EjecutarEjercicio3()
        {
            Console.Clear();
            Console.WriteLine("--- Ejercicio 3: Ingresar notas por asignatura ---");
            List<string> asignaturas = new List<string> { "Estructura de datos", "Fundamento", "Metodologia", "Administracion", "Instalaciones" };
            List<string> notas = new List<string>();

            foreach (string asignatura in asignaturas)
            {
                Console.Write($"¿Qué nota has sacado en {asignatura}? ");
                string nota = Console.ReadLine();
                notas.Add(nota);
            }

            Console.WriteLine("\n--- Resumen de notas ---");
            for (int i = 0; i < asignaturas.Count; i++)
            {
                Console.WriteLine($"En {asignaturas[i]} has sacado {notas[i]}");
            }
        }

        public static void EjecutarEjercicio4()
        {
            Console.Clear();
            Console.WriteLine("--- Ejercicio 4: Ordenar números de lotería ---");
            List<int> numerosGanadores = new List<int>();

            for (int i = 0; i < 6; i++)
            {
                Console.Write($"Introduce el número ganador #{i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out int numero))
                {
                    numerosGanadores.Add(numero);
                }
                else
                {
                    Console.WriteLine("Entrada no válida. Por favor, introduce un número.");
                    i--; // Descuenta el intento fallido para que pida 6 números válidos.
                }
            }

            numerosGanadores.Sort();
            Console.WriteLine("\nLos números ganadores ordenados son: " + string.Join(", ", numerosGanadores));
        }

        public static void EjecutarEjercicio5()
        {
            Console.Clear();
            Console.WriteLine("--- Ejercicio 5: Números del 1 al 10 en orden inverso ---");
            List<int> numeros = Enumerable.Range(1, 10).ToList();
            numeros.Reverse();
            Console.WriteLine("Los números en orden inverso son:");
            Console.WriteLine(string.Join(", ", numeros));
        }
    }
}