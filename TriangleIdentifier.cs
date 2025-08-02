using System;

namespace dcit318_assignment1_11262526
{
    public class TriangleIdentifier
    {
        public static void Run()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== Triangle Type Identifier ===");

                try
                {
                    Console.Write("Enter the first side: ");
                    double side1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter the second side: ");
                    double side2 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter the third side: ");
                    double side3 = Convert.ToDouble(Console.ReadLine());

                    if (IsValidTriangle(side1, side2, side3))
                    {
                        string type = GetTriangleType(side1, side2, side3);
                        Console.WriteLine($"\nThis is a {type} triangle.");
                    }
                    else
                    {
                        Console.WriteLine("\nThe values entered cannot form a valid triangle.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter numerical values only.");
                }

                Console.Write("\nDo you want to check another triangle? (y/n): ");
                string again = Console.ReadLine().ToLower();
                if (again != "y") break;
            }
        }

        private static bool IsValidTriangle(double a, double b, double c)
        {
            return a + b > c && a + c > b && b + c > a;
        }

        private static string GetTriangleType(double a, double b, double c)
        {
            if (a == b && b == c)
                return "Equilateral";
            else if (a == b || a == c || b == c)
                return "Isosceles";
            else
                return "Scalene";
        }
    }
}
