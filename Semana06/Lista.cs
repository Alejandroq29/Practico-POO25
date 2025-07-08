
// ListaEnlazada.cs
using System;

public class ListaEnlazada
{
    public Nodo Cabeza { get; private set; } // Puntero al primer nodo de la lista

    // Constructor para inicializar una lista enlazada vacía
    public ListaEnlazada()
    {
        Cabeza = null;
    }

    // Método para agregar un nuevo nodo al final de la lista
    public void Agregar(int dato)
    {
        Nodo nuevoNodo = new Nodo(dato);
        if (Cabeza == null)
        {
            Cabeza = nuevoNodo; // Si la lista está vacía, el nuevo nodo es la cabeza
        }
        else
        {
            Nodo actual = Cabeza;
            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente; // Recorrer hasta el último nodo
            }
            actual.Siguiente = nuevoNodo; // Enlazar el nuevo nodo al final
        }
        Console.WriteLine($"'{dato}' agregado a la lista.");
    }

    // Método para imprimir los elementos de la lista
    public void ImprimirLista()
    {
        if (Cabeza == null)
        {
            Console.WriteLine("La lista está vacía.");
            return;
        }

        Nodo actual = Cabeza;
        Console.Write("Lista: ");
        while (actual != null)
        {
            Console.Write($"{actual.Dato} -> ");
            actual = actual.Siguiente;
        }
        Console.WriteLine("NULL");
    }

    // 1. Función que calcula el número de elementos de una lista
    // Recorre la lista contando los nodos hasta llegar al final (NULL).
    public int ContarElementos()
    {
        int contador = 0;
        Nodo actual = Cabeza;
        while (actual != null)
        {
            contador++;
            actual = actual.Siguiente;
        }
        return contador;
    }

    // 2. Invertir una lista enlazada
    // Este método invierte el orden de los nodos en la lista.
    // Ejemplo: A -> B -> C se convierte en C -> B -> A
    public void InvertirLista()
    {
        if (Cabeza == null || Cabeza.Siguiente == null)
        {
            // La lista está vacía o tiene un solo elemento, no hay nada que invertir.
            Console.WriteLine("No se puede invertir una lista vacía o con un solo elemento.");
            return;
        }

        Nodo prev = null; // Nodo anterior, inicialmente nulo
        Nodo actual = Cabeza; // Nodo actual, comienza en la cabeza
        Nodo next = null; // Nodo siguiente temporal

        while (actual != null)
        {
            next = actual.Siguiente; // Guarda el siguiente nodo
            actual.Siguiente = prev; // Invierte el puntero del nodo actual al nodo anterior
            prev = actual; // Mueve 'prev' al nodo actual
            actual = next; // Mueve 'actual' al siguiente nodo (que guardamos antes)
        }

        Cabeza = prev; // Una vez terminado el bucle, 'prev' será la nueva cabeza de la lista
        Console.WriteLine("Lista invertida exitosamente.");
    }
}