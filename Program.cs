using System;

namespace UserData
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter youe useername:");
            string userName = Console.ReadLine(); // = присвоение значения

            if (userName == "admin") // == сравнить значения
            {
                Console.WriteLine("Welcome!");
            }
            else
            {
                Console.WriteLine("Oops! Invalid username.");
            }
            Console.WriteLine("Have a nice day!");

        }
    }
}
