using System;


//11.16.1.	Reverse an array using Array.Reverse

class MainClass
{
    public static void Main()
    {
        int[] nums = { 1, 2, 3, 4, 5 };

        Console.Write("Original order: ");
        foreach (int i in nums)
            Console.Write(i + " ");
        Console.WriteLine();

        Array.Reverse(nums);

        Console.Write("Reversed order: ");
        foreach (int i in nums)
            Console.Write(i + " ");
        Console.WriteLine();

    }
}
//Original order: 1 2 3 4 5
//Reversed order: 5 4 3 2 1