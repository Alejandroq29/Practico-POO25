using System;
using System.Collections.Generic;

class Traductor
{
    static void Main()
    {
        // Diccionario inicial (Español -> Inglés)
        Dictionary<string, string> diccionario = new Dictionary<string, string>()
        {
            {"tiempo", "time"},
            {"persona", "person"},
            {"año", "year"},
            {"camino", "way"},
            {"día", "day"},
            {"cosa", "thing"},
            {"hombre", "man"},
            {"mundo", "world"},
            {"vida", "life"},
            {"mano", "hand"},
            {"parte", "part"},
            {"niño", "child"},
            {"ojo", "eye"},
            {"mujer", "woman"},
            {"lugar", "place"},
            {"trabajo", "work"},
            {"semana", "week"},
            {"caso", "case"},
            {"punto", "point"},
            {"gobierno", "government"},
            {"empresa", "company"}
        };

        int opcion;
        do
        {
            Console.WriteLine("\n================= MENÚ =================");
            Console.WriteLine("1. Traducir una frase");
            Console.WriteLine("2. Agregar palabras al diccionario");
            Console.WriteLine("3. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    TraducirFrase(diccionario);
                    break;

                case 2:
                    AgregarPalabra(diccionario);
                    break;

                case 3:
                    Console.WriteLine("Saliendo del programa... ¡Adiós!");
                    break;

                default:
                    Console.WriteLine("Opción no válida, intente de nuevo.");
                    break;
            }

        } while (opcion != 3);
    }

    // Método para traducir una frase
    static void TraducirFrase(Dictionary<string, string> diccionario)
    {
        Console.Write("\nIngrese una frase en español: ");
        string frase = Console.ReadLine().ToLower();
        string[] palabras = frase.Split(' ');

        string traduccion = "";

        foreach (string palabra in palabras)
        {
            if (diccionario.ContainsKey(palabra))
                traduccion += diccionario[palabra] + " ";
            else
                traduccion += palabra + " ";
        }

        Console.WriteLine("Traducción: " + traduccion.Trim());
    }

    // Método para agregar una palabra al diccionario
    static void AgregarPalabra(Dictionary<string, string> diccionario)
    {
        Console.Write("\nIngrese la palabra en español: ");
        string esp = Console.ReadLine().ToLower();

        Console.Write("Ingrese su traducción en inglés: ");
        string ing = Console.ReadLine().ToLower();

        if (!diccionario.ContainsKey(esp))
        {
            diccionario.Add(esp, ing);
            Console.WriteLine("Palabra agregada exitosamente.");
        }
        else
        {
            Console.WriteLine("Esa palabra ya existe en el diccionario.");
        }
    }
}
