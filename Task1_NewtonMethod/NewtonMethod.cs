﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_NewtonMethod
{
    public static class NewtonMethod
    {

        public static double RootExtract(double A, int n, double e)
        {
            if (Double.IsNaN(A) || Double.IsNaN(n) || Double.IsNaN(e))               
                return Double.NaN;
            if (n == 0)
                return 1;
            if (A < 0 && n % 2 == 0)
                return Double.NaN;
            if (Math.Abs(A) < e)
                return 0;

            double x = A, x0;

            do
            {
                x0 = x;
                x = 1.0 / n * ((n - 1) * x0 + (A / Math.Pow(x0, n - 1)));

            } while (Math.Abs((x - x0)) > e);
            return x;

        }
    } 
}
