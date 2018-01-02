using System;

class MainClass
{

    public static void Main()
    {
        char[] charArray = { 'w', 'e', 'l', 'c', 'o', 'm', 'e' };
        Array.Sort(charArray);  // sort the elements        
        int index = Array.BinarySearch(charArray, 'o');
        Console.WriteLine("Array.BinarySearch(charArray, 'o') = " + index);

    }

}
//Array.BinarySearch(charArray, 'o') = 5