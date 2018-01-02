using System;

class MainClass
{
    public static void Main()
    {
        int[] nums = { 5, 4, 6, 3, 14, 9, 8, 17, 1, 24, -1, 0 };

        Console.Write("Original order: ");
        foreach (int i in nums)
            Console.Write(i + " ");
        Console.WriteLine();

        Array.Sort(nums);

        Console.Write("Sorted order:   ");
        foreach (int i in nums)
            Console.Write(i + " ");
        Console.WriteLine();


    }
}
//Original order: 5 4 6 3 14 9 8 17 1 24 -1 0
//Sorted order:   -1 0 1 3 4 5 6 8 9 14 17 24