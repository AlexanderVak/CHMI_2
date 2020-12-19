using System;

namespace ЧМІ_2
{
    class Program
    {
        static void Main(string[] args)
        {
            void Test()
            {
                //double[,] a2 = { { 4, 2, 1 } , { 3, 4.5, 4 }, { 2, 1, 5 } };
                double[] b2 = { 20, 25, 17 };
                double[] x2 = { 0, 0, 0 };
                int n2 = 3;
                double[][] array =
                {
                    new double[] { 2, 1, 5 },
                    new double[] { 3, 4.5, 4 },
                    new double[] { 4, 2, 1 }
                };

                Seidel myMatrix = new Seidel(array, b2, 100, n2, x2);
                for (int i = 0; i < n2; i++)
                {
                    Console.WriteLine("X" + (i + 1) + " = " + myMatrix.roots[i]);
                }

                Console.WriteLine(" ");
                Console.WriteLine("Correct answer");
                x2[0] = 409.0 / 108.0;
                x2[1] = 89.0 / 54.0;
                x2[2] = 14.0 / 9.0;
                for (int i = 0; i < n2; i++)
                {
                    Console.WriteLine(x2[i]); 
                }
            }            

            do
            {
                Test();
                
                Console.WriteLine("Enter dimension of the matrix:");
                int n = Convert.ToInt32(Console.ReadLine());
                double[][] a = new double[n][];
                double[] b = new double[n];
                double[] x = new double[n];//початкові наближення
                for (int i = 0; i < n; i++)
                {
                    x[i] = 0;
                }
                Console.WriteLine("Write down your matrix");
                for (int i = 0; i < n; i++)
                {
                    a[i] = new double[n];
                    for (int j = 0; j < n; j++)
                    {                        
                        Console.WriteLine("Enter the element from position[" + (i + 1) + ", " + (j + 1) + "]:");
                        a[i][j] = Convert.ToDouble(Console.ReadLine());
                    }
                }
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Enter the value from position [" + (i + 1) + "]:");
                    b[i] = Convert.ToDouble(Console.ReadLine());
                }

                Seidel mymatrix = new Seidel(a, b, 50, n, x);
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("x" + (i + 1) + " = " + mymatrix.roots[i]);
                }

            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
