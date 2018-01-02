using System;

class MainClass
{
    static void Main()
    {
        int[][] arr1 = new int[2][];
        arr1[0] = new int[] { 1, 3 };
        arr1[1] = new int[] { 1, 1, 4 };

        foreach (int[] array in arr1)
        {
            Console.WriteLine("Starting new array");
            foreach (int item in array)
            {
                Console.WriteLine(" Item: {0}", item);
            }
        }
    }
}
//Starting new array
// Item: 1
// Item: 3
//Starting new array
// Item: 1
// Item: 1
// Item: 4