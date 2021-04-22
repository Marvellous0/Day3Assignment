using System;

namespace Day3IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            BackColor = Color.FromArgb(0, 0, r.Next(0, 256));
        }
    }
}
