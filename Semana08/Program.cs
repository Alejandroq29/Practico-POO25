using System;

class Program
{
    static void Main(string[] args)
    {
        Atraccion atraccion = new Atraccion();
        int contador = 1;
        string? opcion; // ← ahora acepta null y resuelve el error

        do
        {
            Console.WriteLine("\n--- Menú ---");
            Console.WriteLine("1. Agregar persona a la cola");
            Console.WriteLine("2. Asignar asientos");
            Console.WriteLine("3. Ver asientos asignados");
            Console.WriteLine("4. Ver personas en cola");
            Console.WriteLine("5. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = Console.ReadLine(); // ← ya no da error

            switch (opcion)
            {
                case "1":
                    Console.Write("Ingrese nombre de la persona: ");
                    string? nombre = Console.ReadLine();

                    if (!string.IsNullOrWhiteSpace(nombre))
                    {
                        Persona nueva = new Persona(contador++, nombre!); // null-forgiving porque ya validamos
                        atraccion.AgregarPersona(nueva);
                    }
                    else
                    {
                        Console.WriteLine("❌ El nombre no puede estar vacío.");
                    }
                    break;

                case "2":
                    atraccion.AsignarAsientos();
                    break;

                case "3":
                    atraccion.VerAsientosAsignados();
                    break;

                case "4":
                    atraccion.VerColaPendiente();
                    break;

                case "5":
                    Console.WriteLine("Saliendo...");
                    break;

                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        } while (opcion != "5");
    }
}
