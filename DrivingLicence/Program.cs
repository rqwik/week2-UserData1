using System;

namespace DrivingLicence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter u birth year!");
            int YearOfBirth = Convert.ToInt32(Console.ReadLine());
            int UserAge = 2022 - YearOfBirth; //тут пишем решение - что от чего отнимаем для проверки

            if (UserAge < 18)
            {
                Console.WriteLine("Sorry, but u too young to drive(");
            }
            else if (UserAge > 18)
            {
                Console.WriteLine("Be and drive carefully!");
            }
            else
            {
                Console.WriteLine("Congrulations, u may apply for your driving licence now! Yuuuhhuu))");
            }
            Console.WriteLine("Have a nice day!");



        }
    }
}
