using System;

namespace Group_Activity
{
    class Program
    {
        static void Main(string[] args)
        {        
                Console.WriteLine("How many iterations do you want to run Kyle?");
                int number = int.Parse(Console.ReadLine());

                int i = 0, limit = 4;
                do
                {
                    
                    Console.WriteLine("You entered" + " " + number + ". This is the current integer value in the loop:" + i);
                    i++;
                }
                while (i < limit);

            }
        }
    }
}
