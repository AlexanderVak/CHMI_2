using System;

namespace ЧМІ_2
{
    class Program
    {
        static void Main(string[] args)
        {
            void Test()
            {
                double[,] a = {{ 20, 2, 3, 7 }, { 1, 12, -2, -5 }, { 5, -3, 13, 0 }, { 0, 0, -1, 15 }};
                double[] b = { 5, 4, -3, 7 };
                double[] x = { 0, 0, 0, 0};
                int n = 4;

                Seidel myMatrix = new Seidel(a, b, 100, n, x);
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("X" + (i + 1) + " = " + myMatrix.roots[i]);
                }

                Console.WriteLine(" ");
                x[0] = 409.0 / 108.0;
                x[1] = 89.0 / 54.0;
                x[2] = 14.0 / 9.0;
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine(x[i]); 
                }
            }            

            do
            {
                Test();
                
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
                    b[i] = Convert.ToDouble(Console.ReadLine());
                }

                Seidel myMatrix = new Seidel(a, b, 50, n, x);
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("X" + (i + 1) + " = " + myMatrix.roots[i]);
                }

            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
