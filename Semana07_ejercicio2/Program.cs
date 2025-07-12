using System;
using System.Collections.Generic;
using System.Linq; // Para el método Select y String.Join

// Se renombra la clase StackHanoi para evitar conflictos al heredar de Stack<int>
public class PilaDeHanoi : Stack<int> // Hereda de System.Collections.Generic.Stack
{
    public string Nombre { get; private set; }

    public PilaDeHanoi(string nombre) : base()
    {
        Nombre = nombre;
    }

    // Usamos 'new' para ocultar el método Push de la clase base y añadir nuestra validación
    public new void Push(int tamanoDisco)
    {
        if (Count > 0 && tamanoDisco > Peek())
        {
            throw new InvalidOperationException($"No se puede colocar el Disco({tamanoDisco}) encima del Disco({Peek()}). Un disco más pequeño debe estar encima.");
        }
        base.Push(tamanoDisco);
    }

    public void Mostrar()
    {
        Console.Write($"[{Nombre}]: ");
        if (Count == 0)
        {
            Console.WriteLine("Vacía");
        }
        else
        {
            // Para mostrar los discos de abajo hacia arriba
            var arrayTemporal = this.ToArray();
            Array.Reverse(arrayTemporal);
            Console.WriteLine(string.Join(" ", arrayTemporal.Select(d => $"[{d}]")));
        }
    }
}


public class Program
{
    private static PilaDeHanoi origen;
    private static PilaDeHanoi auxiliar;
    private static PilaDeHanoi destino;
    private static int totalMovimientos = 0;

    public static void Main(string[] args)
    {
        Console.WriteLine("--- Resolutor de las Torres de Hanói (Conciso) ---");

        int numeroDeDiscos;
        while (true)
        {
            Console.Write("Ingrese el número de discos (ej. 3): ");
            string entrada = Console.ReadLine();
            if (int.TryParse(entrada, out numeroDeDiscos) && numeroDeDiscos > 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero positivo.");
            }
        }

        origen = new PilaDeHanoi("Origen");
        auxiliar = new PilaDeHanoi("Auxiliar");
        destino = new PilaDeHanoi("Destino");

        // Inicializa la pila de origen con discos del más grande al más pequeño
        for (int i = numeroDeDiscos; i >= 1; i--)
        {
            origen.Push(i);
        }

        Console.WriteLine("\nEstado Inicial:");
        MostrarTorres();

        try
        {
            ResolverHanoi(numeroDeDiscos, origen, destino, auxiliar);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ocurrió un error: {ex.Message}");
        }

        Console.WriteLine("\nEstado Final:");
        MostrarTorres();
        Console.WriteLine($"\n¡Problema resuelto en {totalMovimientos} movimientos!");

        Console.WriteLine("\nPresione cualquier tecla para salir.");
        Console.ReadKey();
    }

    private static void ResolverHanoi(int n, PilaDeHanoi src, PilaDeHanoi dest, PilaDeHanoi aux)
    {
        if (n == 1)
        {
            MoverDisco(src, dest);
        }
        else
        {
            ResolverHanoi(n - 1, src, aux, dest); // Mueve n-1 discos de origen a auxiliar
            MoverDisco(src, dest);                   // Mueve el disco n de origen a destino
            ResolverHanoi(n - 1, aux, dest, src); // Mueve n-1 discos de auxiliar a destino
        }
    }

    private static void MoverDisco(PilaDeHanoi src, PilaDeHanoi dest)
    {
        int tamanoDisco = src.Pop();
        Console.WriteLine($"\nMoviendo Disco({tamanoDisco}) de {src.Nombre} a {dest.Nombre}");
        dest.Push(tamanoDisco);
        totalMovimientos++;
        MostrarTorres();
    }

    private static void MostrarTorres()
    {
        origen.Mostrar();
        auxiliar.Mostrar();
        destino.Mostrar();
        Console.WriteLine("--------------------");
    }
}
