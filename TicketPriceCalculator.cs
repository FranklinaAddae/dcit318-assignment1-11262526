using System;

namespace dcit318_assignment1_11262526
{
    public class TicketPriceCalculator
    {
        public static void Run()
        {
            Console.WriteLine("=== Ticket Price Calculator ===");
            Console.Write("Enter your age: ");
            string? input = Console.ReadLine();

            if (int.TryParse(input, out int age))
            {
                if (age < 0)
                {
                    Console.WriteLine("Age cannot be negative.");
                    return;
                }

                int price = (age <= 12 || age >= 65) ? 7 : 10;
                Console.WriteLine($"Your ticket price is: GHC{price}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid age.");
            }
        }
    }
}
