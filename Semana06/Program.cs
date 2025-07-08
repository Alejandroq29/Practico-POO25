<<<<<<< HEAD
﻿// Program.cs
using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("--- Demostración de Lista Enlazada ---");

        // Crear una nueva lista enlazada
        ListaEnlazada miLista = new ListaEnlazada();

        // Verificar lista vacía
        Console.WriteLine("\n--- 1. Contar elementos en lista vacía ---");
        Console.WriteLine($"Número de elementos: {miLista.ContarElementos()}");
        miLista.ImprimirLista();

        // Agregar elementos a la lista
        Console.WriteLine("\n--- Agregando elementos ---");
        miLista.Agregar(10);
        miLista.Agregar(20);
        miLista.Agregar(30);
        miLista.Agregar(40);
        miLista.ImprimirLista();

        // 1. Probar la función de contar elementos
        Console.WriteLine("\n--- 2. Contar elementos en lista con datos ---");
        int numElementos = miLista.ContarElementos();
        Console.WriteLine($"Número de elementos en la lista: {numElementos}");

        // 2. Probar la función de invertir la lista
        Console.WriteLine("\n--- 3. Invirtiendo la lista ---");
        miLista.ImprimirLista(); // Estado antes de invertir
        miLista.InvertirLista();
        miLista.ImprimirLista(); // Estado después de invertir

        // Volver a invertir para restaurar el orden original (o simplemente para probar de nuevo)
        Console.WriteLine("\n--- 4. Invirtiendo la lista de nuevo ---");
        miLista.InvertirLista();
        miLista.ImprimirLista();

        // Probar invertir una lista con un solo elemento
        Console.WriteLine("\n--- 5. Probando invertir lista con un solo elemento ---");
        ListaEnlazada listaUnElemento = new ListaEnlazada();
        listaUnElemento.Agregar(55);
        listaUnElemento.ImprimirLista();
        listaUnElemento.InvertirLista();
        listaUnElemento.ImprimirLista();


        Console.WriteLine("\n--- Fin de la demostración ---");
    }
}
=======
﻿class Program
{
    static void Main(string[] args)
    {
        Lista miLista = new Lista();

        // Insertar elementos
        miLista.Insertar(10);
        miLista.Insertar(20);
        miLista.Insertar(30);
        miLista.Insertar(40);

        Console.WriteLine("Lista original:");
        miLista.Mostrar();

        Console.WriteLine($"\nNúmero de elementos: {miLista.Longitud()}");

        miLista.Invertir();
        Console.WriteLine("\nLista invertida:");
        miLista.Mostrar();
    }
}

>>>>>>> 71d1fb5ce592792f04d753397edc07b78106cff2
