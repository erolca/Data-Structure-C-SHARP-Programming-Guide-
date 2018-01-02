using System;

//The general form for initializing a one-dimensional array is shown here:

//type[] array-name = { val1, val2, val3, ..., valN };

class MainClass
{
    public static void Main()
    {
        int[] nums = { 99, 10, 100, 18, 78, 23,
                   63, 9, 87, 49 };
        int avg = 0;

        for (int i = 0; i < 10; i++)
            avg = avg + nums[i];

        avg = avg / 10;

        Console.WriteLine("Average: " + avg);
    }
}
//Average: 53