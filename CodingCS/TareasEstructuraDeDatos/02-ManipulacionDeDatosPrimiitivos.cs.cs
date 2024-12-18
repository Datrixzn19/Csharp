using System;

// Clase para representar un Círculo
public class Circulo
{
    public double Radio { get; set; }

    public double CalcularArea()
    {
        return Math.PI * Radio * Radio;
    }

    public double CalcularPerimetro()
    {
        return 2 * Math.PI * Radio;
    }
}

// Clase para representar un Rectángulo
public class Rectangulo
{
    public double Base { get; set; }
    public double Altura { get; set; }

    public double CalcularArea()
    {
        return Base * Altura;
    }

    public double CalcularPerimetro()
    {
        return 2 * (Base + Altura);
    }
}

class Program
{
    static void Resultado()
    {
        Circulo circulo = new Circulo { Radio = 5 };
        Console.WriteLine($"Área del Círculo: {circulo.CalcularArea()}");
        Console.WriteLine($"Perímetro del Círculo: {circulo.CalcularPerimetro()}");

        Rectangulo rectangulo = new Rectangulo { Base = 4, Altura = 6 };
        Console.WriteLine($"Área del Rectángulo: {rectangulo.CalcularArea()}");
        Console.WriteLine($"Perímetro del Rectángulo: {rectangulo.CalcularPerimetro()}");
    }
}