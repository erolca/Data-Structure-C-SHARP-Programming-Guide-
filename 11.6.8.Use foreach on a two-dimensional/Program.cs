using System;

//11.6.8.	Use foreach on a two-dimensional array.

class MainClass
{
    public static void Main()
    {
        int sum = 0;
        int[,] nums = new int[3, 5];

        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 5; j++)
                nums[i, j] = (i + 1) * (j + 1);

        foreach (int x in nums)
        {
            Console.WriteLine("Value is: " + x);
            sum += x;
        }
        Console.WriteLine("Summation: " + sum);
    }
}
//Value is: 1
//Value is: 2
//Value is: 3
//Value is: 4
//Value is: 5
//Value is: 2
//Value is: 4
//Value is: 6
//Value is: 8
//Value is: 10
//Value is: 3
//Value is: 6
//Value is: 9
//Value is: 12
//Value is: 15
//Summation: 90