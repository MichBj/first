 using System;
using System.Collections.Generic;

namespace Program
{
    public class Estadisticas
    {
        private List<double> numeros;

        public Estadisticas()
        {
            numeros = new List<double>();
        }

        public void CargarNumeros()
        {
            Console.Write("Ingrese una muestra de números separados por comas: ");
            string entrada = Console.ReadLine();

            string[] partes = entrada.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string parte in partes)
            {
                double numero;
                if (double.TryParse(parte, out numero))
                {
                    numeros.Add(numero);
                }
                else
                {
                    Console.WriteLine("Error: El valor '" + parte + "' no es un número válido.");
                }
            }
        }

        public void CalcularMediaYDesviacionTipica()
        {
            if (numeros.Count == 0)
            {
                Console.WriteLine("No hay números cargados.");
                return;
            }

            double suma = 0;
            foreach (double numero in numeros)
            {
                suma += numero;
            }

            double media = suma / numeros.Count;

            double sumaCuadrados = 0;
            foreach (double numero in numeros)
            {
                double diferencia = numero - media;
                sumaCuadrados += Math.Pow(diferencia, 2);
            }

            double desviacionTipica = Math.Sqrt(sumaCuadrados / numeros.Count);

            Console.WriteLine($"Media: {media}");
            Console.WriteLine($"Desviación típica: {desviacionTipica}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Estadisticas estadisticas = new Estadisticas();
            estadisticas.CargarNumeros();
            estadisticas.CalcularMediaYDesviacionTipica();

            Console.ReadKey();
        }
    }
}
