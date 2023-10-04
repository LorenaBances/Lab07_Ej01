using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_Ej01
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.Write("Ingrese el valor de n: ");
            int n = int.Parse(Console.ReadLine());

            decimal resultadoAcumulativo = 0m;

            for (int i = 1; i <= n; i++)
            {
                decimal numerador = 16m - i;
                decimal denominador = 3m * i;
                decimal resultado = numerador / denominador;
                resultadoAcumulativo += resultado;
                Console.WriteLine($"resultado : {resultado:F7}");
            }

            Console.WriteLine($"resultado acumulativo: {resultadoAcumulativo:F5}");

        }
    }
}






