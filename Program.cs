
// Importar la biblioteca System para utilizar sus clases y métodos
using System;

// Definir la clase Rectangulo
public class Rectangulo
{
    // Declarar las variables privadas para almacenar el largo y ancho del rectángulo
    private double largo;
    private double ancho;

    // Constructor para inicializar el rectángulo con largo y ancho
    public Rectangulo(double largo, double ancho)
    {
        // Asignar los valores de largo y ancho a las variables privadas
        this.largo = largo;
        this.ancho = ancho;
    }

    // Método para calcular el área del rectángulo
    public double CalcularArea()
    {
        // Retornar el resultado de multiplicar el largo por el ancho
        return largo * ancho;
    }

    // Método para calcular el perímetro del rectángulo
    public double CalcularPerimetro()
    {
        // Retornar el resultado de multiplicar por 2 la suma del largo y el ancho
        return 2 * (largo + ancho);
    }
}

// Definir la clase Rombo
public class Rombo
{
    // Declarar las variables privadas para almacenar las diagonales del rombo
    private double diagonal1;
    private double diagonal2;

    // Constructor para inicializar el rombo con diagonales
    public Rombo(double diagonal1, double diagonal2)
    {
        // Asignar los valores de las diagonales a las variables privadas
        this.diagonal1 = diagonal1;
        this.diagonal2 = diagonal2;
    }

    // Método para calcular el área del rombo
    public double CalcularArea()
    {
        // Retornar el resultado de multiplicar las diagonales y dividir por 2
        return (diagonal1 * diagonal2) / 2;
    }

    // Método para calcular el perímetro del rombo
    public double CalcularPerimetro()
    {
        // Calcular la longitud del lado del rombo utilizando el teorema de Pitágoras
        double lado = Math.Sqrt(Math.Pow(diagonal1 / 2, 2) + Math.Pow(diagonal2 / 2, 2));
        // Retornar el resultado de multiplicar por 4 la longitud del lado
        return 4 * lado;
    }
}

// Clase principal para ejecutar el programa
class Program
{
    // Método principal para ejecutar el programa
    static void Main(string[] args)
    {
        // Instancia de la clase Rectangulo con largo 4 y ancho 5
        Rectangulo miRectangulo = new Rectangulo(4, 5);

        // Mostrar el área y perímetro del rectángulo
        Console.WriteLine("Rectángulo:");
        Console.WriteLine($"Área: {miRectangulo.CalcularArea():F2}"); // Imprimir con 2 decimales
        Console.WriteLine($"Perímetro: {miRectangulo.CalcularPerimetro():F2}"); // Imprimir con 2 decimales

        // Crear una instancia de la clase Rombo con diagonales 6 y 8
        Rombo miRombo = new Rombo(6, 8);

        // Mostrar el área y perímetro del rombo
        Console.WriteLine("\nRombo:");
        Console.WriteLine($"Área: {miRombo.CalcularArea():F2}"); // Imprimir con 2 decimales
        Console.WriteLine($"Perímetro: {miRombo.CalcularPerimetro():F2}"); // Imprimir con 2 decimales

        // Esperar que el usuario presione una tecla antes de cerrar
        Console.ReadKey();
    }
}

