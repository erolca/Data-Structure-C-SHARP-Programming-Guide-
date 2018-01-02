using System;
using System.Collections.Generic;


//11.18.5.	Implementing IComparable and sort by Array.Sort

public class Employee : IComparable
{
    public Employee(string name, int id)
    {
        this.name = name;
        this.id = id;
    }

    int IComparable.CompareTo(object obj)
    {
        Employee emp2 = (Employee)obj;
        if (this.id > emp2.id)
            return (1);
        if (this.id < emp2.id)
            return (-1);
        else
            return (0);
    }

    public override string ToString()
    {
        return (String.Format("{0}:{1}", name, id));
    }

    string name;
    int id;
}

class MainClass
{
    public static void Main()
    {
        Employee[] arr = new Employee[4];
                arr[0] = new Employee("A", 1);
                arr[1] = new Employee("B", 2);
                arr[2] = new Employee("C", 4);
                arr[3] = new Employee("D", 3);
    

        Array.Sort(arr);
        foreach (Employee emp in arr)
            Console.WriteLine("Employee: {0}", emp);

        Console.WriteLine("Find employee id 2 in the list");

        Employee employeeToFind = new Employee(null, 2);
        int index = Array.BinarySearch(arr, employeeToFind);
        if (index != -1)
            Console.WriteLine("Found: {0}", arr[index]);
    }
}
//Employee: A:1
//Employee: B:2
//Employee: D:3
//Employee: C:4
//Find employee id 2 in the list
//Found: B:2