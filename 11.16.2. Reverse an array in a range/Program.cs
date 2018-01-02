using System;

class MainClass
{
    public static void Main()
    {
        int[] nums = { 1, 2, 3, 4, 5 };

        Console.Write("Original order: ");
        foreach (int i in nums)
            Console.Write(i + " ");
        Console.WriteLine();

        // Reverse a range. 
        Array.Reverse(nums, 1, 3);

        // Display reversed order. 
        Console.Write("Range reversed: ");
        foreach (int i in nums)
            Console.Write(i + " ");
        Console.WriteLine();

    }
}
//Original order: 1 2 3 4 5
//Range reversed: 1 4 3 2 5