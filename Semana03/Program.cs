using System;

class Estudiante
{
    // Identificador único del estudiante
    public int Id { get; set; }

    // Nombre(s) del estudiante
    public string Nombres { get; set; }

    // Apellidos del estudiante
    public string Apellidos { get; set; }

    // Dirección del estudiante
    public string Direccion { get; set; }

    // Array va almacenar los tres números de teléfono del estudiante
    public string[] Telefonos { get; set; }

    // Ubicaremos el constructor para inicializar los datos del estudiante
    public Estudiante(int id, string nombres, string apellidos, string direccion, string[] telefonos)
    {
        Id = id;
        Nombres = nombres;
        Apellidos = apellidos;
        Direccion = direccion;
        Telefonos = telefonos;
    }

    // Se mostrara la información del estudiante
    public void MostrarDatos()
    {
        Console.WriteLine("**** Datos del Estudiante ****");
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Nombres: {Nombres}");
        Console.WriteLine($"Apellidos: {Apellidos}");
        Console.WriteLine($"Dirección: {Direccion}");
        Console.WriteLine("Teléfonos:");

        
        // Se recorre el array de teléfonos y lo muestra
        foreach (string telefono in Telefonos)
        {
            Console.WriteLine($" - {telefono}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Se realizara la creación de un estudiante con los datos
        string[] telefonosdelEstudiante = {
            "0960218041",
            "0901245820",
            "0930695174" };
        Estudiante estudiante = new Estudiante(1985, "Emanuel Andres", "Palacios Valencia", "Guayaquil, Av. Richard Burgos", telefonosdelEstudiante);

        // Se mostraran los datos del estudiante
        estudiante.MostrarDatos();
    }
}
