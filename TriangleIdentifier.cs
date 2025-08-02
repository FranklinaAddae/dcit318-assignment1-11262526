using System;

namespace dcit318_assignment1_11262526
{
    public class TriangleIdentifier
    {
        public static void Run()
        {
            Console.WriteLine("=== Triangle Type Identifier ===");

            Console.Write("Enter side 1: ");
            string? s1 = Console.ReadLine();

            Console.Write("Enter side 2: ");
            string? s2 = Console.ReadLine();

            Console.Write("Enter side 3: ");
            string? s3 = Console.ReadLine();

            if (double.TryParse(s1, out double a) &&
                double.TryParse(s2, out double b) &&
                double.TryParse(s3, out double c))
            {
                if (a <= 0 || b <= 0 || c <= 0)
                {
                    Console.WriteLine("Side lengths must be greater than 0.");
                    return;
                }

                if (a + b > c && a + c > b && b + c > a)
                {
                    if (a == b && b == c)
                        Console.WriteLine("This is an Equilateral triangle.");
                    else if (a == b || a == c || b == c)
                        Console.WriteLine("This is an Isosceles triangle.");
                    else
                        Console.WriteLine("This is a Scalene triangle.");
                }
                else
                {
                    Console.WriteLine("These sides do not form a valid triangle.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter numbers only.");
            }
        }
    }
}
