using System;

public class Employee
{
    public string name;
    public int no;

    public Employee(string name, int no)
    {
        this.name = name;
        this.no = no;
    }
}


class MainClass
{
    public static void Main()
    {
        Employee[,,] empArray = new Employee[10, 5, 3];

        empArray[1, 3, 2] = new Employee("S", 3);
        empArray[4, 1, 2] = new Employee("A", 9);

        Console.WriteLine("empArray.Rank (number of dimensions) = " + empArray.Rank);
        Console.WriteLine("empArray.Length (number of elements) = " + empArray.Length);

        for (int x = 0; x < empArray.GetLength(0); x++)
        {
            for (int y = 0; y < empArray.GetLength(1); y++)
            {
                for (int z = 0; z < empArray.GetLength(2); z++)
                {
                    if (empArray[x, y, z] != null)
                    {
                        Console.WriteLine("empArray[" + x + ", " + y + ", " + z + "].name = " + empArray[x, y, z].name);
                        Console.WriteLine("empArray[" + x + ", " + y + ", " + z + "].no = " + empArray[x, y, z].no);
                    }
                }
            }
        }

    }

}

//empArray.Rank(number of dimensions) = 3
//empArray.Length(number of elements) = 150
//empArray[1, 3, 2].name = S
//empArray[1, 3, 2].no = 3
//empArray[4, 1, 2].name = A
//empArray[4, 1, 2].no = 9