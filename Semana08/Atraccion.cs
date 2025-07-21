using System;
using System.Collections.Generic;

public class Atraccion
{
    private Queue<Persona> cola = new Queue<Persona>();
    private List<Persona> asientosAsignados = new List<Persona>();
    private const int capacidadMaxima = 30;

    // Método para agregar persona y asignar asiento automáticamente o poner en cola
    public void AgregarPersona(Persona persona)
    {
        if (asientosAsignados.Count < capacidadMaxima)
        {
            asientosAsignados.Add(persona);
            Console.WriteLine($"✅ {persona.Nombre} ha sido asignado al asiento #{asientosAsignados.Count}.");
        }
        else
        {
            cola.Enqueue(persona);
            Console.WriteLine($"🕓 {persona.Nombre} ha sido agregado a la cola de espera.");
        }
    }

    // Método opcional si deseas reasignar asientos cuando se liberen (no usado actualmente)
    public void AsignarAsientos()
    {
        while (cola.Count > 0 && asientosAsignados.Count < capacidadMaxima)
        {
            Persona persona = cola.Dequeue();
            asientosAsignados.Add(persona);
            Console.WriteLine($"🎟️ Se asignó asiento a: {persona.Nombre}");
        }

        if (asientosAsignados.Count == capacidadMaxima)
        {
            Console.WriteLine("🔒 Todos los asientos están ocupados.");
        }
    }

    public void VerAsientosAsignados()
    {
        Console.WriteLine("\n🎢 Asientos asignados:");
        if (asientosAsignados.Count == 0)
        {
            Console.WriteLine("No hay personas sentadas todavía.");
        }
        else
        {
            for (int i = 0; i < asientosAsignados.Count; i++)
            {
                Console.WriteLine($"Asiento {i + 1}: {asientosAsignados[i]}");
            }
        }
    }

    public void VerColaPendiente()
    {
        Console.WriteLine("\n🧍 Personas en la cola de espera:");
        if (cola.Count == 0)
        {
            Console.WriteLine("No hay personas en la cola.");
        }
        else
        {
            foreach (var persona in cola)
            {
                Console.WriteLine($"- {persona}");
            }
        }
    }
}
