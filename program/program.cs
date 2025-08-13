using System;

// Define the Employee class
class Employee
{
    // Property to store the employee's unique identifier
    public int Id { get; set; }

    // Property to store the employee's first name
    public string FirstName { get; set; }

    // Property to store the employee's last name
    public string LastName { get; set; }

    // Overload the "==" operator to compare two Employee objects by their Id
    public static bool operator ==(Employee emp1, Employee emp2)
    {
        // Check for nulls to avoid NullReferenceException
        if (ReferenceEquals(emp1, null) && ReferenceEquals(emp2, null))
            return true;
        if (ReferenceEquals(emp1, null) || ReferenceEquals(emp2, null))
            return false;

        // Compare the Id properties of both Employee objects
        return emp1.Id == emp2.Id;
    }

    // Overload the "!=" operator to complement the "==" operator
    public static bool operator !=(Employee emp1, Employee emp2)
    {
        // Use the result of the "==" operator and negate it
        return !(emp1 == emp2);
    }

    // Override Equals to match the behavior of the "==" operator
    public override bool Equals(object obj)
    {
        // Cast the object to Employee and compare Ids
        return obj is Employee employee && this.Id == employee.Id;
    }

    // Override GetHashCode to ensure consistency with Equals
    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create the first Employee object and assign values
        Employee emp1 = new Employee() { Id = 101, FirstName = "Edwin", LastName = "Smith" };

        // Create the second Employee object and assign values
        Employee emp2 = new Employee() { Id = 101, FirstName = "Jane", LastName = "Doe" };

        // Compare the two Employee objects using the overloaded "==" operator
        if (emp1 == emp2)
        {
            // Display message if the Ids are equal
            Console.WriteLine("The two employees are considered equal (same Id).");
        }
        else
        {
            // Display message if the Ids are not equal
            Console.WriteLine("The two employees are not equal (different Ids).");
        }

        // Wait for user input before closing the console window
        Console.ReadLine();
    }
}
