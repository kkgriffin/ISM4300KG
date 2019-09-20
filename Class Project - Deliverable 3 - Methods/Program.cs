using System;

namespace Class_Project___Deliverable_3___Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please input your name");
                string Name = HelloName();

                Console.WriteLine("Hello " + Name + "!");

            }

            catch
            {
                Console.WriteLine("An error was present in the code. Please try again. ");
            }
        }

        private static string HelloName()
        {
            string UserName = Console.ReadLine();

            return UserName;
        }
    
    }
}
