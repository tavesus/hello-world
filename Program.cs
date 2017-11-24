using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorevnovanie1
{
    class Program
    {

        static void Up(int[,] field, int x, int y)
        {
            for (int i = x; i != 0; i--)
            {
                if (field[i-1, y] == 0) { Console.WriteLine((i-1) + " " + y); break; }
            }
        }
        static void Doun(int[,] field, int x, int y)
        {

        }
        static void Right(int[,] field, int x, int y)
        {

        }
        static void Left(int[,] field, int x, int y)
        {

        }

        static void Main(string[] args)
        {


            string[] input = Console.ReadLine().Split();

            int n = Convert.ToInt32(input[0]);
            int m = Convert.ToInt32(input[1]);
            int k = Convert.ToInt32(input[2]);

            int[,] field = new int[n+1, m+1];
            string[,] command_field = new string[k, 3];

            //Ввод команд

            for (int i = 0; i < k; i++)
            {

                string[] text = Console.ReadLine().Split();

                for (int j = 0; j < 3; j++)
                {
                    command_field[i, j] = text[j];
                }
            }

            //*

            for (int i = 0; i < k; i++)
            {
                if (command_field[i, 0] == "Color")
                {
                    field[Convert.ToInt32(command_field[i, 1]), Convert.ToInt32(command_field[i, 2])] = 1;
                }
                else
                {
                    int x = Convert.ToInt32(command_field[i, 1]);
                    int y = Convert.ToInt32(command_field[i, 2]);

                    Up(field, x, y);
                }
            }

            //Вывод field

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
            //        Console.Write(field[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //*

        }
    }
}