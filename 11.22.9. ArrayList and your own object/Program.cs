using System;
using System.Collections;

//11.22.9.	ArrayList and your own object: Use the BinarySearch() method to search myArrayList for an object

class Employee : IComparable
{
    public string Name;
    public int Number;

    public Employee(string Name, int Number)
    {
        this.Name = Name;
        this.Number = Number;
    }

    public override string ToString()
    {
        return "Name is " + Name + ", Number is " + Number;
    }

    public int Compare(object lhs, object rhs)
    {
        Employee lhsEmployee = (Employee)lhs;
        Employee rhsEmployee = (Employee)rhs;
        if (lhsEmployee.Number < rhsEmployee.Number)
        {
            return -1;
        }
        else if (lhsEmployee.Number > rhsEmployee.Number)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }

    public int CompareTo(object rhs)
    {
        return Compare(this, rhs);
    }
}

class MainClass
{
    public static void DisplayArrayList(string arrayListName, ArrayList myArrayList)
    {
        for (int i = 0; i < myArrayList.Count; i++)
        {
            Console.WriteLine(arrayListName + "[" + i + "] = " + myArrayList[i]);
        }
    }

    public static void Main()
    {
        ArrayList myArrayList = new ArrayList();

        // add four Employee objects to myArrayList using the Add() method
        Console.WriteLine("Adding four Employee objects to myArrayList");
        Employee myM = new Employee("M", 2001);
        Employee myB = new Employee("B", 2001);
        Employee myC = new Employee("C", 1999);
        Employee myT = new Employee("T", 1979);
        myArrayList.Add(myM);
        myArrayList.Add(myB);
        myArrayList.Add(myC);
        myArrayList.Add(myT);
        DisplayArrayList("myArrayList", myArrayList);

        Console.WriteLine();
        myArrayList.Sort();
        DisplayArrayList("myArrayList", myArrayList);

        Console.WriteLine();
        int index2 = myArrayList.BinarySearch(myC);
        Console.WriteLine("Found myC at index " + index2);

    }
}
//Adding four Employee objects to myArrayList
//myArrayList[0] = Name is M, Number is 2001
//myArrayList[1] = Name is B, Number is 2001
//myArrayList[2] = Name is C, Number is 1999
//myArrayList[3] = Name is T, Number is 1979

//myArrayList[0] = Name is T, Number is 1979
//myArrayList[1] = Name is C, Number is 1999
//myArrayList[2] = Name is M, Number is 2001
//myArrayList[3] = Name is B, Number is 2001
//Found myC at index 1