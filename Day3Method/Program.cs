﻿using System;

namespace Day3Method
{
    class Program
    {
        static void Main(string[] args)
        {

            bool isPrime = true;
            Console.WriteLine("Prime Numbers : ");

            for (int i = 2; i <= 100; i++)
            {
                for (int j = 2; j <= 100; j++)
                {

                    if (i != j && i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }

                }
                if (isPrime)
                {
                    Console.Write("\n" + i);
                }
                isPrime = true;
            }
        }
    }
}
