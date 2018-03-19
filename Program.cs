using System;
using System.Text;

namespace cSuper
{
    class Program
    {       
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = Convert.ToInt32(input[0]);
            int m = Convert.ToInt32(input[1]);
            double S1 = Convert.ToDouble(input[2]);
            double a1 = Math.Sqrt( (4 * Math.Tan(Math.PI / n)) / n );
            double P = a1 * n;

            double a2 = P / m;
            double S2 = (n * (a2 * a2)) / ( 4 * Math.Tan(Math.PI / n) );

            Console.WriteLine(S2);
        }
    }
}
