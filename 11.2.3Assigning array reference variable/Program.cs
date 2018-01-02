using System;

class MainClass
{
    public static void Main()
    {
        int i;

        int[] nums1 = new int[10];
        int[] nums2 = new int[10];

        for (i = 0; i < 10; i++)
            nums1[i] = i;

        for (i = 0; i < 10; i++)
            nums2[i] = -i;

        Console.Write("Here is nums1: ");
        for (i = 0; i < 10; i++)
            Console.Write(nums1[i] + " ");
        Console.Write("Here is nums2: ");
        for (i = 0; i < 10; i++)
            Console.Write(nums2[i] + " ");
        Console.WriteLine();

        nums2 = nums1; // now nums2 refers to nums1 

        Console.Write("Here is nums2 after assignment: ");
        for (i = 0; i < 10; i++)
            Console.Write(nums2[i] + " ");
        Console.WriteLine();
    }
}
//Here is nums1: 0 1 2 3 4 5 6 7 8 9 Here is nums2: 0 -1 -2 -3 -4 -5 -6 -7 -8 -9
//Here is nums2 after assignment: 0 1 2 3 4 5 6 7 8 9