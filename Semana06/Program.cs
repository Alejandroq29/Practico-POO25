class Program
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

