using System;
using System.Collections.Generic;

namespace Day3Class2
{
    class Program
    {
        static void Main(string[] args)
        {
            int col;
            int row;
            int j;
            int i;

            Console.Write("Enter the Colomn of the Matrix : ");
            col = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the row of the Matrix : ");
            row = Convert.ToInt32(Console.ReadLine());

            int[,] Arr = new int[10000, 10000];


            Console.Write("\nEnter The Matrix Elements : ");
            for (i = 0; i < col; i++)
            {
                for (j = 0; j < row; j++)
                {
                    Arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("\nMatrix A : ");
            // for (i = 0; i < col; i++)
            // {
                for (j = 0; j < row; j++)
                {
                    Console.WriteLine(Arr[i, j] + "\t");

                }
                Console.WriteLine();
            //}
        }
    }
}
