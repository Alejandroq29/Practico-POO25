
using System;

namespace AgendaTelefonica
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Agenda agenda = new Agenda();
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("\n***** MENÚ DE AGENDA TELEFÓNICA *****");
                Console.WriteLine("1. Agregar contacto");
                Console.WriteLine("2. Buscar contacto");
                Console.WriteLine("3. Eliminar contacto");
                Console.WriteLine("4. Mostrar todos los contactos");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione una opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.Write("Nombre: ");
                        string nombre = Console.ReadLine();
                        Console.Write("Teléfono: ");
                        string telefono = Console.ReadLine();
                        Console.Write("Correo: ");
                        string correo = Console.ReadLine();
                        agenda.AgregarContacto(new Contacto(nombre, telefono, correo));
                        Console.WriteLine("Contacto agregado.");
                        break;

                    case "2":
                        Console.Write("Ingrese el nombre a buscar: ");
                        string nombreBuscar = Console.ReadLine();
                        var contacto = agenda.BuscarContacto(nombreBuscar);
                        Console.WriteLine(contacto != null ? contacto.ToString() : "Contacto no encontrado.");
                        break;

                    case "3":
                        Console.Write("Ingrese el nombre del contacto a eliminar: ");
                        string nombreEliminar = Console.ReadLine();
                        bool eliminado = agenda.EliminarContacto(nombreEliminar);
                        Console.WriteLine(eliminado ? "Contacto eliminado." : "Contacto no encontrado.");
                        break;

                    case "4":
                        Console.WriteLine("Contactos en la agenda:");
                        agenda.MostrarContactos();
                        break;

                    case "5":
                        continuar = false;
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }
            }
        }
    }
}



