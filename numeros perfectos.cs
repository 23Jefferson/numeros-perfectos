using System;

namespace NumerosPerfectos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Verificación de Números Perfectos");
            Console.WriteLine("===============================");

            Console.Write("Ingrese un número para verificar si es perfecto: ");
            int numeroVerificar = int.Parse(Console.ReadLine());

            if (EsNumeroPerfecto(numeroVerificar))
            {
                Console.WriteLine($"{numeroVerificar} es un número perfecto.");
            }
            else
            {
                Console.WriteLine($"{numeroVerificar} no es un número perfecto.");
            }

            Console.WriteLine("\nNúmeros Perfectos entre 1 y 1000:");
            for (int num = 1; num <= 1000; num++)
            {
                if (EsNumeroPerfecto(num))
                {
                    Console.WriteLine($"{num} es un número perfecto. Factores:");
                    MostrarFactores(num);
                }
            }
        }

        static bool EsNumeroPerfecto(int num)
        {
            int sumaFactores = 0;

            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    sumaFactores += i;
                }
            }

            return sumaFactores == num;
        }

        static void MostrarFactores(int num)
        {
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    Console.Write($"{i} ");
                }
            }
            Console.WriteLine();
        }
    }
}