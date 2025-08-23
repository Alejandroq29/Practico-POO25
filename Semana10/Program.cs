using System;
using System.Collections.Generic;
using System.Linq;

// Define el espacio de nombres para organizar el código.
namespace ReporteVacunacion
{
    /// Clase principal del programa.
    class Program
    {
        
        /// Punto de entrada de la aplicación de consola.
        static void Main(string[] args)
        {
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("  INFORME DE CAMPAÑA DE VACUNACIÓN COVID-19  ");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++\n");

            // --- PASO 1: INICIALIZACIÓN DE CONJUNTOS Y DATOS ---
            var universoCiudadanos = new HashSet<string>();
            var vacunadosPfizer = new HashSet<string>();
            var vacunadosAstraZeneca = new HashSet<string>();
            var random = new Random();

            int totalCiudadanos = 500;
            int cantidadVacunados = 75;

            // --- PASO 2: GENERACIÓN DE DATOS FICTICIOS ---
            for (int i = 1; i <= totalCiudadanos; i++)
            {
                universoCiudadanos.Add("Ciudadano " + i);
            }

            while (vacunadosPfizer.Count < cantidadVacunados)
            {
                int ciudadanoId = random.Next(1, totalCiudadanos + 1);
                vacunadosPfizer.Add("Ciudadano " + ciudadanoId);
            }

            while (vacunadosAstraZeneca.Count < cantidadVacunados)
            {
                int ciudadanoId = random.Next(1, totalCiudadanos + 1);
                vacunadosAstraZeneca.Add("Ciudadano " + ciudadanoId);
            }
            
            Console.WriteLine("--- RESUMEN DE DATOS GENERADOS ---\n");
            Console.WriteLine($"Total de ciudadanos en el sistema: {universoCiudadanos.Count}");
            Console.WriteLine($"Total de vacunados con Pfizer: {vacunadosPfizer.Count}");
            Console.WriteLine($"Total de vacunados con AstraZeneca: {vacunadosAstraZeneca.Count}\n");

            // --- PASO 3: APLICACIÓN DE OPERACIONES DE TEORÍA DE CONJUNTOS ---
            var ambasDosis = new HashSet<string>(vacunadosPfizer);
            ambasDosis.IntersectWith(vacunadosAstraZeneca);

            var soloPfizer = new HashSet<string>(vacunadosPfizer);
            soloPfizer.ExceptWith(vacunadosAstraZeneca);

            var soloAstraZeneca = new HashSet<string>(vacunadosAstraZeneca);
            soloAstraZeneca.ExceptWith(vacunadosPfizer);

            var todosVacunados = new HashSet<string>(vacunadosPfizer);
            todosVacunados.UnionWith(vacunadosAstraZeneca);
            
            var noVacunados = new HashSet<string>(universoCiudadanos);
            noVacunados.ExceptWith(todosVacunados);
            
            // --- PASO 4: PRESENTACIÓN EN TABLA ÚNICA ---
            
            Console.WriteLine("=======================================================================================");
            Console.WriteLine("                             TABLA CONSOLIDADA DE RESULTADOS                           ");
            Console.WriteLine("=======================================================================================");

            // Convertir los conjuntos a listas para poder acceder por índice y ordenarlos
            var listaNoVacunados = noVacunados.ToList();
            listaNoVacunados.Sort();
            var listaAmbasDosis = ambasDosis.ToList();
            listaAmbasDosis.Sort();
            var listaSoloPfizer = soloPfizer.ToList();
            listaSoloPfizer.Sort();
            var listaSoloAstra = soloAstraZeneca.ToList();
            listaSoloAstra.Sort();

            // Imprimir los encabezados de la tabla con un ancho fijo para cada columna
            Console.WriteLine($"{"NO VACUNADOS", -22} | {"AMBAS DOSIS", -22} | {"SOLO PFIZER", -22} | {"SOLO ASTRAZENECA", -22}");
            Console.WriteLine(new string('-', 97));

            // Imprimir los totales de cada categoría
            Console.WriteLine($"{"Total: " + listaNoVacunados.Count, -22} | {"Total: " + listaAmbasDosis.Count, -22} | {"Total: " + listaSoloPfizer.Count, -22} | {"Total: " + listaSoloAstra.Count, -22}");
            Console.WriteLine(new string('-', 97));

            // Determinar el número de filas necesarias por la lista más larga
            int maxRows = new[] { listaNoVacunados.Count, listaAmbasDosis.Count, listaSoloPfizer.Count, listaSoloAstra.Count }.Max();

            // Iterar para imprimir cada fila de la tabla
            for (int i = 0; i < maxRows; i++)
            {
                // Obtener el ciudadano de cada lista si el índice existe; si no, dejar en blanco
                string noVac = i < listaNoVacunados.Count ? listaNoVacunados[i] : "";
                string ambas = i < listaAmbasDosis.Count ? listaAmbasDosis[i] : "";
                string pfizer = i < listaSoloPfizer.Count ? listaSoloPfizer[i] : "";
                string astra = i < listaSoloAstra.Count ? listaSoloAstra[i] : "";

                // Imprimir la fila formateada
                Console.WriteLine($"{noVac, -22} | {ambas, -22} | {pfizer, -22} | {astra, -22}");
            }
             Console.WriteLine("=======================================================================================");
        }
    }
}