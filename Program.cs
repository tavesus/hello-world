using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorevnovanie1
{
    class Program
    {
        static void Calc(int[,] mass1, int n, int m,bool a)
        {
            if (a == true)
            {

                int k = 0;

                for (int i = 0; i < n; i++)
                {
                    if (mass1[n, i] == 0) { k++; }
                }

                for (int i = m; i < m; i++)
                {
                    if (mass1[i, m] == 0) { k++; }
                }

                Console.WriteLine(k);
            }
            if (a == false)
            {

                for (int i = 0; i < m; i++)
                {
                    if (Convert.ToInt32(mass1[n, i]) == 0) {  Console.WriteLine(n + " " + i); }
                }

                for (int i = m; i < n; i++)
                {
                    if (Convert.ToInt32(mass1[i, m]) == 0) { Console.WriteLine(i + " " + m); }
                }  
         
            }
        }
        static void Main(string[] args)
        {


            string[] input = Console.ReadLine().Split();

            int n = Convert.ToInt32(input[0]);
            int m = Convert.ToInt32(input[1]);
            int k = Convert.ToInt32(input[2]);

            int[,] field = new int[n, m];
            string[,] command_field = new string[k,3];

            for (int i = 0; i < k; i++)
            {

                string[] text = Console.ReadLine().Split();

                for (int j = 0; j < 3; j++)
                {
                    command_field[i,j] = text[j];    
                }
            }

            for (int i = 0; i < n; i++)
            {
                if(command_field[i,0] == "Color") 
                {
                    field[Convert.ToInt32(command_field[i,1]) - 1,Convert.ToInt32(command_field[i,2]) - 1] = 1;
                }
                if (command_field[i, 0] == "Neighbors")
                {
                    Calc(field, n, m, true);
                    Calc(field, n, m, false);
                }
            }

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
            //        Console.Write(field[i,j] + " ");
            //    }
            //    Console.WriteLine();
            //}
        }
    }
}
