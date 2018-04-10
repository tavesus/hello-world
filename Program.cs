using System;

namespace SuperSdvig
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] input = Console.ReadLine().Split();
            int k = Convert.ToInt32(Console.ReadLine());
            string[] output = new string [n];

            for (int i = 0; i < n; i++)
            {
                for (int j = i , l = 0; l < k + 1; l++,j++)
                {
                    if (l == k) { output[j] = input[i]; }
                    if (j == n - 1) { j = -1; }
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(output[i] + " ");
            }
        }
    }
}
