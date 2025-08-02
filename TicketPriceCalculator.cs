using System;

namespace dcit_assignment1_11262526
{
    public class TicketPriceCalculator
    {
        public static void Run()
        {
            Console.WriteLine("=== Ticket Price Calculator ===");

            Console.Write("Enter your age: ");
            string input = Console.ReadLine();

            bool isValid = int.TryParse(input, out int age);

            if (!isValid || age < 0)
            {
                Console.WriteLine("Invalid input. Please enter a valid age.");
            }
            else
            {
                int price = (age <= 12 || age >= 65) ? 7 : 10;
                Console.WriteLine($"Your ticket price is: GHC{price}");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
