using System;

namespace Day3StringManipulation2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string: " );
            string sentence = Console.ReadLine();

            while (sentence.Length > 0)
            {
                Console.WriteLine(sentence[0] + " = " + sentence);

                int temp = 0;
                for (int j = 0; j < sentence.Length; j++)
                {
                    if (sentence[0] == sentence[j])
                    {
                        temp++;
                    }

                    Console.WriteLine(temp);
                    sentence = sentence.Replace(sentence[0].ToString(), string.Empty);
                }
            }
           
        }
    }
}
