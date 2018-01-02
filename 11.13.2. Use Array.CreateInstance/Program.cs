using System;

public class MainClass
{
    public static void Main()
    {
        // Create and initialize a new Array instance.
        Array strArr = Array.CreateInstance(typeof(String), 3);
        strArr.SetValue("M", 0);
        strArr.SetValue("C", 1);
        strArr.SetValue("T", 2);

        // Display the values of the Array.
        Console.WriteLine("Initial Array values:");
        for (int i = strArr.GetLowerBound(0); i <= strArr.GetUpperBound(0); i++)
            Console.WriteLine(strArr.GetValue(i));
    }
}
//Initial Array values:
//M
//C
//T