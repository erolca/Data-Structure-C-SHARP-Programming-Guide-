using System;
using System.Collections.Generic;


//	11.43.3.	Provide different IEnumerable implemetation for one class


public class Employee
{
    public string Name;
    public string Title;

    public Employee(string name, string title)
    {
        Name = name;
        Title = title;
    }

    public override string ToString()
    {
        return string.Format("{0} ({1})", Name, Title);
    }
}

public class EmployeeList
{
    private List<Employee> employeeList = new List<Employee>();

    public IEnumerator<Employee> GetEnumerator()
    {
        foreach (Employee tm in employeeList)
        {
            yield return tm;
        }
    }

    public IEnumerable<Employee> Reverse
    {
        get
        {
            for (int c = employeeList.Count - 1; c >= 0; c--)
            {
                yield return employeeList[c];
            }
        }
    }

    public IEnumerable<Employee> FirstTwo
    {
        get
        {
            int count = 0;

            foreach (Employee tm in employeeList)
            {
                if (count >= 2)
                {
                    yield break;
                }
                else
                {
                    count++;
                    yield return tm;
                }
            }
        }
    }

    public void AddEmployee(Employee member)
    {
        employeeList.Add(member);
    }
}

public class MainClass
{
    public static void Main()
    {
        EmployeeList employeeList = new EmployeeList();
        employeeList.AddEmployee(new Employee("A", "AA"));
        employeeList.AddEmployee(new Employee("B", "BB"));
        employeeList.AddEmployee(new Employee("C", "CC"));


        Console.WriteLine("Enumerate using default iterator:");
        foreach (Employee member in employeeList)
        {
            Console.WriteLine("  " + member.ToString());
        }

        Console.WriteLine("Enumerate using the FirstTwo iterator:");
        foreach (Employee member in employeeList.FirstTwo)
        {
            Console.WriteLine("  " + member.ToString());
        }

        Console.WriteLine("Enumerate using the Reverse iterator:");
        foreach (Employee member in employeeList.Reverse)
        {
            Console.WriteLine("  " + member.ToString());
        }
    }
}
//Enumerate using default iterator:
//  A(AA)
//  B(BB)
//  C(CC)
//Enumerate using the FirstTwo iterator:
//  A(AA)
//  B(BB)
//Enumerate using the Reverse iterator:
//  C(CC)
//  B(BB)
//  A(AA)