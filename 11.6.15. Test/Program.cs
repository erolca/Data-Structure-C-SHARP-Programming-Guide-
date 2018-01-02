using System;

//11.6.15.	Test Single Dimension Array and Multi Dimension Array

class Class1
{
    [STAThread]
    static void Main(string[] args)
    {
        TestSingleDimensionArray();
        TestMultiDimensionArray();
    }

    static void TestSingleDimensionArray()
    {
        int[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int[] arr2 = new int[10];

        for (int i = 0; i < arr1.Length; i++)
        {
            arr2[i] = arr1[i];
            Console.WriteLine(arr1[i] + "=" + arr2[i].ToString());
        }
    }
    static void TestMultiDimensionArray()
    {
        string[,] arr1 = new string[10, 10];
        int[,] identity = { { 0, 0 }, { 0, 1 }, { 1, 0 }, { 1, 1 } };

        // assign values
        for (int row = 0; row < 10; row++)
        {
            for (int col = 0; col < 10; col++)
            {
                arr1[row, col] = row + "," + col;
            }
        }

        // print values
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.Write(arr1[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}