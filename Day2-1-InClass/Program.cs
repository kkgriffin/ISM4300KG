using System;

namespace Day2_1_InClass
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter your age: ");
                int age = int.Parse(Console.ReadLine());

                if (age > 20)
                {
                    Console.WriteLine("You're old enought to drink");
                }

                else Console.WriteLine("You're not old enough to drink");
             

            }
            catch
            {
                Console.WriteLine("You have an error!");
            }
        }
    }
}
