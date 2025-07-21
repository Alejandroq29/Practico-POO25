public class Persona
{
    public int Id { get; }
    public string Nombre { get; }

    public Persona(int id, string nombre)
    {
        Id = id;
        Nombre = nombre;
    }

    public override string ToString()
    {
        return $"[ID: {Id}] Nombre: {Nombre}";
    }
}
