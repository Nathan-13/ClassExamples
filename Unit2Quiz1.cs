using System;

namespace ClassExamples
{
    public class Unit2Quiz1
    {
        public static void Run()
        {
            Console.WriteLine("Please enter your age: ");
            string userInput = Console.ReadLine();

            int age = Convert.ToInt32(userInput);
            decimal ticketPrice = 0m;

            if (age < 5) {
                ticketPrice = 0m;
            } else if ((age >= 5) && (age < 14)) {
                ticketPrice = 7.99m;
            } else if ((age >= 14) && (age < 65)) {
                ticketPrice = 11.99m;
            } else if (age >= 65) {
                ticketPrice = 9.99m;
            }

            Console.WriteLine("The movie ticket price is: " + ticketPrice);
        }
    }
}