using System;

namespace FigurasGeometricasApp
{
    // Clase base abstracta para figuras geométricas
    public abstract class FiguraGeometrica
    {
        // Se ubica el atributos privados encapsulados
        private double _base;
        private double _altura;

        // Constructor
        protected FiguraGeometrica(double @base, double altura)
        {
            _base = @base;
            _altura = altura;
        }

        // Propiedad pública para acceder y modificar la base usando get y set
        public double Base
        {
            get { return _base; }
            set { _base = value; }
        }

        // Propiedad pública para acceder y modificar la altura usando get y set
        public double Altura
        {
            get { return _altura; }
            set { _altura = value; }
        }

        // Método abstracto para calcular el área, aquella va hacer la subclases
        public abstract double CalcularArea();
        // Método abstracto para calcular el perímetro, aquella va hacer la subclases
        public abstract double CalcularPerimetro();
    }

    //Clase Cuadrado que hereda de FiguraGeometrica
    public class Cuadrado : FiguraGeometrica
    {
        // Constructor
        public Cuadrado(double lado) : base(lado, lado)
        {
            // En un cuadrado, base y altura son iguales (lado)
        }

        // Implementación del método para calcular el área del cuadrado
        public override double CalcularArea()
        {
            return Base * Altura; // esta funcion es lado * lado
        }

        // Implementación del método para calcular el perímetro del cuadrado
        public override double CalcularPerimetro()
        {
            return 4 * Base;
        }
    }

    // // Clase Rectangulo que hereda de FiguraGeometrica
    public class Rectangulo : FiguraGeometrica
    {
        // Constructor
        public Rectangulo(double @base, double altura) : base(@base, altura)
        {
            // Inicializa base y altura con los valores dados
        }

        // Implementación del método para calcular el área del rectángulo
        public override double CalcularArea()
        {
            return Base * Altura;
        }

        // Implementación del método para calcular el perímetro del rectángulo
        public override double CalcularPerimetro()
        {
            return 2 * (Base + Altura);
        }
    }

    // Este es el programa que realizara el resultado del area y perimetro
    class Program
    {
        static void Main(string[] args)
        {
            //Vamos a crear un cuadrado de lado 5
            Cuadrado cuadrado = new Cuadrado(5);
            Console.WriteLine("Cuadrado:");
            Console.WriteLine($"Área: {cuadrado.CalcularArea()}");
            Console.WriteLine($"Perímetro: {cuadrado.CalcularPerimetro()}");

            // Se crea un rectángulo de base 4 y altura 6
            Rectangulo rectangulo = new Rectangulo(4, 6);
            Console.WriteLine("\nRectángulo:");
            Console.WriteLine($"Área: {rectangulo.CalcularArea()}");
            Console.WriteLine($"Perímetro: {rectangulo.CalcularPerimetro()}");

            //En esta parte se modifican las dimensiones usando setters 
            rectangulo.Base = 10;
            rectangulo.Altura = 3;
            Console.WriteLine("\nRectángulo modificado:");
            Console.WriteLine($"Área: {rectangulo.CalcularArea()}");
            Console.WriteLine($"Perímetro: {rectangulo.CalcularPerimetro()}");
        }
    }
}
