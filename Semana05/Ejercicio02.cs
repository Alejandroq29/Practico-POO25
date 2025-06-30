
public class Ejercicio02
{
    public static void Ejecutar()
    {
        List<string> asignaturas = new List<string> { "Matemáticas", "Física", "Química", "Historia", "Lengua" };
        foreach (string asignatura in asignaturas)
        {
            Console.WriteLine($"Yo estudio {asignatura}");
        }
    }
}