using System;

class Program
{
    static void Main()
    {
        double a, b, h;

        Console.WriteLine("=== AI-Based Volume Calculator ===");
        Console.WriteLine("Shape: Slanted Elliptical Cylinder");
        Console.WriteLine();

        Console.Write("Enter semi-major axis (a): ");
        a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter semi-minor axis (b): ");
        b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter height (h): ");
        h = Convert.ToDouble(Console.ReadLine());

        // Validation
        if (a <= 0 || b <= 0 || h <= 0)
        {
            Console.WriteLine("Invalid input! Values must be positive.");
            return;
        }

        // Formula
        double volume = Math.PI * a * b * h;

        Console.WriteLine();
        Console.WriteLine("Formula: V = π × a × b × h");
        Console.WriteLine("Volume = " + volume.ToString("F2") + " cubic units");

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}