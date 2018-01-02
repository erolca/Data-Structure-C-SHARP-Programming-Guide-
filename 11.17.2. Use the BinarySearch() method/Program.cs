using System;

//11.17.2.	Use the BinarySearch() method to search intArray for the number 4: BinarySearch() returns a negative value

class MainClass
{

    public static void Main()
    {
        int[] intArray = { 5, 2, 3, 1, 6, 9, 7, 14, 25 };
        Array.Sort(intArray);

        int index = Array.BinarySearch(intArray, 4);
        Console.WriteLine("Array.BinarySearch(intArray, 4) = " + index);
    }

}
//Array.BinarySearch(intArray, 4) = -4