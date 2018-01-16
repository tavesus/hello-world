﻿using System;

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
