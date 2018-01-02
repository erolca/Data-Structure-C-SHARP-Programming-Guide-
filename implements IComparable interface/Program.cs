using System;
using System.Collections.Generic;

//IComparable allows custom sorting of objects when implemented.
//When a class implements this interface, we must add the public method CompareTo(T).
//We implement custom sorting for a class with IComparable.
//https://www.dotnetperls.com/icomparable


class Employee : IComparable<Employee>
{
    public int Salary { get; set; }
    public string Name { get; set; }
 
    public int CompareTo(Employee other)
    {
      
        
        // Alphabetic sort if salary is equal. [A to Z]
        if (this.Salary == other.Salary)
        {
            return this.Name.CompareTo(other.Name);
        }
        // Default to salary sort. [High to low]
        return other.Salary.CompareTo(this.Salary);
    }

    public override string ToString()
    {
        // String representation.
        return this.Salary.ToString() + "," + this.Name;
    }
}

class Program
{
    static void Main()
    {
        List<Employee> list = new List<Employee>();
        list.Add(new Employee() { Name = "Steve",   Salary = 10000 });
        list.Add(new Employee() { Name = "Janet",   Salary = 10000 });
        list.Add(new Employee() { Name = "Andrew",  Salary = 10000 });
        list.Add(new Employee() { Name = "Bill",    Salary = 500000 });
        list.Add(new Employee() { Name = "Ahenk",   Salary = 500000 });
        list.Add(new Employee() { Name = "Lucy",    Salary = 8000 });

        // Uses IComparable.CompareTo()
        list.Sort();

        // Uses Employee.ToString
        foreach (var element in list)
        {
            Console.WriteLine(element);
        }
    }
}

//Output

//500000,Bill
//10000,Andrew
//10000,Janet
//10000,Steve
//8000,Lucy