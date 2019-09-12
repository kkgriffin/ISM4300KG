using System;

namespace Class_Project___Deliverable_2___Iterative_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {


                Console.WriteLine("Enter an integer value between 1 and 100");
                int number = int.Parse(Console.ReadLine());

                if (number >= 1 && number <= 100)
                {
                    int i = 0, limit = number;
                    do
                    {
                        Console.WriteLine("You entered" + " " + number + ". This is the current integer value in the loop:" + i);
                        i++;
                    }
                    while (i < limit);
                }
                else
                {
                    Console.WriteLine("Please enter a integer value between 1 and 100");
                }
            }

            catch
            {
                Console.WriteLine("Please try again; Enter an integer value between 1 and 100");
            }
        }
    }
}
