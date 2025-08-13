using System;

// Define an interface called IQuittable
interface IQuittable
{
    // Declare a method signature for Quit with no return value
    void Quit();
}

// Define an Employee class that implements the IQuittable interface
class Employee : IQuittable
{
    // Properties to hold employee's first and last name
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Implement the Quit method from the IQuittable interface
    public void Quit()
    {
        // Display a message indicating the employee has quit
        Console.WriteLine($"{FirstName} {LastName} has quit the job.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of Employee and assign values to properties
        Employee emp = new Employee() { FirstName = "Edwin", LastName = "Smith" };

        // Use polymorphism: assign the Employee object to an IQuittable interface reference
        IQuittable quittable = emp;

        // Call the Quit method using the interface reference
        quittable.Quit();

        // Wait for user input before closing the console window
        Console.ReadLine();
    }
}
