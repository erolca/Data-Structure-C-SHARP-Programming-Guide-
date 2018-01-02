using System;

class MainClass
{
    public static void Main()
    {
        int[] nums = new int[10];

        Console.WriteLine("Length of nums is " + nums.Length);

        Console.Write("use Length to initialize nums");
        for (int i = 0; i < nums.Length; i++)
            nums[i] = i * i;

        Console.Write("now use Length to display nums");
        Console.Write("Here is nums: ");
        for (int i = 0; i < nums.Length; i++)
            Console.Write(nums[i] + " ");
    }
}

//Length of nums is 10
//use Length to initialize numsnow use Length to display numsHere is nums: 0 1 4 9 16 25 36 49 64 81 "








