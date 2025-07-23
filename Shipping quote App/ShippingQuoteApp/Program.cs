
using System;

class Program
{
    static void Main()
    {
        // Initial greeting message
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Ask for package weight
        Console.Write("Please enter the package weight: ");
        int weight = Convert.ToInt32(Console.ReadLine());

        // Check if weight exceeds limit
        if (weight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return; // Exit the program
        }

        // Ask for package width
        Console.Write("Please enter the package width: ");
        int width = Convert.ToInt32(Console.ReadLine());

        // Ask for package height
        Console.Write("Please enter the package height: ");
        int height = Convert.ToInt32(Console.ReadLine());

        // Ask for package length
        Console.Write("Please enter the package length: ");
        int length = Convert.ToInt32(Console.ReadLine());

        // Check if total dimensions exceed limit
        int dimensionTotal = width + height + length;
        if (dimensionTotal > 50)
        {
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return; // Exit the program
        }

        // Calculate the shipping quote using the specified formula
        int volume = width * height * length;
        decimal quote = (volume * weight) / 100m;

        // Display the final quote as currency
        Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");
        Console.WriteLine("Thank you!");
    }
}

