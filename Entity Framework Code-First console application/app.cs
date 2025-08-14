using System.Data.Entity;
public class Student
{
    public int StudentId { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}



public class SchoolContext : DbContext
{
    public DbSet<Student> Students { get; set; }
}


class Program
{
    static void Main(string[] args)
    {
        using (var context = new SchoolContext())
        {
            var student = new Student { Name = "Edwin", Age = 22 };
            context.Students.Add(student);
            context.SaveChanges();

            Console.WriteLine("Student added successfully!");
        }
    }
}
