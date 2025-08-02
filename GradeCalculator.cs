using System;

namespace dcit_assignment1_11262526
{
    public class GradeCalculator
    {
        public static void Run()
        {
            Console.WriteLine("=== Grade Calculator ===");

            while (true)
            {
                Console.Write("\nEnter a grade (0 - 100) or type 'exit' to quit: ");
                string input = Console.ReadLine();

                if (input.Trim().ToLower() == "exit")
                {
                    Console.WriteLine("Exiting Grade Calculator...");
                    break;
                }

                bool isValid = int.TryParse(input, out int grade);

                if (!isValid || grade < 0 || grade > 100)
                {
                    Console.WriteLine("Invalid input. Please enter a number between 0 and 100.");
                    continue;
                }

                if (grade >= 90)
                    Console.WriteLine("Grade: A");
                else if (grade >= 80)
                    Console.WriteLine("Grade: B");
                else if (grade >= 70)
                    Console.WriteLine("Grade: C");
                else if (grade >= 60)
                    Console.WriteLine("Grade: D");
                else
                    Console.WriteLine("Grade: F");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
