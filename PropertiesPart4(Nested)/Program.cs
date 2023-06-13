using System;

// check out InterfacePart1B

public class Address
{
    public string Street { get; set; }
    public string City { get; set; }
    public string Country { get; set; }
}

public class Person
{
    public string Name { get; set; }
    public Address HomeAddress { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        var person = new Person {Name = "John Doe", HomeAddress = new Address { Street = "123 Main St", City = "New York", Country = "USA"}};

        Console.WriteLine($"Name: {person.Name}");
        Console.WriteLine($"Home Address: {person.HomeAddress.Street}, {person.HomeAddress.City}, {person.HomeAddress.Country}");
    }
}
