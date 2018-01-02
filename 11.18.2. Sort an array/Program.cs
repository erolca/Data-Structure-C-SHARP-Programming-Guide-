using System;

//11.18.2.	Sort an array and search for a value

class MainClass
{
    public static void Main()
    {
        int[] nums = { 5, 4, 6, 3, 14, 9, 8, 17, 1, 24, -1, 0 };

        Array.Sort(nums);

        // Search for 14. 
        int idx = Array.BinarySearch(nums, 14);

        Console.WriteLine("Index of 14 is " + idx);
    }
}
//Index of 14 is 9