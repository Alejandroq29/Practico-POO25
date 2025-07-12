using System;
using System.Collections.Generic;

public class VerificadorDeBalance
{
    /// <summary>
    /// Determina si los paréntesis, llaves y corchetes en una expresión están balanceados.
    /// </summary>
    /// <param name="expresion">La expresión matemática como cadena de texto.</param>
    /// <returns>True si está balanceada, de lo contrario False.</returns>
    public static bool EstanSimbolosBalanceados(string expresion)
    {
        // La pila almacenará los caracteres de apertura: (, { y [
        Stack<char> pila = new Stack<char>();

        // Se recorre cada caracter de la expresión
        foreach (char caracter in expresion)
        {
            // Si es un símbolo de apertura, lo agregamos a la pila
            if (caracter == '(' || caracter == '{' || caracter == '[')
            {
                pila.Push(caracter);
            }
            // Si es un símbolo de cierre, verificamos la correspondencia
            else if (caracter == ')' || caracter == '}' || caracter == ']')
            {
                // Si la pila está vacía, no hay un símbolo de apertura para este cierre
                if (pila.Count == 0)
                {
                    return false;
                }

                // Sacamos el último elemento de la pila para compararlo
                char ultimoSimboloAbierto = pila.Pop();

                // Verificamos si el símbolo de cierre corresponde al último de apertura
                if ((caracter == ')' && ultimoSimboloAbierto != '(') ||
                    (caracter == '}' && ultimoSimboloAbierto != '{') ||
                    (caracter == ']' && ultimoSimboloAbierto != '['))
                {
                    return false; // No coinciden, por lo tanto no está balanceado
                }
            }
        }

        // Si al final del recorrido la pila está vacía, la expresión está balanceada.
        // Si no está vacía, significa que quedaron símbolos de apertura sin cerrar.
        return pila.Count == 0;
    }
}