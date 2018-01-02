using System;

class MainClass
{
    public static void Main()
    {
        int[] sample = new int[10];
        int i;

        // generate an array overrun 
        for (i = 0; i < 100; i = i + 1)
            sample[i] = i;
    }
}
//Unhandled Exception: System.IndexOutOfRangeException: Index was outside the bounds of the array.
//   at MainClass.Main()