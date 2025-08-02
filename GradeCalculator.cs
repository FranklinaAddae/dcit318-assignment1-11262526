using System;

namespace dcit318_assignment1_11262526
{
    public class GradeCalculator
    {
        public static void Run()
        {
            Console.WriteLine("=== Grade Calculator ===");
            Console.Write("Enter a numerical grade (0–100): ");
            string? input = Console.ReadLine();

            if (int.TryParse(input, out int grade))
            {
                if (grade < 0 || grade > 100)
                {
                    Console.WriteLine("Grade must be between 0 and 100.");
                    return;
                }

                string letter = grade switch
                {
                    >= 90 => "A",
                    >= 80 => "B",
                    >= 70 => "C",
                    >= 60 => "D",
                    _ => "F"
                };

                Console.WriteLine($"Letter grade: {letter}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
    }
}
