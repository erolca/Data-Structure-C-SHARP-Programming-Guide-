using System;
using System.Collections.Generic;


//11.34.14.	Implement IComparable to use List.Sort

    
public class Employee : IComparable<Employee>
{
    private int empID;

    public Employee(int empID)
    {
        this.empID = empID;
    }

    public override string ToString()
    {
        return empID.ToString();
    }

    public bool Equals(Employee other)
    {
        if (this.empID == other.empID)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public int CompareTo(Employee rhs)
    {
        return this.empID.CompareTo(rhs.empID);
    }
}
public class Tester
{
    static void Main()
    {
        List<Employee> empArray = new List<Employee>();
        List<Int32> intArray = new List<Int32>();

        for (int i = 0; i < 5; i++)
        {
            empArray.Add(new Employee(i));
            intArray.Add(i);
        }
        intArray.Sort();
        for (int i = 0; i < intArray.Count; i++)
        {
            Console.Write("{0} ", intArray[i].ToString());
        }
        empArray.Sort();
        for (int i = 0; i < empArray.Count; i++)
        {
            Console.Write("{0} ", empArray[i].ToString());
        }
    }
}