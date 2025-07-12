using System;

/// <summary>
/// Clase principal que ejecuta el programa de verificación.
/// </summary>
public class Program
{
    public static void Main(string[] args)
    {
        // 1. Pedir al usuario que ingrese la expresión
        Console.Write("Ingrese una expresión matemática: ");
        string entrada = Console.ReadLine();

        // 2. Usar la clase de lógica para obtener el resultado
        bool estaBalanceado = VerificadorDeBalance.EstanSimbolosBalanceados(entrada);

        // 3. Mostrar el resultado al usuario
        if (estaBalanceado)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Resultado: La fórmula está balanceada. ✅");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Resultado: La fórmula NO está balanceada. ❌");
        }
        
        // Restablecer el color de la consola
        Console.ResetColor();
    }
}
