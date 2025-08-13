using System;

namespace MathOperationApp
{
    // Step 1: Create a class that contains our method
    public class MathProcessor
    { 
        // Void method that takes two integers as parameters
        // Performs a math operation on the first integer and displays the second integer
        public void ProcessNumbers(int firstNumber, int secondNumber)
        {
            // Perform a math operation on the first integer (squaring it in this example)
            int mathResult = firstNumber * firstNumber;
            
            // Display the result of the math operation on the first number
            Console.WriteLine($"Math operation result (first number squared): {mathResult}");
            
            // Display the second integer to the screen as required
            Console.WriteLine($"Second number displayed: {secondNumber}");
            
            // Add a blank line for better readability between method calls
            Console.WriteLine();
        }
    }

    // Main program class containing the entry point
    class Program
    {
        // Main method - entry point of the console application
        static void Main(string[] args)
        {
            // Step 2: Instantiate the MathProcessor class
            MathProcessor processor = new MathProcessor();
            
            // Display welcome message to explain what the program does
            Console.WriteLine("=== Math Operation Console App ===");
            Console.WriteLine("This app demonstrates method calls with parameters.\n");
            
            // Step 3: Call the method passing in two numbers (positional parameters)
            Console.WriteLine("Step 3: Calling method with positional parameters (5, 10):");
            processor.ProcessNumbers(5, 10);
            
            // Step 4: Call the method specifying parameters by name (named parameters)
            Console.WriteLine("Step 4: Calling method with named parameters:");
            processor.ProcessNumbers(firstNumber: 7, secondNumber: 25);
            
            // Alternative way to call with named parameters (different order)
            Console.WriteLine("Bonus: Calling method with named parameters in different order:");
            processor.ProcessNumbers(secondNumber: 100, firstNumber: 3);
            
            // Keep console window open until user presses a key
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}