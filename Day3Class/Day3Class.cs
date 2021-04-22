using System;

namespace Day3Class
{
    public class Employee
    {

        public static double salary;
        public static int numberOfHoursOfWorkPerDay;

        public static void GetInfo()
        {
            Console.WriteLine("Enter amount earned: ");
            double salary = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter number of working hours per day: ");
            int numberOfHoursOfWorkPerDay = Convert.ToInt32(Console.ReadLine());

            AddSal(salary);
            AddWork(numberOfHoursOfWorkPerDay, salary);
        }

        public static void AddSal(double salary)
        {
            if (salary < 500)
            {
                salary += 10;
                double sal1;

                sal1 = salary ;

                Console.WriteLine("Salary: " + sal1);
            }

            else
            {
                Console.WriteLine(salary);
            }
        }

        public static void AddWork(int numberOfHoursOfWorkPerDay, double salary)
        {
            if (numberOfHoursOfWorkPerDay > 6 && salary > 500)
            {
                double sal;

                sal = salary + 5;

                Console.WriteLine("Salary: " + sal);
            }

            else if(numberOfHoursOfWorkPerDay > 6 && salary < 500)
            {
                Console.WriteLine($"Salary earned is: ${salary + 10 + 5}");
            }

            else if(numberOfHoursOfWorkPerDay < 6 && salary < 500)
            {
                Console.WriteLine($"Salary earned is : ${salary + 10}");
            }
            else
            {
                Console.WriteLine("You do not have any extra salary. ");
                Console.WriteLine($"{salary}");
            }

        }
    }
}