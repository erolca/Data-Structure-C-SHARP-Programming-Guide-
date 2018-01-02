using System;

//11.17.1.	Use the BinarySearch() method to search intArray for the number 5

class MainClass
{

    public static void Main()
    {
        int[] intArray = { 5, 2, 3, 1, 6, 9, 7, 14, 25 };
        Array.Sort(intArray);

        int index = Array.BinarySearch(intArray, 5);
        Console.WriteLine("Array.BinarySearch(intArray, 5) = " + index);
    }

}
//Array.BinarySearch(intArray, 5) = 3