using System;

namespace Inclassday2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Have you coughed or sneezed?");
                string inputvalue = Console.ReadLine();

                if (inputvalue == "coughed")
                {
                    Console.WriteLine("How many times have you coughed?");
                    int NumberC = int.Parse(Console.ReadLine());

                    int i = 0, Limit = NumberC;
                    do
                    {
                        Console.WriteLine("excuse you!");
                        i++;
                    }
                    while (i < Limit);

                }
                if (inputvalue == "sneezed")
                {
                    Console.WriteLine("How many times have you sneezed?");
                    int NumberS = int.Parse(Console.ReadLine());

                    int i = 0, Limit = NumberS;
                    do
                    {
                        Console.WriteLine("bless you!");
                        i++;
                    }
                    while (i < Limit);
                }
                

            }
            catch
            {
                Console.WriteLine("You have an error");
            }
        }
    }
}
