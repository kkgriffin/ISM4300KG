using System;

namespace Group_Activity
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How old are you?");
            int age = int.Parse(Console.ReadLine());
            if (age == 25)
            {
                Console.WriteLine("How many iterations do you want to run Kyle?");
                int number = int.Parse(Console.ReadLine());

                int i = 0, limit = 4;
                do
                {
                    
                    Console.WriteLine("You entered" + " " + number + ". This is the current integer in the loop:" + i);
                    i++;
                }
                while (i < limit);

            }
        }
    }
}
