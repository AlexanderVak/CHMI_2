using System;
using System.Collections.Generic;
using System.Text;

namespace ЧМІ_2
{
    public class Seidel
    {
        static double eps = 0.01;
        static double lambda = .5;
        int n, maxItr; 
        double[,] matrix;
        double[] bValue;
        public double[] roots;

        public Seidel(double[,] matrix, double[] bValue, int maxItr, int n, double[] roots)
        {
            this.matrix = matrix;
            this.maxItr = maxItr;
            this.bValue = bValue;
            this.n = n;
            this.roots = roots;
            GetSeidel();
        }
        private void GetSeidel()
        {
            //Division by the diagonal element to reduce calculation
            for (int i = 0; i < n; i++)
            {
                double d = matrix[i, i];
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = matrix[i, j] / d;
                }
                bValue[i] = bValue[i] / d;
            }

            //Generation of initial values for roots
            for (int i = 0; i < n; i++)
            {
                double sum = bValue[i];
                for (int j = 0; j < n; j++)
                {
                    if (i != j)
                    {
                        sum -= (matrix[i, j] * roots[j]);
                    }
                }
                roots[i] = sum;
            }

            //Iterations for converging to the real roots
            for (int itr = 1; itr < maxItr; itr++)
            {

                for (int i = 0; i < n; i++)
                {
                    double old = roots[i];
                    double sum = bValue[i];

                    for (int j = 0; j < n; j++)
                    {
                        if (i != j)
                            sum -= (matrix[i, j] * roots[j]);
                    }

                    roots[i] = lambda * sum + (1 - lambda) * old;
                    if (roots[i] != 0)
                    {
                        double diff = Math.Abs((roots[i] - old) / roots[i]) * 100;
                        if (diff < eps)
                            break;
                    }
                }
            }
        }
    }
}