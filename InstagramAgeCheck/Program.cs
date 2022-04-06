using System;

namespace InstagramAgeCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hey! How old are u?");
            int userAge = Convert.ToInt32(Console.ReadLine()); //int - ячейка для цифр - всегда в связке используем convert.toint32

            if (userAge < 13)
            {
                Console.WriteLine("U are too young for Instagram.");
            }
            else if (userAge > 13)
            {
                Console.WriteLine("Welcome to Instagram!");
            }
            else
            {
                Console.WriteLine("Congratulations! U may use Instagram now.");
            }

            Console.WriteLine("Have a nice day!");
        }
    }
}
