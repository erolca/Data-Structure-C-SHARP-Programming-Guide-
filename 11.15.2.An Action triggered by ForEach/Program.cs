using System;

class MyClass
{
    public int i;

    public MyClass(int x)
    {
        i = x;
    }
}

class MainClass
{

    static void show(MyClass o)
    {
        Console.Write(o.i + " ");
    }

    public static void Main()
    {
        MyClass[] nums = new MyClass[5];

        nums[0] = new MyClass(5);
        nums[1] = new MyClass(2);
        nums[2] = new MyClass(3);
        nums[3] = new MyClass(4);
        nums[4] = new MyClass(1);

        Console.Write("Contents of nums: ");

        // Use action to show the values. 
        Array.ForEach(nums, MainClass.show);
   

        Console.WriteLine();

        Foreachfunc();

    }


    public static void Foreachfunc()
    {
        // Allocate a jagged array and put 3 subarrays into it.
        int[][] array = new int[3][];
        array[0] = new int[2];
        array[1] = new int[3];
        array[2] = new int[4];
        // Use ForEach to modify each subarray's first element.
        // ... Because the closure variable is an array reference,
        //     you can change it.
        Array.ForEach(array, subarray => subarray[0]++);

        foreach (int[] subarray in array)
        {
            foreach (int i in subarray)
            {
                Console.Write(i);
            }
            Console.WriteLine();
        }
        // Apply the same routine with ForEach again.
        Array.ForEach(array, subarray => subarray[0]++);
        foreach (int[] subarray in array)
        {
            foreach (int i in subarray)
            {
                Console.Write(i);
            }
            Console.WriteLine();
        }

        //Output

        //    10
        //    100
        //    1000
        //    20
        //    200
        //    2000


    }




}
//Contents of nums: 5 2 3 4 1