using System;

namespace UserPIN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi! Please enter your PIN code:");
            string Username = Console.ReadLine();
            if (Username == "1234")
            {
                Console.WriteLine("What's your name, my darling?");
                string userFirstName = Console.ReadLine();

                if (userFirstName == "Marina")
                {
                    Console.WriteLine("Hello my Honey Bunny!");
                }else
                {
                    Console.WriteLine("Oops, smth went wrong");
                }
            }
            else
            {Console.WriteLine("Oops, incorrect PIN!");            }

        }
    }
}
