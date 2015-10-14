using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1_NewtonMethod;
using Task2_Jagged_array;
namespace UIForTests
{
    class Program
    {
        static void Main(string[] args)
        {
            //double x = 9;
            //int n = 2;
            //double e = 0.0001;

            //double a = NewtonMethod.RootExtract(x, n, e);
            //double b = Math.Pow(x, 1.0 / n);
            //Console.WriteLine("NewtonMethod - {0}\n Math.Pow - {1}", a, b);
            var ar = new int[5][];
             ar[2]= new int[]{2,3};
             ar[3] = new int[]{-60,-1,9};

             for (int i = 0; i < ar.Length; i++)
             {
                 if (ar[i] != null)
                 {
                     for (int j = 0; j < ar[i].Length; j++)
                         Console.Write(ar[i][j] + " ");
                     Console.WriteLine();
                 }
                 else
                     Console.WriteLine("null");
             }
             Console.WriteLine();

              JaggedSort.Sort(ar,SortingType.IncreasingMaxElements);


              for (int i = 0; i < ar.Length; i++)
              {
                  if (ar[i] != null)
                  {
                      for (int j = 0; j < ar[i].Length; j++)
                          Console.Write(ar[i][j] + " ");
                      Console.WriteLine();
                  }
                  else
                      Console.WriteLine("null");
              }
              Console.WriteLine();
        }
    }
}
