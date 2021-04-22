using System;

namespace Day3StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string word, reverse;

            Console.WriteLine("Enter string to reverse: ");
            word = Console.ReadLine();

            char[] ch = word.ToCharArray();

            Array.Reverse(ch);
            reverse = new string(ch);

            bool b = word.Equals(reverse, StringComparison.OrdinalIgnoreCase);
            if (b == true)
            {
                Console.WriteLine(" " + word + " is a Palindrome!");
                Console.WriteLine($"The reverse of the string is {b}");
            }
            else
            {
                Console.WriteLine(" " + word + " is not a Palindrome!");
            }
            // string word, revserse = "";

            // Console.WriteLine(" Enter a string: ");
            // string word = Console.ReadLine();

            // for (int i = word.Length - 1; i >= 0; i--) //String Reverse  
            // {
            //     revserse += word[i].ToString();
            // }
            // if (revserse == word) // Checking whether string is palindrome or not  
            // {
            //     Console.WriteLine("String is Palindrome \n Entered String Was {0} and reverse string is {1}", word, revserse);
            // }
            // else
            // {
            //     Console.WriteLine("String is not Palindrome \n Entered String Was {0} and reverse string is {1}", word, revserve);
            // }
        }
    }
}
