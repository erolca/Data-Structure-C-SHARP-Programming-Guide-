using System;
using System.Collections;


//11.42.3.	Class with IComparable and IComparer

public class MainClass
{
    public static int Main(string[] args)
    {
        Employee[] empList = new Employee[5];

        empList[0] = new Employee(123, "R");
        empList[1] = new Employee(6, "M");
        empList[2] = new Employee(6, "V");
        empList[3] = new Employee(13, "N");
        empList[4] = new Employee(6, "C");

        if (empList[0] < empList[4])
            Console.WriteLine("empList[0] < empList[4]");
        else
            Console.WriteLine("empList[0] >= empList[4]");

        return 0;
    }
}
public class Employee : IComparable
{
    private class SortByEmployeemNameHelper : IComparer
    {
        public SortByEmployeemNameHelper() { }
        int IComparer.Compare(object o1, object o2)
        {
            Employee t1 = (Employee)o1;
            Employee t2 = (Employee)o2;
            return String.Compare(t1.EmployeemName, t2.EmployeemName);
        }
    }

    private int EmployeeID;
    private string petName;

    // properties.
    public int ID
    {
        get { return EmployeeID; }
        set { EmployeeID = value; }
    }
    public string EmployeemName
    {
        get { return petName; }
        set { petName = value; }
    }

    // Constructor set.
    public Employee() { }
    public Employee(int id, string name)
    {
        this.EmployeeID = id;
        this.petName = name;
    }

    // IComparable implementation.
    int IComparable.CompareTo(object o)
    {
        Employee temp = (Employee)o;
        if (this.EmployeeID > temp.EmployeeID)
            return 1;
        if (this.EmployeeID < temp.EmployeeID)
            return -1;
        else
            return 0;
    }

    // Property to return the SortByEmployeemName comparer.
    public static IComparer SortByEmployeemName
    {
        get { return (IComparer)new SortByEmployeemNameHelper(); }
    }

    public static bool operator <(Employee c1, Employee c2)
    {
        IComparable itfComp = (IComparable)c1;
        return (itfComp.CompareTo(c2) < 0);
    }

    public static bool operator >(Employee c1, Employee c2)
    {
        IComparable itfComp = (IComparable)c1;
        return (itfComp.CompareTo(c2) > 0);
    }

    public static bool operator <=(Employee c1, Employee c2)
    {
        IComparable itfComp = (IComparable)c1;
        return (itfComp.CompareTo(c2) <= 0);
    }

    public static bool operator >=(Employee c1, Employee c2)
    {
        IComparable itfComp = (IComparable)c1;
        return (itfComp.CompareTo(c2) >= 0);
    }
}
//empList[0] >= empList[4]