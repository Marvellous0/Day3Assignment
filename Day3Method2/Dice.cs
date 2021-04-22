using System;

namespace Day3Method2
{
    public class Dice
    {
        public static int dice1;
        public static int dice2;

        public static int total;

        public static int score;
        public static void DiceRoll()
        {
            Console.WriteLine("Press enter to roll the dice. ");

            Random random = new Random();
            dice1 = random.Next(1, 7);
            dice2 = random.Next(1, 7);

            Console.WriteLine($"Dice1 = {dice1}\n Dice 2 = {dice2}");
        }

         public static void CheckSum()
         {
            total = dice1 + dice2;

            Console.WriteLine($"Total Roll: {dice1} + {dice2} = {total}");

            if (total == 2 || total == 3 || total == 12)
            {
                Console.WriteLine($"You scored a total of {total}.");
                Console.WriteLine($"You lose!!!!!");
            }

            else if (total == 7 || total == 11)
            {
                Console.WriteLine($"You scored a total of {total}.");
                Console.WriteLine($"You win!!!!!.");
            }

            else
            {
                Console.WriteLine("Continue....");
                score = total;
                Console.WriteLine($"Your current score is {score}.");
            }

            while (score == 7)
            {
                Console.WriteLine($"You Lose!!!!!.");
            }
        
        }
    }
}