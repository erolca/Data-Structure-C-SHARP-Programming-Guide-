using System;

//	11.17.3.	Use the BinarySearch() method to search stringArray for 'abc345'

class MainClass
{

    public static void Main()
    {
        string[] stringArray = { "t", "i", "a", "test", "abc123", "abc345" };
        Array.Sort(stringArray);

        int index = Array.BinarySearch(stringArray, "abc345");
        Console.WriteLine("Array.BinarySearch(stringArray, \"abc345\") = " + index);

    }

}
//Array.BinarySearch(stringArray, "abc345") = 2