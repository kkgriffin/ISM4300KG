using System;

namespace Class_Project___Deliverable_3___Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                
                int[] NumericalArray = new int[25];

               
                for (int i = 0; i < 25; i++)
                {
                   
                    NumericalArray[i] = i;
                    Console.WriteLine("Element value = " + (i + 1));

                }
            }

            catch
            {
                Console.WriteLine("An error occured in the program. Please try to run it again.");
            }
        }
    }
}
