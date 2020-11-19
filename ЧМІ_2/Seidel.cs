using System;
using System.Collections.Generic;
using System.Text;

namespace ЧМІ_2
{
    public class Seidel
    {
        static double eps = 0.01;
        int n, itrCounter, N; // розмірність матриці, кількість ітерацій, допустима кількість ітерацій
        double s, Xi, diff = 1;
        double[,] matrix;
        double[] value;
        public double[] roots;

        public Seidel(double[,] matrix, double[] value, int N, int n, double[] roots)
        {
            this.matrix = matrix;
            this.N = N;
            this.value = value;
            this.n = n;
            this.roots = roots;
        }
        public void GetSeidel()
        {
            itrCounter = 0;
            while (itrCounter<=N && diff>=eps)
            {
                itrCounter++;
                for (int i = 0; i < n; i++)
                {
                    s = 0;
                    for (int j = 0; j < n; j++)
                    {
                        if (i != j) 
                        {
                            s += matrix[i, j] * roots[j];
                        }
                    }
                    Xi = (value[i] - s) / matrix[i, i];
                    diff = Math.Abs(Xi - roots[i]);
                    roots[i] = Xi;
                }
            }
        }
    }
}
