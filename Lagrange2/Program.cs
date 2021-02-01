using System;

namespace Lagrange2
{
    public class Lagrange
    {
        public static void Main()
        {
            const int size = 5;
            var xValues = new double[size];
            var yValues = new double[size];
            xValues[0] = -5; yValues[0] = 10;
            xValues[1] = -3.5; yValues[1] = 12.5;
            xValues[2] = 1; yValues[2] = 11;
            xValues[3] = 1.5; yValues[3] = 5;
            xValues[4] = 2.7; yValues[4] = 3;

            //for (int i = 0; i < size; i++)
            //{
            //    xValues[i] = i;
            //    yValues[i] = TestF(i);
            //}

            Console.WriteLine(InterpolateLagrangePolynomial(1.75, xValues, yValues, size));
            Console.ReadKey();
        }

        public static double InterpolateLagrangePolynomial(double x, double[] xValues, double[] yValues, int size)
        {
            double lagrangePol = 0;

            for (int i = 0; i < size; i++)
            {
                double basicsPol = 1;
                for (int j = 0; j < size; j++)
                {
                    if (j != i)
                    {
                        basicsPol *= (x - xValues[j]) / (xValues[i] - xValues[j]);
                    }
                }
                lagrangePol += basicsPol * yValues[i];
            }

            return lagrangePol;
        }

        //static double TestF(double x)
        //{
        //    return x * x * x + 3 * x * x + 3 * x + 1; // for example
        //}
    }
}
