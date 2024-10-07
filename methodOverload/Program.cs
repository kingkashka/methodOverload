using methodOverload;
using System;

internal class Program
{
    public static void Main(string[] args)
    {
     Employee employee = new Employee();
        employee.firstName = "Sample";
        employee.lastName = "Student";
        employee.ID = 123456789;

        // Call the instance methof on the employee object
        employee.sayName();
        employee.sayID();

  
    }
}