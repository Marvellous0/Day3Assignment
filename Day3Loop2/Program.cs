using System;

namespace Day3Loop2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Loan amount: ");
            double loanAmount = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Number of Years: ");
            int numberOfYears = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Annual Interest Rate: ");
            double annualInterestRate = Convert.ToDouble(Console.ReadLine());

            double monthlyInterestRate = annualInterestRate / 1200;

            double monthlyPayment = loanAmount * monthlyInterestRate / (1 - (Math.Pow(1 / (1 + monthlyInterestRate), numberOfYears * 12)));

            double balance = loanAmount;

            double interest;

            double principal;

            Console.WriteLine("Monthly Payment: " + (int)(monthlyPayment * 100) / 100.0 );

            Console.WriteLine("Total Payment: " + (int)(monthlyPayment * 12 * numberOfYears * 100) / 100.0 + "\n" );

            Console.WriteLine("#Payment\tInterest\tPrincipal\tBalance");
            for (int i = 1; i <= numberOfYears * 12; i++) 
            {
                interest = (int)(monthlyInterestRate * balance * 100) / 100.0;

                principal = (int)((monthlyPayment - interest) * 100) / 100.0;

                balance = (int)((balance - principal) * 100) / 100.0;

                Console.WriteLine(i + "\t\t\t" + interest + "\t\t" + principal + "\t\t" + balance);
            }
        }
    }
}
