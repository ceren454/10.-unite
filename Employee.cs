using System;

class Employee
{

    public static int Count { get; private set; }

    public string FirstName { get; }
    public string LastName { get; }

    public Employee(string firstName, string lastName)
    {
        (FirstName, LastName) = (firstName, lastName); 
        Count++;

        Console.WriteLine($"Employee created: {FirstName} {LastName}; Count = {Count}");
    }
}
