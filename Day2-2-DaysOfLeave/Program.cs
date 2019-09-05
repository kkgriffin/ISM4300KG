using System;

namespace Day2_2_DaysOfLeave
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Console.WriteLine("How many days of leave would you like to take off work?");
                int days = int.Parse(Console.ReadLine());

                if (days > 1 && days < 7)
                {
                    Console.WriteLine("You are granted these days off");
                }

                if (days == 0)
                {
                    Console.WriteLine("Please enter a number greater than 0");
                }

                else Console.Write("You are not granted these days off");

            }

            catch
            {
                Console.WriteLine("Please adjust days input");
            }
            
        }
    }
}
