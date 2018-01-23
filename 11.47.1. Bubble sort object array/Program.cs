using System;

delegate bool CompareOp(object lhs, object rhs);

class MainEntryPoint
{
    static void Main()
    {
        Employee[] employees = {
              new Employee("B", 20000),
              new Employee("E", 10000),
              new Employee("D", 25000),
              new Employee("W", (decimal)1000000.38),
              new Employee("F", 23000),
              new Employee("R'", 50000)};
        CompareOp employeeCompareOp = new CompareOp(Employee.RhsIsGreater);
        BubbleSorter.Sort(employees, employeeCompareOp);

        for (int i = 0; i < employees.Length; i++)
            Console.WriteLine(employees[i].ToString());
        Console.ReadLine();
    }
}

class Employee
{
    private string name;
    private decimal salary;

    public Employee(string name, decimal salary)
    {
        this.name = name;
        this.salary = salary;
    }

    public override string ToString()
    {
        return string.Format(name + ", {0:C}", salary);
    }

    public static bool RhsIsGreater(object lhs, object rhs)
    {
        Employee empLhs = (Employee)lhs;
        Employee empRhs = (Employee)rhs;
        return (empRhs.salary > empLhs.salary) ? true : false;
    }
}

class BubbleSorter
{
    static public void Sort(object[] sortArray, CompareOp gtMethod)
    {
        for (int i = 0; i < sortArray.Length; i++)
        {
            for (int j = i + 1; j < sortArray.Length; j++)
            {
                if (gtMethod(sortArray[j], sortArray[i]))
                {
                    object temp = sortArray[i];
                    sortArray[i] = sortArray[j];
                    sortArray[j] = temp;
                }
            }
        }
    }
}