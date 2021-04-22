using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day3Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> information = new List<string>();

            string name;
            double total;

            double[] scores = new double[9];

            int i = 0;

            double bio191, bio103, bio101, chm101, chm191, chm103, phs105, phs191, phs101, mts101;

            Console.Write("Enter the name of the Student :");
            name = Console.ReadLine();

            Console.Write("Input  the marks of Bio 101 : ");
            bio101 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input  the marks of  Bio 191 : ");
            bio191 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input  the marks of  Bio 103 : ");
            bio103 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input  the marks of  Chm 101 : ");
            chm101 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input  the marks of  Chm 191 : ");
            chm191 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input  the marks of  Chm 103 : ");
            chm103 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input  the marks of  Phs 105 : ");
            phs105 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input  the marks of  Phs 191 : ");
            phs191 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input  the marks of  Phs 101 : ");
            phs101 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input  the marks of Mts 101 : ");
            mts101 = Convert.ToInt32(Console.ReadLine());

            total = bio191 + bio103 + bio101 + chm101 + chm191 + chm103 + phs105 + phs191 + phs101 + mts101;

            Console.WriteLine($"Total score = {total}");

            if (scores.Length > 0)
            {
                double small = scores[i];
                double large = scores[1];
                for (i = 0; i < scores.Length; i++)
                {
                    if (large < scores[i])
                    {
                        double tmp = large;
                        large = scores[i];
                        scores[i] = large;
                    }

                    if (small > scores[i])
                    {
                        double tmp = small;
                        small = scores[i];
                        scores[i] = small;
                    }
                }
                Console.WriteLine("Smallest is {0}", small);
                Console.WriteLine("Largest is {0}", large);
            }

            // for (int i = 0; i < scores.Length; i++)
            // {
            //     if (scores[i] > scores[i + 1])
            //     {
            //         double max = Math.Max();
            //     }

            // }
            // double max = scores.Max();
            // double min = scores.Min();

            // Console.WriteLine("Largest element in the array is: ", max);
            // Console.WriteLine("Smallest element in the array is: ", min);
            // Console.WriteLine(Math.Max(bio191, bio103, bio101, chm101, chm191, chm103, phs105, phs191, phs101, mts101));

            // Console.WriteLine(Math.Min(bio191, bio103, bio101, chm101, chm191, chm103, phs105, phs191, phs101, mts101));

            // Console.Write("\nRoll No : {0}\nName of Student : {1}\n", rl, nm);
            // Console.Write("Marks in Physics : {0}\nMarks in Chemistry : {1}\nMarks in Computer Application : {2}\n", phy, che, ca);
            // Console.Write("Total Marks = {0}\nPercentage = {1}\nDivision = {2}\n", total, per, div);
        }
    }
}
