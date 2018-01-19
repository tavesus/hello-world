﻿using System;
 // Закраска клеток
namespace sorevnovanie1
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split();

            int n = Convert.ToInt32(input[0]);
            int m = Convert.ToInt32(input[1]);

            int[] max = { 0, 0 };
            int[] max2 = { 0, 0 };

            int[] allLinesMax = { 0, 0 };
            int[] allLinesMax2 = { 0, 0 };
            bool haveAllLinesStart = false;

            for (int i = 0; i < n; i++)
            {

                string[] numbers = Console.ReadLine().Split();

                for (int j = 0; j < m; j++)
                {
                    if (Convert.ToInt32(numbers[j]) > max2[0]) { max2[0] = Convert.ToInt32(numbers[i]); max2[1] = i; haveAllLinesStart = false; }
                    else
                    {
                        if (Convert.ToInt32(numbers[j]) == max[0])
                        {
                            allLinesMax2[1] = i;
                            haveAllLinesStart = true;

                            for (int s = 0; s < m; s++)
                            {
                                allLinesMax2[0] += Convert.ToInt32(numbers[j]);
                            }

                        }
                    }
                }

                if (allLinesMax[0] < allLinesMax2[0]) { allLinesMax[0] = allLinesMax2[0]; allLinesMax[1] = allLinesMax2[1]; }
                if (max[0] < max2[0]) { max[0] = max2[0]; max[1] = max2[1]; }

            }

            if (haveAllLinesStart) { Console.WriteLine(allLinesMax[1]); }
            else { Console.WriteLine(max[1]); }

        }
    }
}
/*
3 3
1 2 3
4 5 6
7 8 9

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Та самая задача
namespace projectName
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split();
            int n = Convert.ToInt32(s[0]);
            int m = Convert.ToInt32(s[1]);
            int[] x = new int[n];
            for (int i = 0; i < n; i++)
            {
                string[] e = Console.ReadLine().Split();
                Tuple<int, int, int> t = new Tuple<int, int, int>(Convert.ToInt32(e[0]), Convert.ToInt32(e[1]),i+1;
                x[i] = t.Item1;
            }
            
        }
    }
}
using System;
//http://informatics.mccme.ru/mod/statements/view3.php?id=27052&chapterid=505#1
namespace SDSD
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = Convert.ToInt32(input[0]);
            int t = Convert.ToInt32(input[1]);
            int [,] cub = new int[n + 2,n + 2];
            int[,] cub2 = new int[n, n];

            for (int i = 1; i < n + 1; i++)
            {
                for (int j = 1; j < n + 1; j++)
                {
                    cub[i, j] = 1;
                }
            }
            for (int i = 1; i < n + 1; i++)
            {

                for (int j = 1; j < n + 1; j++)
                {
                    int counter = 0;
                    if (cub[i - 1, j] == 1) { counter++; }
                    if (cub[i + 1, j] == 1) { counter++; }
                    if (cub[i, j - 1] == 1) { counter++; }
                    if (cub[i, j + 1] == 1) { counter++; }

                    if (counter == 3 && cub[i, j] == 1) { cub2[i - 1, j - 1] = 0; }
                    if (counter == 3 && cub[i, j] != 1) { cub2[i - 1, j - 1] = 1; }
                    if (counter > 2 && cub[i, j] == 1) { cub2[i - 1, j - 1] = 0; }

                    Console.Write(cub2[i-1,j-1] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
