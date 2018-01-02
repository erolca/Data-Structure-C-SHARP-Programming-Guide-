using System;

class MainClass
{
    public static void Main()
    {
        int[][] jagged = new int[3][];
        jagged[0] = new int[4];
        jagged[1] = new int[3];
        jagged[2] = new int[5];

        int i;

        Console.WriteLine("store values in first array");
        for (i = 0; i < 4; i++)
            jagged[0][i] = i;

        Console.WriteLine("store values in second array");
        for (i = 0; i < 3; i++)
            jagged[1][i] = i;

        Console.WriteLine("store values in third array");
        for (i = 0; i < 5; i++)
            jagged[2][i] = i;


        Console.WriteLine("display values in first array");
        for (i = 0; i < 4; i++)
            Console.Write(jagged[0][i] + " ");

        Console.WriteLine();

        Console.WriteLine("display values in second array");
        for (i = 0; i < 3; i++)
            Console.Write(jagged[1][i] + " ");

        Console.WriteLine();

        Console.WriteLine("display values in third array");
        for (i = 0; i < 5; i++)
            Console.Write(jagged[2][i] + " ");

        Console.WriteLine();
    }
}
//store values in first array
//store values in second array
//store values in third array
//display values in first array
//0 1 2 3
//display values in second array
//0 1 2
//display values in third array
//0 1 2 3 4