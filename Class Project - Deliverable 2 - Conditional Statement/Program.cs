using System;

namespace Class_Project___Deliverable_2___Conditional_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("What grade would you like to receive in ISM4300?");
                int grade = int.Parse(Console.ReadLine());

                if (grade >= 98 && grade <= 100)
                {
                    Console.WriteLine("You will get an A+");
                }
                if (grade >= 92 && grade <= 97)
                {
                    Console.WriteLine("You will get an A");
                }
                if (grade >= 90 && grade <= 91)
                {
                    Console.WriteLine("You will get an A-");
                }
                if (grade >= 88 && grade <= 89)
                {
                    Console.WriteLine("You will get an B+");
                }
                if (grade >=  82 && grade <= 87)
                {
                    Console.WriteLine("You will get an B");
                }
                if (grade >= 80 && grade <= 81)
                {
                    Console.WriteLine("You will get an B-");
                }
                if (grade >= 78 && grade <= 79)
                {
                    Console.WriteLine("You will get an C+");
                }
                if (grade >= 72 && grade <= 77)
                {
                    Console.WriteLine("You will get an C");
                }
                if (grade >= 70 && grade <= 71)
                {
                    Console.WriteLine("You will get an C-");
                }
                if (grade >= 68 && grade <= 69)
                {
                    Console.WriteLine("You will get an D+");
                }
                if (grade >= 62 && grade <= 67)
                {
                    Console.WriteLine("You will get an D");
                }
                if (grade >= 60 && grade <= 61)
                {
                    Console.WriteLine("You will get an D-");
                }
                if ( grade <= 59)
                {
                    Console.WriteLine("You will FAIL! *Evil Laughter*");
                }
            }
             catch
            {
                Console.WriteLine("Please enter a number between 0 and 100");
            }
        }
    }
}
