using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_02_Exp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int celsius_inicio = 5;
            int celsius_fin = 100;
            int intervalo = 5;

            double promedio = 0;
            double minimo = double.MaxValue;
            double maximo = double.MinValue;
            int temp_entre_120y200 = 0;

            Console.WriteLine(" GRADOS\t\tGRADOS");
            Console.WriteLine(" CELSIUS\tFAHRENHEIT");
            Console.WriteLine(" =======\t==========");

            for (int celsius = celsius_inicio; celsius <= celsius_fin; celsius += intervalo)
            {
                double fahrenheit = (9.0 / 5.0) * celsius + 32.0;
                Console.WriteLine($"{celsius,5}\t {fahrenheit,15:F2}");

                promedio += fahrenheit;

                if (fahrenheit < minimo) {
                    minimo = fahrenheit;
                }

                if (fahrenheit > maximo) {
                    maximo = fahrenheit;
                }

                if (fahrenheit >= 120 && fahrenheit <= 200) {
                    temp_entre_120y200++;
                }
            }

            promedio /= ((celsius_fin - celsius_inicio) / intervalo) + 1;

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" Promedio Fahrenheit: " + promedio.ToString("F2"));
            Console.WriteLine(" Mínima temperatura Fahrenheit: " + minimo.ToString("F2"));
            Console.WriteLine(" Máxima temperatura Fahrenheit: " + maximo.ToString("F2"));
            Console.WriteLine(" Temperaturas Fahrenheit entre 120 y 200: " + temp_entre_120y200);
            Console.ReadKey();
        }
    }
}
