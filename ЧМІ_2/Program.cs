using System;

namespace ЧМІ_2
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {


                Console.WriteLine("Enter dimension of the matrix:");
                int n = Convert.ToInt32(Console.ReadLine());
                double[,] a = new double[n, n];
                double[] b = new double[n];
                double[] x = new double[n];//початкові наближення
                for (int i = 0; i < n; i++)
                {
                    x[i] = 0;
                }
                Console.WriteLine("Write down your matrix");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.WriteLine("Enter the element from position[" + (i + 1) + ", " + (j + 1) + "]:");
                        a[i, j] = Convert.ToDouble(Console.ReadLine());
                    }
                }
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Enter the value from position [" + (i + 1) + "]:");
                    b[i] = Convert.ToInt32(Console.ReadLine());
                }

                Seidel myMatrix = new Seidel(a, b, 500, n, x);
                myMatrix.GetSeidel();
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("X" + (i + 1) + " = " + myMatrix.roots[i]);
                }

            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
